namespace StudentManagementSystem
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            stuid = new TextBox();
            stuname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataOne = new DataGridView();
            combodepartment = new ComboBox();
            comboclassroom = new ComboBox();
            comboShift = new ComboBox();
            combogeneration = new ComboBox();
            btnSave = new Button();
            combosemester = new ComboBox();
            label8 = new Label();
            comboCreateAt = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataOne).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1286, 63);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.cross;
            pictureBox1.Location = new Point(1228, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(555, 65);
            label1.Name = "label1";
            label1.Size = new Size(155, 35);
            label1.TabIndex = 1;
            label1.Text = "Result_View";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(12, 140);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 2;
            label2.Text = "StudentID";
            // 
            // stuid
            // 
            stuid.Font = new Font("Segoe UI", 11F);
            stuid.Location = new Point(12, 162);
            stuid.Multiline = true;
            stuid.Name = "stuid";
            stuid.ReadOnly = true;
            stuid.Size = new Size(201, 38);
            stuid.TabIndex = 3;
            // 
            // stuname
            // 
            stuname.Font = new Font("Segoe UI", 11F);
            stuname.Location = new Point(12, 231);
            stuname.Multiline = true;
            stuname.Name = "stuname";
            stuname.ReadOnly = true;
            stuname.Size = new Size(201, 38);
            stuname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.Location = new Point(12, 209);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 4;
            label3.Text = "StudentName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label4.Location = new Point(12, 275);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 6;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label5.Location = new Point(12, 333);
            label5.Name = "label5";
            label5.Size = new Size(79, 19);
            label5.TabIndex = 8;
            label5.Text = "Classroom";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label6.Location = new Point(12, 388);
            label6.Name = "label6";
            label6.Size = new Size(83, 19);
            label6.TabIndex = 10;
            label6.Text = "Generation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label7.Location = new Point(12, 443);
            label7.Name = "label7";
            label7.Size = new Size(39, 19);
            label7.TabIndex = 12;
            label7.Text = "Shift";
            // 
            // dataOne
            // 
            dataOne.AllowUserToAddRows = false;
            dataOne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOne.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataOne.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataOne.ColumnHeadersHeight = 25;
            dataOne.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataOne.DefaultCellStyle = dataGridViewCellStyle3;
            dataOne.Location = new Point(246, 162);
            dataOne.Name = "dataOne";
            dataOne.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataOne.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataOne.RowHeadersWidth = 60;
            dataOne.Size = new Size(979, 523);
            dataOne.TabIndex = 16;
            // 
            // combodepartment
            // 
            combodepartment.DisplayMember = "departmentName";
            combodepartment.Font = new Font("Segoe UI", 12F);
            combodepartment.FormattingEnabled = true;
            combodepartment.Location = new Point(12, 297);
            combodepartment.Name = "combodepartment";
            combodepartment.Size = new Size(201, 29);
            combodepartment.TabIndex = 17;
            // 
            // comboclassroom
            // 
            comboclassroom.Font = new Font("Segoe UI", 12F);
            comboclassroom.FormattingEnabled = true;
            comboclassroom.Location = new Point(12, 355);
            comboclassroom.Name = "comboclassroom";
            comboclassroom.Size = new Size(201, 29);
            comboclassroom.TabIndex = 18;
            // 
            // comboShift
            // 
            comboShift.Font = new Font("Segoe UI", 12F);
            comboShift.FormattingEnabled = true;
            comboShift.Location = new Point(12, 465);
            comboShift.Name = "comboShift";
            comboShift.Size = new Size(201, 29);
            comboShift.TabIndex = 19;
            // 
            // combogeneration
            // 
            combogeneration.Font = new Font("Segoe UI", 12F);
            combogeneration.FormattingEnabled = true;
            combogeneration.Location = new Point(12, 410);
            combogeneration.Name = "combogeneration";
            combogeneration.Size = new Size(201, 29);
            combogeneration.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(66, 647);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 38);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // combosemester
            // 
            combosemester.Font = new Font("Segoe UI", 12F);
            combosemester.FormattingEnabled = true;
            combosemester.Location = new Point(12, 581);
            combosemester.Name = "combosemester";
            combosemester.Size = new Size(201, 29);
            combosemester.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label8.Location = new Point(15, 559);
            label8.Name = "label8";
            label8.Size = new Size(75, 19);
            label8.TabIndex = 24;
            label8.Text = "Semester ";
            // 
            // comboCreateAt
            // 
            comboCreateAt.Font = new Font("Segoe UI", 12F);
            comboCreateAt.FormattingEnabled = true;
            comboCreateAt.Location = new Point(12, 527);
            comboCreateAt.Name = "comboCreateAt";
            comboCreateAt.Size = new Size(201, 29);
            comboCreateAt.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label9.Location = new Point(15, 505);
            label9.Name = "label9";
            label9.Size = new Size(0, 19);
            label9.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label10.Location = new Point(15, 505);
            label10.Name = "label10";
            label10.Size = new Size(75, 19);
            label10.TabIndex = 27;
            label10.Text = "YearExam";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 733);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboCreateAt);
            Controls.Add(label8);
            Controls.Add(combosemester);
            Controls.Add(btnSave);
            Controls.Add(combogeneration);
            Controls.Add(comboShift);
            Controls.Add(comboclassroom);
            Controls.Add(combodepartment);
            Controls.Add(dataOne);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(stuname);
            Controls.Add(label3);
            Controls.Add(stuid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataOne).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox stuid;
        private TextBox stuname;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataOne;
        private ComboBox combodepartment;
        private ComboBox comboclassroom;
        private ComboBox comboShift;
        private ComboBox combogeneration;
        private Button btnSave;
        private ComboBox combosemester;
        private Label label8;
        private ComboBox comboCreateAt;
        private Label label9;
        private Label label10;
    }
}
