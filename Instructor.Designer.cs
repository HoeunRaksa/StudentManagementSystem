namespace StudentManagementSystem
{
    partial class Instructor
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
            lblInstructorID = new System.Windows.Forms.Label();
            txtInstructorID = new System.Windows.Forms.TextBox();
            lblNameKH = new System.Windows.Forms.Label();
            txtNameKH = new System.Windows.Forms.TextBox();
            lblNameEN = new System.Windows.Forms.Label();
            txtNameEN = new System.Windows.Forms.TextBox();
            lblGender = new System.Windows.Forms.Label();
            txtGender = new System.Windows.Forms.TextBox();
            lblBirthDate = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblPhone = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            lblDepartment = new System.Windows.Forms.Label();
            txtDepartment = new System.Windows.Forms.TextBox();
            lblDegree = new System.Windows.Forms.Label();
            txtDegree = new System.Windows.Forms.TextBox();
            lblStatus = new System.Windows.Forms.Label();
            chkStatus = new System.Windows.Forms.CheckBox();
            btnInsert = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnSearch = new System.Windows.Forms.Button();
            dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInstructorID
            // 
            lblInstructorID.Location = new System.Drawing.Point(83, 143);
            lblInstructorID.Name = "lblInstructorID";
            lblInstructorID.Size = new System.Drawing.Size(108, 23);
            lblInstructorID.TabIndex = 0;
            lblInstructorID.Text = "InstructorID:";
            // 
            // txtInstructorID
            // 
            txtInstructorID.Location = new System.Drawing.Point(197, 140);
            txtInstructorID.Name = "txtInstructorID";
            txtInstructorID.Size = new System.Drawing.Size(210, 27);
            txtInstructorID.TabIndex = 1;
            // 
            // lblNameKH
            // 
            lblNameKH.Location = new System.Drawing.Point(435, 142);
            lblNameKH.Name = "lblNameKH";
            lblNameKH.Size = new System.Drawing.Size(145, 23);
            lblNameKH.TabIndex = 2;
            lblNameKH.Text = "InstructorNameKH:";
            // 
            // txtNameKH
            // 
            txtNameKH.Location = new System.Drawing.Point(586, 139);
            txtNameKH.Name = "txtNameKH";
            txtNameKH.Size = new System.Drawing.Size(210, 27);
            txtNameKH.TabIndex = 3;
            // 
            // lblNameEN
            // 
            lblNameEN.Location = new System.Drawing.Point(896, 141);
            lblNameEN.Name = "lblNameEN";
            lblNameEN.Size = new System.Drawing.Size(146, 23);
            lblNameEN.TabIndex = 4;
            lblNameEN.Text = "InstructorNameEN:";
            // 
            // txtNameEN
            // 
            txtNameEN.Location = new System.Drawing.Point(1042, 138);
            txtNameEN.Name = "txtNameEN";
            txtNameEN.Size = new System.Drawing.Size(210, 27);
            txtNameEN.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.Location = new System.Drawing.Point(91, 189);
            lblGender.Name = "lblGender";
            lblGender.Size = new System.Drawing.Size(100, 23);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender:";
            // 
            // txtGender
            // 
            txtGender.Location = new System.Drawing.Point(197, 189);
            txtGender.Name = "txtGender";
            txtGender.Size = new System.Drawing.Size(210, 27);
            txtGender.TabIndex = 7;
            // 
            // lblBirthDate
            // 
            lblBirthDate.Location = new System.Drawing.Point(497, 189);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new System.Drawing.Size(83, 23);
            lblBirthDate.TabIndex = 8;
            lblBirthDate.Text = "BirthDate:";
            // 
            // lblAddress
            // 
            lblAddress.Location = new System.Drawing.Point(965, 189);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(77, 23);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address";
            lblAddress.Click += lblAddress_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(1042, 185);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(210, 27);
            txtAddress.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.Location = new System.Drawing.Point(91, 238);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(100, 23);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(197, 234);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(210, 27);
            txtEmail.TabIndex = 13;
            // 
            // lblPhone
            // 
            lblPhone.Location = new System.Drawing.Point(506, 234);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(74, 23);
            lblPhone.TabIndex = 14;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(586, 234);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(210, 27);
            txtPhone.TabIndex = 15;
            // 
            // lblDepartment
            // 
            lblDepartment.Location = new System.Drawing.Point(971, 234);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new System.Drawing.Size(65, 23);
            lblDepartment.TabIndex = 16;
            lblDepartment.Text = "Title";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new System.Drawing.Point(1042, 234);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new System.Drawing.Size(210, 27);
            txtDepartment.TabIndex = 17;
            // 
            // lblDegree
            // 
            lblDegree.Location = new System.Drawing.Point(91, 282);
            lblDegree.Name = "lblDegree";
            lblDegree.Size = new System.Drawing.Size(100, 23);
            lblDegree.TabIndex = 18;
            lblDegree.Text = "office";
            lblDegree.Click += lblDegree_Click;
            // 
            // txtDegree
            // 
            txtDegree.Location = new System.Drawing.Point(197, 282);
            txtDegree.Name = "txtDegree";
            txtDegree.Size = new System.Drawing.Size(210, 27);
            txtDegree.TabIndex = 19;
            // 
            // lblStatus
            // 
            lblStatus.Location = new System.Drawing.Point(506, 282);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(69, 23);
            lblStatus.TabIndex = 22;
            lblStatus.Text = "Status:";
            // 
            // chkStatus
            // 
            chkStatus.Location = new System.Drawing.Point(600, 281);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new System.Drawing.Size(104, 24);
            chkStatus.TabIndex = 23;
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(731, 375);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(119, 33);
            btnInsert.TabIndex = 24;
            btnInsert.Text = "Insert";
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(918, 375);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(124, 33);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(1150, 375);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(131, 33);
            btnNew.TabIndex = 26;
            btnNew.Text = "New";
            btnNew.Click += btnNew_Click_1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(20, 381);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new System.Drawing.Size(491, 27);
            txtSearch.TabIndex = 27;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(20, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(1261, 258);
            dataGridView1.TabIndex = 30;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(537, 375);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(124, 33);
            btnSearch.TabIndex = 32;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new System.Drawing.Point(586, 189);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new System.Drawing.Size(210, 27);
            dateTimePickerBirthDate.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DarkOrange;
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1325, 70);
            panel1.TabIndex = 34;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(552, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(204, 35);
            label1.TabIndex = 35;
            label1.Text = "Instructor Form\r\n";
            // 
            // Form1
            // 
            ClientSize = new System.Drawing.Size(1326, 701);
            Controls.Add(panel1);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(lblInstructorID);
            Controls.Add(txtInstructorID);
            Controls.Add(lblNameKH);
            Controls.Add(txtNameKH);
            Controls.Add(lblNameEN);
            Controls.Add(txtNameEN);
            Controls.Add(lblGender);
            Controls.Add(txtGender);
            Controls.Add(lblBirthDate);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblDepartment);
            Controls.Add(txtDepartment);
            Controls.Add(lblDegree);
            Controls.Add(txtDegree);
            Controls.Add(lblStatus);
            Controls.Add(chkStatus);
            Controls.Add(btnInsert);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(txtSearch);
            Text = "Instructor management form";
            Load += InstructorForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        // Add the missing method definition for InstructorForm_Load_1 to resolve the CS0103 error.  
        private void InstructorForm_Load_1(object sender, EventArgs e)
        {
            // Add any initialization logic here if needed.  
        }


        #endregion

        private System.Windows.Forms.Label lblInstructorID;
        private System.Windows.Forms.TextBox txtInstructorID;
        private System.Windows.Forms.Label lblNameKH;
        private System.Windows.Forms.TextBox txtNameKH;
        private System.Windows.Forms.Label lblNameEN;
        private System.Windows.Forms.TextBox txtNameEN;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;

    }

}