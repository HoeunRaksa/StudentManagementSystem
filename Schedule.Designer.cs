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
            label1.Location = new Point(633, 31);
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1470, 84);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(523, 124);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label7.Location = new Point(6, 267);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 7;
            label7.Text = "Class Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label8.Location = new Point(6, 199);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 8;
            label8.Text = "SubjectName";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label9.Location = new Point(6, 341);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 9;
            label9.Text = "Schedule  Day";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label10.Location = new Point(6, 424);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 10;
            label10.Text = "Year";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label11.Location = new Point(6, 573);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 11;
            label11.Text = "Time Start";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label12.Location = new Point(6, 657);
            label12.Name = "label12";
            label12.Size = new Size(74, 20);
            label12.TabIndex = 12;
            label12.Text = "Time End";
            // 
            // comboDepartment
            // 
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Location = new Point(523, 158);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(187, 28);
            comboDepartment.TabIndex = 13;
            // 
            // comboSubject
            // 
            comboSubject.FormattingEnabled = true;
            comboSubject.Location = new Point(6, 222);
            comboSubject.Name = "comboSubject";
            comboSubject.Size = new Size(187, 28);
            comboSubject.TabIndex = 18;
            // 
            // comboClassroom
            // 
            comboClassroom.FormattingEnabled = true;
            comboClassroom.Location = new Point(6, 290);
            comboClassroom.Name = "comboClassroom";
            comboClassroom.Size = new Size(187, 28);
            comboClassroom.TabIndex = 19;
            // 
            // dataGridViewSchedule
            // 
            dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedule.Location = new Point(244, 199);
            dataGridViewSchedule.Name = "dataGridViewSchedule";
            dataGridViewSchedule.RowHeadersWidth = 51;
            dataGridViewSchedule.Size = new Size(1210, 727);
            dataGridViewSchedule.TabIndex = 22;
            // 
            // timeStart
            // 
            timeStart.Format = DateTimePickerFormat.Time;
            timeStart.Location = new Point(6, 596);
            timeStart.Name = "timeStart";
            timeStart.Size = new Size(187, 27);
            timeStart.TabIndex = 23;
            // 
            // timeEnd
            // 
            timeEnd.Format = DateTimePickerFormat.Time;
            timeEnd.Location = new Point(6, 680);
            timeEnd.Name = "timeEnd";
            timeEnd.Size = new Size(187, 27);
            timeEnd.TabIndex = 24;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(2, 737);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 48);
            btnInsert.TabIndex = 25;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(102, 737);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 48);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label13.Location = new Point(6, 500);
            label13.Name = "label13";
            label13.Size = new Size(74, 20);
            label13.TabIndex = 27;
            label13.Text = "Semester";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label14.Location = new Point(1056, 124);
            label14.Name = "label14";
            label14.Size = new Size(125, 20);
            label14.TabIndex = 28;
            label14.Text = "Instructor Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label5.Location = new Point(244, 124);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 27;
            label5.Text = "Schedule  ID";
            // 
            // comboScheduleID
            // 
            comboScheduleID.FormattingEnabled = true;
            comboScheduleID.Location = new Point(244, 158);
            comboScheduleID.Name = "comboScheduleID";
            comboScheduleID.Size = new Size(187, 28);
            comboScheduleID.TabIndex = 26;
            // 
            // txtInstructorName
            // 
            txtInstructorName.Location = new Point(1056, 158);
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.Size = new Size(197, 27);
            txtInstructorName.TabIndex = 31;
            // 
            // comboDay
            // 
            comboDay.FormattingEnabled = true;
            comboDay.Location = new Point(6, 373);
            comboDay.Name = "comboDay";
            comboDay.Size = new Size(187, 28);
            comboDay.TabIndex = 32;
            // 
            // comboYear
            // 
            comboYear.FormattingEnabled = true;
            comboYear.Location = new Point(6, 447);
            comboYear.Name = "comboYear";
            comboYear.Size = new Size(187, 28);
            comboYear.TabIndex = 33;
            // 
            // comboSemester
            // 
            comboSemester.FormattingEnabled = true;
            comboSemester.Location = new Point(6, 523);
            comboSemester.Name = "comboSemester";
            comboSemester.Size = new Size(187, 28);
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
            label3.Location = new Point(794, 124);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 35;
            label3.Text = "Instructor ID";
            // 
            // comboInstructorID
            // 
            comboInstructorID.FormattingEnabled = true;
            comboInstructorID.Location = new Point(794, 158);
            comboInstructorID.Name = "comboInstructorID";
            comboInstructorID.Size = new Size(187, 28);
            comboInstructorID.TabIndex = 36;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(58, 806);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 49);
            btnRefresh.TabIndex = 37;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 977);
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
            Name = "Schedule";
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