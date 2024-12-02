using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace _504570_Muhammad_Fachrizal_Giffari_ResponsiJuniorProject
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;
        private string connectionString = "Host=localhost;Database=responsi;Username=postgres;Password=postgres;Port=5432";

        public Form1()
        {
            InitializeComponent();
            InitializeDataTable(); //enkapsulasi
        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("Nama Karyawan", typeof(string));
            dataTable.Columns.Add("Dep. Karyawan", typeof(string));
            dataGridView1.DataSource = dataTable;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int departmentId = ConvertItemsInComboBoxToIDDepartemen(comboBox1.SelectedItem.ToString()); //enkapsulasi
                if (departmentId != 0)
                {
                    Employee employee = new Employee(0, textBox1.Text, departmentId, ConvertItemsInComboBoxToNamaDepartemen(comboBox1.SelectedItem.ToString()));
                    AddEmployeeToDatabase(employee); //enkapsulasi
                    LoadkaryawanFromDatabase(); //enkapsulasi
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && comboBox1.SelectedItem != null)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int departmentId = ConvertItemsInComboBoxToIDDepartemen(comboBox1.SelectedItem.ToString()); //enkapulasi
                if (departmentId != 0)
                {
                    Employee employee = new Employee(0, textBox1.Text, departmentId, ConvertItemsInComboBoxToNamaDepartemen(comboBox1.SelectedItem.ToString()));
                    UpdateEmployeeInDatabase(selectedRow, employee); //enkapsulasi
                    LoadkaryawanFromDatabase(); //enkapsulasi
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                DeleteEmployeeFromDatabase(selectedRow); //enkapsulasi
                LoadkaryawanFromDatabase(); //enkapsulasi
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadkaryawanFromDatabase(); //enkapsulasi
        }

        private void AddEmployeeToDatabase(Employee employee)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Check if the id_karyawan already exists
                var checkCommand = new NpgsqlCommand("SELECT COUNT(1) FROM karyawan WHERE id_karyawan = @id", connection);
                checkCommand.Parameters.AddWithValue("id", employee.Id_karyawan);
                var exists = (long)checkCommand.ExecuteScalar() > 0;

                if (exists)
                {
                    // Handle the duplicate key scenario
                    throw new Exception("Duplicate id_karyawan value.");
                }

                var command = new NpgsqlCommand("INSERT INTO karyawan (id_karyawan, nama, id_dep) VALUES (@id, @name, @department)", connection);
                command.Parameters.AddWithValue("id", employee.Id_karyawan);
                command.Parameters.AddWithValue("name", employee.Nama);
                command.Parameters.AddWithValue("department", employee.Id_dep);
                command.ExecuteNonQuery();
            }
        }

        private void UpdateEmployeeInDatabase(DataGridViewRow row, Employee employee)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("UPDATE karyawan SET nama = @name, id_dep = @department WHERE id_karyawan = @id", connection);
                command.Parameters.AddWithValue("name", employee.Nama);
                command.Parameters.AddWithValue("department", employee.Id_dep);
                command.Parameters.AddWithValue("id", row.Cells["id"].Value);
                command.ExecuteNonQuery();
            }
        }

        private void DeleteEmployeeFromDatabase(DataGridViewRow row)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("DELETE FROM karyawan WHERE id_karyawan = @id", connection);
                command.Parameters.AddWithValue("id", row.Cells["id"].Value);
                command.ExecuteNonQuery();
            }
        }

        private void LoadkaryawanFromDatabase()
        {
            dataTable.Clear();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT * FROM karyawan", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataRow row = dataTable.NewRow();
                        row["id"] = reader["id_karyawan"];
                        row["Nama Karyawan"] = reader["nama"];
                        row["Dep. Karyawan"] = reader["id_dep"];
                        dataTable.Rows.Add(row);
                    }
                }
            }
        }

        private int ConvertItemsInComboBoxToIDDepartemen(string id)
        {
            return id switch
            {
                "HR" => 5,
                "ENG" => 4,
                "DEV" => 3,
                "PM" => 2,
                "FIN" => 1,
                _ => 0,
            };
        }

        private string ConvertItemsInComboBoxToNamaDepartemen(string id)
        {
            return id switch
            {
                "HR" => "HR",
                "ENG" => "Engineer",
                "DEV" => "Developer",
                "PM" => "Product Manager",
                "FIN" => "Finance",
                _ => "Unknown",
            };
        }
    }

    public class Departemen
    {
        private int Id_dep { get; set; }
        private string Nama_dep { get; set; }
        public Departemen(int _id_dep, string _nama_dep)
        {
            Id_dep = _id_dep;
            Nama_dep = _nama_dep;
        }
    }

    public class Employee : Departemen //inheritance
    {
        public int Id_karyawan { get; set; }
        public string Nama { get; set; }
        public int Id_dep { get; set; }
        public Employee(int _id_karyawan, string _nama, int _id_dep, string _nama_dep) : base(0, _nama_dep)
        {
            Id_karyawan = _id_karyawan;
            Nama = _nama;
            Id_dep = _id_dep;
        }
    }
}