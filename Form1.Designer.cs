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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            stuid = new TextBox();
            stuname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            generation = new TextBox();
            label6 = new Label();
            shift = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            dataOne = new DataGridView();
            combodepartment = new ComboBox();
            comboclassroom = new ComboBox();
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
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(478, 88);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 1;
            label1.Text = "BluePrint";
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
            stuid.Size = new Size(201, 37);
            stuid.TabIndex = 3;
            // 
            // stuname
            // 
            stuname.Font = new Font("Segoe UI", 11F);
            stuname.Location = new Point(12, 225);
            stuname.Multiline = true;
            stuname.Name = "stuname";
            stuname.Size = new Size(201, 37);
            stuname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.Location = new Point(12, 203);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 4;
            label3.Text = "StudentName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label4.Location = new Point(12, 265);
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
            // generation
            // 
            generation.Font = new Font("Segoe UI", 11F);
            generation.Location = new Point(12, 424);
            generation.Multiline = true;
            generation.Name = "generation";
            generation.Size = new Size(201, 37);
            generation.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label6.Location = new Point(12, 402);
            label6.Name = "label6";
            label6.Size = new Size(83, 19);
            label6.TabIndex = 10;
            label6.Text = "Generation";
            // 
            // shift
            // 
            shift.Font = new Font("Segoe UI", 11F);
            shift.Location = new Point(12, 490);
            shift.Multiline = true;
            shift.Name = "shift";
            shift.Size = new Size(201, 37);
            shift.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label7.Location = new Point(12, 468);
            label7.Name = "label7";
            label7.Size = new Size(39, 19);
            label7.TabIndex = 12;
            label7.Text = "Shift";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 559);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(201, 37);
            textBox7.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label8.Location = new Point(12, 537);
            label8.Name = "label8";
            label8.Size = new Size(70, 19);
            label8.TabIndex = 14;
            label8.Text = "BluePrint";
            // 
            // dataOne
            // 
            dataOne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOne.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataOne.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataOne.ColumnHeadersHeight = 25;
            dataOne.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataOne.DefaultCellStyle = dataGridViewCellStyle1;
            dataOne.Location = new Point(246, 162);
            dataOne.Name = "dataOne";
            dataOne.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataOne.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataOne.RowHeadersWidth = 60;
            dataOne.Size = new Size(979, 523);
            dataOne.TabIndex = 16;
            // 
            // combodepartment
            // 
            combodepartment.DisplayMember = "departmentName";
            combodepartment.Font = new Font("Segoe UI", 11F);
            combodepartment.FormattingEnabled = true;
            combodepartment.Location = new Point(12, 287);
            combodepartment.Name = "combodepartment";
            combodepartment.Size = new Size(201, 28);
            combodepartment.TabIndex = 17;
            // 
            // comboclassroom
            // 
            comboclassroom.Font = new Font("Segoe UI", 11F);
            comboclassroom.FormattingEnabled = true;
            comboclassroom.Location = new Point(12, 355);
            comboclassroom.Name = "comboclassroom";
            comboclassroom.Size = new Size(201, 28);
            comboclassroom.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 733);
            Controls.Add(comboclassroom);
            Controls.Add(combodepartment);
            Controls.Add(dataOne);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(shift);
            Controls.Add(label7);
            Controls.Add(generation);
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
        private TextBox generation;
        private Label label6;
        private TextBox shift;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private DataGridView dataOne;
        private ComboBox combodepartment;
        private ComboBox comboclassroom;
    }
}
