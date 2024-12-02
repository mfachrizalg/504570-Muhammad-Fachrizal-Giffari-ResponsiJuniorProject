namespace _504570_Muhammad_Fachrizal_Giffari_ResponsiJuniorProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 254);
            dataGridView1.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(213, 136);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(154, 42);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(634, 136);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 136);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(154, 42);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 4;
            label1.Text = "Nama Karyawan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 5;
            label2.Text = "Dep. Karyawan :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            comboBox1.Location = new Point(127, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 19);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "logo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(634, 9);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 10;
            label4.Text = "ID Departemen:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(634, 61);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 11;
            label5.Text = "DEV: Developer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(634, 76);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 12;
            label6.Text = "PM: Product Manager";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(634, 45);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 14;
            label8.Text = "ENG: Engineer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(634, 30);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 15;
            label9.Text = "HR: HR";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(634, 91);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 16;
            label10.Text = "FIN: Finance";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(419, 136);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(154, 42);
            btnLoad.TabIndex = 17;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnInsert;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnLoad;
    }
}
