
namespace StudentManagementSystem
{
    partial class Payment
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
            btnNew = new Button();
            btnUpdate = new Button();
            btnLogout = new Button();
            btnInsert = new Button();
            dataGridView1 = new DataGridView();
            lblSearchName = new Label();
            DateTimePicker1 = new DateTimePicker();
            cmbStudentID = new ComboBox();
            cmbStaffID = new ComboBox();
            txtAmount = new TextBox();
            txtPaymentID = new TextBox();
            lblStatus = new Label();
            lblPaymentType = new Label();
            lblPaymentDate = new Label();
            lblAmount = new Label();
            lblStudentID = new Label();
            lblStaffID = new Label();
            lblPaymentID = new Label();
            txtPaymentType = new ComboBox();
            txtStatus = new ComboBox();
            cmbSearchStudentID = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Location = new Point(779, 705);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(162, 48);
            btnNew.TabIndex = 42;
            btnNew.Text = "Clear";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1011, 705);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 48);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1264, 705);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(162, 48);
            btnLogout.TabIndex = 40;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(540, 705);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(162, 48);
            btnInsert.TabIndex = 39;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(497, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(929, 408);
            dataGridView1.TabIndex = 38;
            // 
            // lblSearchName
            // 
            lblSearchName.AutoSize = true;
            lblSearchName.Location = new Point(769, 161);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new Size(157, 21);
            lblSearchName.TabIndex = 36;
            lblSearchName.Text = "Search By StudentID: ";
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Location = new Point(138, 475);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(340, 29);
            DateTimePicker1.TabIndex = 35;
            // 
            // cmbStudentID
            // 
            cmbStudentID.FormattingEnabled = true;
            cmbStudentID.Location = new Point(138, 338);
            cmbStudentID.Name = "cmbStudentID";
            cmbStudentID.Size = new Size(340, 29);
            cmbStudentID.TabIndex = 34;
            // 
            // cmbStaffID
            // 
            cmbStaffID.FormattingEnabled = true;
            cmbStaffID.Location = new Point(138, 257);
            cmbStaffID.Name = "cmbStaffID";
            cmbStaffID.Size = new Size(340, 29);
            cmbStaffID.TabIndex = 33;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(138, 404);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(340, 29);
            txtAmount.TabIndex = 31;
            // 
            // txtPaymentID
            // 
            txtPaymentID.Location = new Point(497, 216);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.Size = new Size(221, 29);
            txtPaymentID.TabIndex = 29;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 627);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(55, 21);
            lblStatus.TabIndex = 28;
            lblStatus.Text = "Status:";
            // 
            // lblPaymentType
            // 
            lblPaymentType.AutoSize = true;
            lblPaymentType.Location = new Point(3, 556);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(109, 21);
            lblPaymentType.TabIndex = 27;
            lblPaymentType.Text = "Payment Type:";
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Location = new Point(3, 477);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(109, 21);
            lblPaymentDate.TabIndex = 26;
            lblPaymentDate.Text = "Payment Date:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(3, 404);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(69, 21);
            lblAmount.TabIndex = 25;
            lblAmount.Text = "Amount:";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(3, 339);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(85, 21);
            lblStudentID.TabIndex = 24;
            lblStudentID.Text = "Student ID:";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Location = new Point(3, 262);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(63, 21);
            lblStaffID.TabIndex = 23;
            lblStaffID.Text = "Staff ID:";
            // 
            // lblPaymentID
            // 
            lblPaymentID.AutoSize = true;
            lblPaymentID.Location = new Point(497, 161);
            lblPaymentID.Name = "lblPaymentID";
            lblPaymentID.Size = new Size(170, 21);
            lblPaymentID.TabIndex = 22;
            lblPaymentID.Text = "Payment ID for Update:";
            // 
            // txtPaymentType
            // 
            txtPaymentType.FormattingEnabled = true;
            txtPaymentType.Location = new Point(138, 546);
            txtPaymentType.Name = "txtPaymentType";
            txtPaymentType.Size = new Size(340, 29);
            txtPaymentType.TabIndex = 43;
            // 
            // txtStatus
            // 
            txtStatus.FormattingEnabled = true;
            txtStatus.Location = new Point(138, 629);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(340, 29);
            txtStatus.TabIndex = 44;
            // 
            // cmbSearchStudentID
            // 
            cmbSearchStudentID.FormattingEnabled = true;
            cmbSearchStudentID.Location = new Point(769, 214);
            cmbSearchStudentID.Name = "cmbSearchStudentID";
            cmbSearchStudentID.Size = new Size(236, 29);
            cmbSearchStudentID.TabIndex = 45;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 8);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1470, 84);
            panel1.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(667, 26);
            label1.Name = "label1";
            label1.Size = new Size(117, 35);
            label1.TabIndex = 47;
            label1.Text = "Payment";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.cross;
            pictureBox1.Location = new Point(1405, 26);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 977);
            Controls.Add(panel1);
            Controls.Add(txtStatus);
            Controls.Add(cmbSearchStudentID);
            Controls.Add(txtPaymentType);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnLogout);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            Controls.Add(lblSearchName);
            Controls.Add(DateTimePicker1);
            Controls.Add(cmbStudentID);
            Controls.Add(cmbStaffID);
            Controls.Add(txtAmount);
            Controls.Add(txtPaymentID);
            Controls.Add(lblStatus);
            Controls.Add(lblPaymentType);
            Controls.Add(lblPaymentDate);
            Controls.Add(lblAmount);
            Controls.Add(lblStudentID);
            Controls.Add(lblStaffID);
            Controls.Add(lblPaymentID);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private Button btnUpdate;
        private Button btnLogout;
        private Button btnInsert;
        private DataGridView dataGridView1;
        private Label lblSearchName;
        private DateTimePicker DateTimePicker1;
        private ComboBox cmbStudentID;
        private ComboBox cmbStaffID;
        private TextBox txtAmount;
        private TextBox txtPaymentID;
        private Label lblStatus;
        private Label lblPaymentType;
        private Label lblPaymentDate;
        private Label lblAmount;
        private Label lblStudentID;
        private Label lblStaffID;
        private Label lblPaymentID;
        private ComboBox txtPaymentType;
        private ComboBox txtStatus;
        private ComboBox cmbSearchStudentID;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}