namespace StudentManagementSystem
{
    partial class FinalResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            dataOne = new DataGridView();
            cbdepartment = new ComboBox();
            cbclass = new ComboBox();
            cbgeneration = new ComboBox();
            cbyear = new ComboBox();
            cbshift = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbsemester = new ComboBox();
            Semester = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataOne).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1286, 63);
            panel1.TabIndex = 1;
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
            // dataOne
            // 
            dataOne.AllowUserToAddRows = false;
            dataOne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOne.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataOne.Location = new Point(12, 135);
            dataOne.Name = "dataOne";
            dataOne.ReadOnly = true;
            dataOne.Size = new Size(1259, 586);
            dataOne.TabIndex = 2;
            // 
            // cbdepartment
            // 
            cbdepartment.Font = new Font("Segoe UI", 12F);
            cbdepartment.FormattingEnabled = true;
            cbdepartment.Location = new Point(21, 100);
            cbdepartment.Name = "cbdepartment";
            cbdepartment.Size = new Size(186, 29);
            cbdepartment.TabIndex = 3;
            // 
            // cbclass
            // 
            cbclass.Font = new Font("Segoe UI", 12F);
            cbclass.FormattingEnabled = true;
            cbclass.Location = new Point(233, 100);
            cbclass.Name = "cbclass";
            cbclass.Size = new Size(186, 29);
            cbclass.TabIndex = 4;
            // 
            // cbgeneration
            // 
            cbgeneration.Font = new Font("Segoe UI", 12F);
            cbgeneration.FormattingEnabled = true;
            cbgeneration.Location = new Point(445, 100);
            cbgeneration.Name = "cbgeneration";
            cbgeneration.Size = new Size(186, 29);
            cbgeneration.TabIndex = 5;
            // 
            // cbyear
            // 
            cbyear.Font = new Font("Segoe UI", 12F);
            cbyear.FormattingEnabled = true;
            cbyear.Location = new Point(657, 100);
            cbyear.Name = "cbyear";
            cbyear.Size = new Size(186, 29);
            cbyear.TabIndex = 6;
            // 
            // cbshift
            // 
            cbshift.Font = new Font("Segoe UI", 12F);
            cbshift.FormattingEnabled = true;
            cbshift.Location = new Point(869, 100);
            cbshift.Name = "cbshift";
            cbshift.Size = new Size(186, 29);
            cbshift.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(21, 78);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 8;
            label2.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(869, 78);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 9;
            label1.Text = "Shift";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.Location = new Point(657, 78);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 10;
            label3.Text = "ExamYear";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label4.Location = new Point(445, 78);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 11;
            label4.Text = "Generation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label5.Location = new Point(233, 78);
            label5.Name = "label5";
            label5.Size = new Size(42, 19);
            label5.TabIndex = 12;
            label5.Text = "Class";
            // 
            // cbsemester
            // 
            cbsemester.Font = new Font("Segoe UI", 12F);
            cbsemester.FormattingEnabled = true;
            cbsemester.Location = new Point(1081, 100);
            cbsemester.Name = "cbsemester";
            cbsemester.Size = new Size(186, 29);
            cbsemester.TabIndex = 13;
            // 
            // Semester
            // 
            Semester.AutoSize = true;
            Semester.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Semester.Location = new Point(1081, 78);
            Semester.Name = "Semester";
            Semester.Size = new Size(71, 19);
            Semester.TabIndex = 14;
            Semester.Text = "Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Pixel);
            label6.Location = new Point(557, 19);
            label6.Name = "label6";
            label6.Size = new Size(160, 35);
            label6.TabIndex = 15;
            label6.Text = "Final Results";
            // 
            // FinalResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 733);
            Controls.Add(Semester);
            Controls.Add(cbsemester);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cbshift);
            Controls.Add(cbyear);
            Controls.Add(cbgeneration);
            Controls.Add(cbclass);
            Controls.Add(cbdepartment);
            Controls.Add(dataOne);
            Controls.Add(panel1);
            Name = "FinalResult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalResult";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataOne).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView dataOne;
        private ComboBox cbdepartment;
        private ComboBox cbclass;
        private ComboBox cbgeneration;
        private ComboBox cbyear;
        private ComboBox cbshift;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbsemester;
        private Label Semester;
        private Label label6;
    }
}