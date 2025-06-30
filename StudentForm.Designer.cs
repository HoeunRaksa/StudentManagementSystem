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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chkStudy
            // 
            chkStudy.AutoSize = true;
            chkStudy.Location = new Point(869, 188);
            chkStudy.Name = "chkStudy";
            chkStudy.Size = new Size(68, 24);
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
            groupBox1.Location = new Point(3, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1463, 846);
            groupBox1.TabIndex = 183;
            groupBox1.TabStop = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.YellowGreen;
            btnNew.ForeColor = SystemColors.ButtonHighlight;
            btnNew.Location = new Point(992, 340);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(113, 47);
            btnNew.TabIndex = 201;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGoldenrodYellow;
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(197, 368);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(95, 37);
            btnRefresh.TabIndex = 200;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtGeneration
            // 
            txtGeneration.Location = new Point(867, 148);
            txtGeneration.Name = "txtGeneration";
            txtGeneration.Size = new Size(348, 27);
            txtGeneration.TabIndex = 147;
            // 
            // chkMale
            // 
            chkMale.AutoSize = true;
            chkMale.Location = new Point(312, 154);
            chkMale.Name = "chkMale";
            chkMale.Size = new Size(64, 24);
            chkMale.TabIndex = 139;
            chkMale.Text = "Male";
            chkMale.UseVisualStyleBackColor = true;
            // 
            // chkFemale
            // 
            chkFemale.AutoSize = true;
            chkFemale.Location = new Point(395, 154);
            chkFemale.Name = "chkFemale";
            chkFemale.Size = new Size(79, 24);
            chkFemale.TabIndex = 199;
            chkFemale.Text = "Female";
            chkFemale.UseVisualStyleBackColor = true;
            // 
            // cboClassID
            // 
            cboClassID.FormattingEnabled = true;
            cboClassID.Location = new Point(870, 265);
            cboClassID.Name = "cboClassID";
            cboClassID.Size = new Size(348, 28);
            cboClassID.TabIndex = 151;
            // 
            // cboDepartmentID
            // 
            cboDepartmentID.FormattingEnabled = true;
            cboDepartmentID.Location = new Point(870, 223);
            cboDepartmentID.Name = "cboDepartmentID";
            cboDepartmentID.Size = new Size(348, 28);
            cboDepartmentID.TabIndex = 150;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(835, 151);
            label22.Name = "label22";
            label22.Size = new Size(0, 20);
            label22.TabIndex = 193;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(747, 155);
            label23.Name = "label23";
            label23.Size = new Size(85, 20);
            label23.TabIndex = 192;
            label23.Text = "Generation:";
            // 
            // txtBirthAddress
            // 
            txtBirthAddress.Location = new Point(870, 26);
            txtBirthAddress.Name = "txtBirthAddress";
            txtBirthAddress.Size = new Size(348, 27);
            txtBirthAddress.TabIndex = 144;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(746, 32);
            label18.Name = "label18";
            label18.Size = new Size(100, 20);
            label18.TabIndex = 190;
            label18.Text = "Birth Address:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(751, 273);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 188;
            label12.Text = "Class ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(749, 231);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 186;
            label6.Text = "Department ID:";
            // 
            // txtParentPhone
            // 
            txtParentPhone.Location = new Point(312, 308);
            txtParentPhone.Name = "txtParentPhone";
            txtParentPhone.Size = new Size(348, 27);
            txtParentPhone.TabIndex = 143;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(1111, 340);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(113, 47);
            btnLogout.TabIndex = 176;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // chkStopStudy
            // 
            chkStopStudy.AutoSize = true;
            chkStopStudy.Location = new Point(952, 188);
            chkStopStudy.Name = "chkStopStudy";
            chkStopStudy.Size = new Size(103, 24);
            chkStopStudy.TabIndex = 181;
            chkStopStudy.Text = "Stop Study";
            chkStopStudy.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Navy;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(870, 340);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 47);
            btnUpdate.TabIndex = 174;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Green;
            btnInsert.ForeColor = SystemColors.ButtonHighlight;
            btnInsert.Location = new Point(749, 340);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(108, 47);
            btnInsert.TabIndex = 173;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(840, 181);
            label20.Name = "label20";
            label20.Size = new Size(0, 20);
            label20.TabIndex = 179;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(748, 192);
            label21.Name = "label21";
            label21.Size = new Size(52, 20);
            label21.TabIndex = 178;
            label21.Text = "Status:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(1063, 89);
            label19.Name = "label19";
            label19.Size = new Size(0, 20);
            label19.TabIndex = 175;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(869, 64);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(348, 27);
            txtAddress.TabIndex = 145;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(746, 70);
            label.Name = "label";
            label.Size = new Size(65, 20);
            label.TabIndex = 176;
            label.Text = "Address:";
            // 
            // dgvStudent
            // 
            dgvStudent.BackgroundColor = SystemColors.ActiveBorder;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(6, 425);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(1451, 407);
            dgvStudent.TabIndex = 156;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(281, 149);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 147;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(312, 26);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(348, 27);
            txtStudentID.TabIndex = 136;
            // 
            // dtpEnterDate
            // 
            dtpEnterDate.Location = new Point(869, 106);
            dtpEnterDate.Name = "dtpEnterDate";
            dtpEnterDate.Size = new Size(346, 27);
            dtpEnterDate.TabIndex = 146;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(312, 375);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(348, 27);
            txtSearch.TabIndex = 154;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(312, 350);
            label15.Name = "label15";
            label15.Size = new Size(72, 20);
            label15.TabIndex = 155;
            label15.Text = "Search ID";
            // 
            // StaffID
            // 
            StaffID.AutoSize = true;
            StaffID.Location = new Point(198, 33);
            StaffID.Name = "StaffID";
            StaffID.Size = new Size(82, 20);
            StaffID.TabIndex = 129;
            StaffID.Text = "Student ID:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(312, 189);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(348, 27);
            dtpBirthDate.TabIndex = 140;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(323, 77);
            ID.Name = "ID";
            ID.Size = new Size(0, 20);
            ID.TabIndex = 130;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(746, 110);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 166;
            label7.Text = "Enter Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 77);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 131;
            label1.Text = "NameEN:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(880, 120);
            label16.Name = "label16";
            label16.Size = new Size(0, 20);
            label16.TabIndex = 165;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 154);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 132;
            label2.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 194);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 133;
            label5.Text = "Birth Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 188);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 134;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 115);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 135;
            label3.Text = "Name KH:";
            // 
            // txtNameKH
            // 
            txtNameKH.Location = new Point(312, 109);
            txtNameKH.Name = "txtNameKH";
            txtNameKH.Size = new Size(348, 27);
            txtNameKH.TabIndex = 138;
            // 
            // txtNameEN
            // 
            txtNameEN.Location = new Point(312, 70);
            txtNameEN.Name = "txtNameEN";
            txtNameEN.Size = new Size(348, 27);
            txtNameEN.TabIndex = 137;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(200, 315);
            label14.Name = "label14";
            label14.Size = new Size(98, 20);
            label14.TabIndex = 142;
            label14.Text = "Parent Phone:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(885, 208);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 143;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(200, 276);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 145;
            label11.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(312, 269);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(348, 27);
            txtPhone.TabIndex = 142;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(199, 235);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 148;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(312, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(348, 27);
            txtEmail.TabIndex = 141;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(587, 0);
            label17.Name = "label17";
            label17.Size = new Size(371, 46);
            label17.TabIndex = 0;
            label17.Text = "Student's Information";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Location = new Point(0, 922);
            panel2.Name = "panel2";
            panel2.Size = new Size(1466, 55);
            panel2.TabIndex = 185;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label17);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1464, 55);
            panel1.TabIndex = 184;
            // 
            // Student_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 977);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Student_Form";
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
    }
}