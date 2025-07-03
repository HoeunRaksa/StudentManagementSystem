namespace StudentManagementSystem
{
    partial class Student_Form
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
            chkStudy = new CheckBox();
            groupBox1 = new GroupBox();
            btnNew = new Button();
            btnRefresh = new Button();
            txtGeneration = new TextBox();
            chkMale = new CheckBox();
            chkFemale = new CheckBox();
            cboClassID = new ComboBox();
            cboDepartmentID = new ComboBox();
            label22 = new Label();
            label23 = new Label();
            txtBirthAddress = new TextBox();
            label18 = new Label();
            label12 = new Label();
            label6 = new Label();
            txtParentPhone = new TextBox();
            btnLogout = new Button();
            chkStopStudy = new CheckBox();
            btnUpdate = new Button();
            btnInsert = new Button();
            label20 = new Label();
            label21 = new Label();
            label19 = new Label();
            txtAddress = new TextBox();
            label = new Label();
            dgvStudent = new DataGridView();
            label9 = new Label();
            txtStudentID = new TextBox();
            dtpEnterDate = new DateTimePicker();
            txtSearch = new TextBox();
            label15 = new Label();
            StaffID = new Label();
            dtpBirthDate = new DateTimePicker();
            ID = new Label();
            label7 = new Label();
            label1 = new Label();
            label16 = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNameKH = new TextBox();
            txtNameEN = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            txtPhone = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label17 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            btnHome = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chkStudy
            // 
            chkStudy.AutoSize = true;
            chkStudy.Location = new Point(760, 141);
            chkStudy.Margin = new Padding(3, 2, 3, 2);
            chkStudy.Name = "chkStudy";
            chkStudy.Size = new Size(56, 19);
            chkStudy.TabIndex = 149;
            chkStudy.Text = "Study";
            chkStudy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(txtGeneration);
            groupBox1.Controls.Add(chkMale);
            groupBox1.Controls.Add(chkFemale);
            groupBox1.Controls.Add(cboClassID);
            groupBox1.Controls.Add(cboDepartmentID);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(txtBirthAddress);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(chkStudy);
            groupBox1.Controls.Add(txtParentPhone);
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Controls.Add(chkStopStudy);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnInsert);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(dgvStudent);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(dtpEnterDate);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(StaffID);
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Controls.Add(ID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNameKH);
            groupBox1.Controls.Add(txtNameEN);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(3, 52);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1280, 634);
            groupBox1.TabIndex = 183;
            groupBox1.TabStop = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.YellowGreen;
            btnNew.ForeColor = SystemColors.ButtonHighlight;
            btnNew.Location = new Point(868, 255);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(99, 35);
            btnNew.TabIndex = 201;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGoldenrodYellow;
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(172, 276);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(83, 28);
            btnRefresh.TabIndex = 200;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtGeneration
            // 
            txtGeneration.Location = new Point(759, 111);
            txtGeneration.Margin = new Padding(3, 2, 3, 2);
            txtGeneration.Name = "txtGeneration";
            txtGeneration.Size = new Size(305, 23);
            txtGeneration.TabIndex = 147;
            // 
            // chkMale
            // 
            chkMale.AutoSize = true;
            chkMale.Location = new Point(273, 116);
            chkMale.Margin = new Padding(3, 2, 3, 2);
            chkMale.Name = "chkMale";
            chkMale.Size = new Size(52, 19);
            chkMale.TabIndex = 139;
            chkMale.Text = "Male";
            chkMale.UseVisualStyleBackColor = true;
            // 
            // chkFemale
            // 
            chkFemale.AutoSize = true;
            chkFemale.Location = new Point(346, 116);
            chkFemale.Margin = new Padding(3, 2, 3, 2);
            chkFemale.Name = "chkFemale";
            chkFemale.Size = new Size(64, 19);
            chkFemale.TabIndex = 199;
            chkFemale.Text = "Female";
            chkFemale.UseVisualStyleBackColor = true;
            // 
            // cboClassID
            // 
            cboClassID.FormattingEnabled = true;
            cboClassID.Location = new Point(761, 199);
            cboClassID.Margin = new Padding(3, 2, 3, 2);
            cboClassID.Name = "cboClassID";
            cboClassID.Size = new Size(305, 23);
            cboClassID.TabIndex = 151;
            // 
            // cboDepartmentID
            // 
            cboDepartmentID.FormattingEnabled = true;
            cboDepartmentID.Location = new Point(761, 167);
            cboDepartmentID.Margin = new Padding(3, 2, 3, 2);
            cboDepartmentID.Name = "cboDepartmentID";
            cboDepartmentID.Size = new Size(305, 23);
            cboDepartmentID.TabIndex = 150;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(731, 113);
            label22.Name = "label22";
            label22.Size = new Size(0, 15);
            label22.TabIndex = 193;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(654, 116);
            label23.Name = "label23";
            label23.Size = new Size(68, 15);
            label23.TabIndex = 192;
            label23.Text = "Generation:";
            // 
            // txtBirthAddress
            // 
            txtBirthAddress.Location = new Point(761, 20);
            txtBirthAddress.Margin = new Padding(3, 2, 3, 2);
            txtBirthAddress.Name = "txtBirthAddress";
            txtBirthAddress.Size = new Size(305, 23);
            txtBirthAddress.TabIndex = 144;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(653, 24);
            label18.Name = "label18";
            label18.Size = new Size(80, 15);
            label18.TabIndex = 190;
            label18.Text = "Birth Address:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(657, 205);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 188;
            label12.Text = "Class ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(655, 173);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 186;
            label6.Text = "Department ID:";
            // 
            // txtParentPhone
            // 
            txtParentPhone.Location = new Point(273, 231);
            txtParentPhone.Margin = new Padding(3, 2, 3, 2);
            txtParentPhone.Name = "txtParentPhone";
            txtParentPhone.Size = new Size(305, 23);
            txtParentPhone.TabIndex = 143;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(972, 255);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(99, 35);
            btnLogout.TabIndex = 176;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // chkStopStudy
            // 
            chkStopStudy.AutoSize = true;
            chkStopStudy.Location = new Point(833, 141);
            chkStopStudy.Margin = new Padding(3, 2, 3, 2);
            chkStopStudy.Name = "chkStopStudy";
            chkStopStudy.Size = new Size(83, 19);
            chkStopStudy.TabIndex = 181;
            chkStopStudy.Text = "Stop Study";
            chkStopStudy.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Navy;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(761, 255);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 35);
            btnUpdate.TabIndex = 174;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Green;
            btnInsert.ForeColor = SystemColors.ButtonHighlight;
            btnInsert.Location = new Point(655, 255);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 35);
            btnInsert.TabIndex = 173;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(735, 136);
            label20.Name = "label20";
            label20.Size = new Size(0, 15);
            label20.TabIndex = 179;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(654, 144);
            label21.Name = "label21";
            label21.Size = new Size(42, 15);
            label21.TabIndex = 178;
            label21.Text = "Status:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(930, 67);
            label19.Name = "label19";
            label19.Size = new Size(0, 15);
            label19.TabIndex = 175;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(760, 48);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(305, 23);
            txtAddress.TabIndex = 145;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(653, 52);
            label.Name = "label";
            label.Size = new Size(52, 15);
            label.TabIndex = 176;
            label.Text = "Address:";
            // 
            // dgvStudent
            // 
            dgvStudent.BackgroundColor = SystemColors.ActiveBorder;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(5, 319);
            dgvStudent.Margin = new Padding(3, 2, 3, 2);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(1270, 305);
            dgvStudent.TabIndex = 156;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(246, 112);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 147;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(273, 20);
            txtStudentID.Margin = new Padding(3, 2, 3, 2);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(305, 23);
            txtStudentID.TabIndex = 136;
            // 
            // dtpEnterDate
            // 
            dtpEnterDate.Location = new Point(760, 80);
            dtpEnterDate.Margin = new Padding(3, 2, 3, 2);
            dtpEnterDate.Name = "dtpEnterDate";
            dtpEnterDate.Size = new Size(303, 23);
            dtpEnterDate.TabIndex = 146;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(273, 281);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(305, 23);
            txtSearch.TabIndex = 154;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(273, 262);
            label15.Name = "label15";
            label15.Size = new Size(56, 15);
            label15.TabIndex = 155;
            label15.Text = "Search ID";
            // 
            // StaffID
            // 
            StaffID.AutoSize = true;
            StaffID.Location = new Point(173, 25);
            StaffID.Name = "StaffID";
            StaffID.Size = new Size(65, 15);
            StaffID.TabIndex = 129;
            StaffID.Text = "Student ID:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(273, 142);
            dtpBirthDate.Margin = new Padding(3, 2, 3, 2);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(305, 23);
            dtpBirthDate.TabIndex = 140;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(283, 58);
            ID.Name = "ID";
            ID.Size = new Size(0, 15);
            ID.TabIndex = 130;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(653, 82);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 166;
            label7.Text = "Enter Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 58);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 131;
            label1.Text = "NameEN:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(770, 90);
            label16.Name = "label16";
            label16.Size = new Size(0, 15);
            label16.TabIndex = 165;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 116);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 132;
            label2.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 146);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 133;
            label5.Text = "Birth Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 141);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 134;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 86);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 135;
            label3.Text = "Name KH:";
            // 
            // txtNameKH
            // 
            txtNameKH.Location = new Point(273, 82);
            txtNameKH.Margin = new Padding(3, 2, 3, 2);
            txtNameKH.Name = "txtNameKH";
            txtNameKH.Size = new Size(305, 23);
            txtNameKH.TabIndex = 138;
            // 
            // txtNameEN
            // 
            txtNameEN.Location = new Point(273, 52);
            txtNameEN.Margin = new Padding(3, 2, 3, 2);
            txtNameEN.Name = "txtNameEN";
            txtNameEN.Size = new Size(305, 23);
            txtNameEN.TabIndex = 137;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(175, 236);
            label14.Name = "label14";
            label14.Size = new Size(81, 15);
            label14.TabIndex = 142;
            label14.Text = "Parent Phone:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(774, 156);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 143;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(175, 207);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 145;
            label11.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(273, 202);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(305, 23);
            txtPhone.TabIndex = 142;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(174, 176);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 148;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(273, 172);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(305, 23);
            txtEmail.TabIndex = 141;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(514, 0);
            label17.Name = "label17";
            label17.Size = new Size(298, 37);
            label17.TabIndex = 0;
            label17.Text = "Student's Information";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Location = new Point(0, 692);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1283, 41);
            panel2.TabIndex = 185;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(label17);
            panel1.Location = new Point(2, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 41);
            panel1.TabIndex = 184;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(1188, 13);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(82, 22);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // Student_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 733);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Student_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chkStudy;
        private GroupBox groupBox1;
        private TextBox txtParentPhone;
        private Button btnLogout;
        private CheckBox chkStopStudy;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label20;
        private Label label21;
        private Label label19;
        private TextBox txtAddress;
        private Label label;
        private DataGridView dgvStudent;
        private Label label9;
        private TextBox txtStudentID;
        private DateTimePicker dtpEnterDate;
        private TextBox txtSearch;
        private Label label15;
        private Label StaffID;
        private DateTimePicker dtpBirthDate;
        private Label ID;
        private Label label7;
        private Label label1;
        private Label label16;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNameKH;
        private TextBox txtNameEN;
        private Label label14;
        private Label label13;
        private Label label11;
        private TextBox txtPhone;
        private Label label8;
        private TextBox txtEmail;
        private Label label17;
        private Panel panel2;
        private Panel panel1;
        private Label label12;
        private Label label6;
        private TextBox txtBirthAddress;
        private Label label18;
        private Label label22;
        private Label label23;
        private ComboBox cboClassID;
        private ComboBox cboDepartmentID;
        private CheckBox chkMale;
        private CheckBox chkFemale;
        private TextBox txtGeneration;
        private Button btnRefresh;
        private Button btnNew;
        private Button btnHome;
    }
}