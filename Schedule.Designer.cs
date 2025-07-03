namespace StudentManagementSystem
{
    partial class Schedule
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboDepartment = new ComboBox();
            comboSubject = new ComboBox();
            comboClassroom = new ComboBox();
            dataGridViewSchedule = new DataGridView();
            timeStart = new DateTimePicker();
            timeEnd = new DateTimePicker();
            btnInsert = new Button();
            btnUpdate = new Button();
            label13 = new Label();
            label14 = new Label();
            label5 = new Label();
            comboScheduleID = new ComboBox();
            txtInstructorName = new TextBox();
            comboDay = new ComboBox();
            comboYear = new ComboBox();
            comboSemester = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            comboInstructorID = new ComboBox();
            btnRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(554, 23);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 0;
            label1.Text = "Schedule";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.DarkOrange;
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1286, 63);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(458, 93);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 2;
            label2.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label7.Location = new Point(5, 200);
            label7.Name = "label7";
            label7.Size = new Size(86, 19);
            label7.TabIndex = 7;
            label7.Text = "Class Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label8.Location = new Point(5, 149);
            label8.Name = "label8";
            label8.Size = new Size(98, 19);
            label8.TabIndex = 8;
            label8.Text = "SubjectName";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label9.Location = new Point(5, 256);
            label9.Name = "label9";
            label9.Size = new Size(103, 19);
            label9.TabIndex = 9;
            label9.Text = "Schedule  Day";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label10.Location = new Point(5, 318);
            label10.Name = "label10";
            label10.Size = new Size(39, 19);
            label10.TabIndex = 10;
            label10.Text = "Year";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label11.Location = new Point(5, 430);
            label11.Name = "label11";
            label11.Size = new Size(78, 19);
            label11.TabIndex = 11;
            label11.Text = "Time Start";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label12.Location = new Point(5, 493);
            label12.Name = "label12";
            label12.Size = new Size(70, 19);
            label12.TabIndex = 12;
            label12.Text = "Time End";
            // 
            // comboDepartment
            // 
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Location = new Point(458, 118);
            comboDepartment.Margin = new Padding(3, 2, 3, 2);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(164, 23);
            comboDepartment.TabIndex = 13;
            // 
            // comboSubject
            // 
            comboSubject.FormattingEnabled = true;
            comboSubject.Location = new Point(5, 166);
            comboSubject.Margin = new Padding(3, 2, 3, 2);
            comboSubject.Name = "comboSubject";
            comboSubject.Size = new Size(164, 23);
            comboSubject.TabIndex = 18;
            // 
            // comboClassroom
            // 
            comboClassroom.FormattingEnabled = true;
            comboClassroom.Location = new Point(5, 218);
            comboClassroom.Margin = new Padding(3, 2, 3, 2);
            comboClassroom.Name = "comboClassroom";
            comboClassroom.Size = new Size(164, 23);
            comboClassroom.TabIndex = 19;
            // 
            // dataGridViewSchedule
            // 
            dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedule.Location = new Point(214, 149);
            dataGridViewSchedule.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSchedule.Name = "dataGridViewSchedule";
            dataGridViewSchedule.RowHeadersWidth = 51;
            dataGridViewSchedule.Size = new Size(1059, 545);
            dataGridViewSchedule.TabIndex = 22;
            // 
            // timeStart
            // 
            timeStart.Format = DateTimePickerFormat.Time;
            timeStart.Location = new Point(5, 447);
            timeStart.Margin = new Padding(3, 2, 3, 2);
            timeStart.Name = "timeStart";
            timeStart.Size = new Size(164, 23);
            timeStart.TabIndex = 23;
            // 
            // timeEnd
            // 
            timeEnd.Format = DateTimePickerFormat.Time;
            timeEnd.Location = new Point(5, 510);
            timeEnd.Margin = new Padding(3, 2, 3, 2);
            timeEnd.Name = "timeEnd";
            timeEnd.Size = new Size(164, 23);
            timeEnd.TabIndex = 24;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(2, 553);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(82, 36);
            btnInsert.TabIndex = 25;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(89, 553);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 36);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label13.Location = new Point(5, 375);
            label13.Name = "label13";
            label13.Size = new Size(71, 19);
            label13.TabIndex = 27;
            label13.Text = "Semester";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label14.Location = new Point(924, 93);
            label14.Name = "label14";
            label14.Size = new Size(117, 19);
            label14.TabIndex = 28;
            label14.Text = "Instructor Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label5.Location = new Point(214, 93);
            label5.Name = "label5";
            label5.Size = new Size(91, 19);
            label5.TabIndex = 27;
            label5.Text = "Schedule  ID";
            // 
            // comboScheduleID
            // 
            comboScheduleID.FormattingEnabled = true;
            comboScheduleID.Location = new Point(214, 118);
            comboScheduleID.Margin = new Padding(3, 2, 3, 2);
            comboScheduleID.Name = "comboScheduleID";
            comboScheduleID.Size = new Size(164, 23);
            comboScheduleID.TabIndex = 26;
            // 
            // txtInstructorName
            // 
            txtInstructorName.Location = new Point(924, 118);
            txtInstructorName.Margin = new Padding(3, 2, 3, 2);
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.Size = new Size(173, 23);
            txtInstructorName.TabIndex = 31;
            // 
            // comboDay
            // 
            comboDay.FormattingEnabled = true;
            comboDay.Location = new Point(5, 280);
            comboDay.Margin = new Padding(3, 2, 3, 2);
            comboDay.Name = "comboDay";
            comboDay.Size = new Size(164, 23);
            comboDay.TabIndex = 32;
            // 
            // comboYear
            // 
            comboYear.FormattingEnabled = true;
            comboYear.Location = new Point(5, 335);
            comboYear.Margin = new Padding(3, 2, 3, 2);
            comboYear.Name = "comboYear";
            comboYear.Size = new Size(164, 23);
            comboYear.TabIndex = 33;
            // 
            // comboSemester
            // 
            comboSemester.FormattingEnabled = true;
            comboSemester.Location = new Point(5, 392);
            comboSemester.Margin = new Padding(3, 2, 3, 2);
            comboSemester.Name = "comboSemester";
            comboSemester.Size = new Size(164, 23);
            comboSemester.TabIndex = 34;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.Location = new Point(695, 93);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 35;
            label3.Text = "Instructor ID";
            // 
            // comboInstructorID
            // 
            comboInstructorID.FormattingEnabled = true;
            comboInstructorID.Location = new Point(695, 118);
            comboInstructorID.Margin = new Padding(3, 2, 3, 2);
            comboInstructorID.Name = "comboInstructorID";
            comboInstructorID.Size = new Size(164, 23);
            comboInstructorID.TabIndex = 36;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(51, 604);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 37);
            btnRefresh.TabIndex = 37;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 733);
            Controls.Add(btnRefresh);
            Controls.Add(comboInstructorID);
            Controls.Add(label3);
            Controls.Add(comboSemester);
            Controls.Add(comboYear);
            Controls.Add(comboDay);
            Controls.Add(txtInstructorName);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(comboDepartment);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(comboScheduleID);
            Controls.Add(label5);
            Controls.Add(btnInsert);
            Controls.Add(dataGridViewSchedule);
            Controls.Add(comboClassroom);
            Controls.Add(comboSubject);
            Controls.Add(timeEnd);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(timeStart);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Schedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox comboDepartment;
        private ComboBox comboSubject;
        private ComboBox comboClassroom;
        private DataGridView dataGridViewSchedule;
        private DateTimePicker timeStart;
        private DateTimePicker timeEnd;
        private Button btnInsert;
        private Button btnUpdate;
        private Label label13;
        private ComboBox comboScheduleID;
        private Label label14;
        private Label label5;
        private TextBox txtInstructorName;
        private ComboBox comboDay;
        private ComboBox comboYear;
        private ComboBox comboSemester;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private ComboBox comboInstructorID;
        private Button btnRefresh;
    }
}