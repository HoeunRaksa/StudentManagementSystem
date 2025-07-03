

namespace StudentManagementSystem
{
    partial class Department
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            dataGridView1 = new DataGridView();
            btnNew = new Button();
            btnInsert = new Button();
            txtStudyPrice = new TextBox();
            txtDepartmentLocation = new TextBox();
            txtDepartmentName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnUpdate = new Button();
            txtHeadDepartment = new TextBox();
            txtCollegeName = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 63);
            panel1.TabIndex = 103;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.cross;
            pictureBox1.Location = new Point(1228, 19);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 13F);
            btnLogout.Location = new Point(1096, 347);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(125, 34);
            btnLogout.TabIndex = 122;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(79, 386);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1143, 332);
            dataGridView1.TabIndex = 121;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 13F);
            btnNew.Location = new Point(650, 347);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(117, 34);
            btnNew.TabIndex = 105;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 13F);
            btnInsert.Location = new Point(416, 347);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(115, 34);
            btnInsert.TabIndex = 104;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtStudyPrice
            // 
            txtStudyPrice.Font = new Font("Segoe UI", 10F);
            txtStudyPrice.Location = new Point(810, 155);
            txtStudyPrice.Margin = new Padding(3, 2, 3, 2);
            txtStudyPrice.Name = "txtStudyPrice";
            txtStudyPrice.Size = new Size(395, 25);
            txtStudyPrice.TabIndex = 119;
            // 
            // txtDepartmentLocation
            // 
            txtDepartmentLocation.Font = new Font("Segoe UI", 10F);
            txtDepartmentLocation.Location = new Point(810, 107);
            txtDepartmentLocation.Margin = new Padding(3, 2, 3, 2);
            txtDepartmentLocation.Name = "txtDepartmentLocation";
            txtDepartmentLocation.Size = new Size(395, 25);
            txtDepartmentLocation.TabIndex = 118;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Font = new Font("Segoe UI", 10F);
            txtDepartmentName.Location = new Point(255, 107);
            txtDepartmentName.Margin = new Padding(3, 2, 3, 2);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(316, 25);
            txtDepartmentName.TabIndex = 117;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(629, 285);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 113;
            label8.Text = "Search :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(597, 153);
            label7.Name = "label7";
            label7.Size = new Size(108, 25);
            label7.TabIndex = 112;
            label7.Text = "Study Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(597, 107);
            label6.Name = "label6";
            label6.Size = new Size(188, 25);
            label6.TabIndex = 111;
            label6.Text = "Department Location :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(62, 200);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 110;
            label5.Text = "College Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(62, 151);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 109;
            label4.Text = "Head Department :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(62, 105);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 108;
            label2.Text = "Department Name :";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 13F);
            btnUpdate.Location = new Point(872, 347);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 34);
            btnUpdate.TabIndex = 106;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtHeadDepartment
            // 
            txtHeadDepartment.Font = new Font("Segoe UI", 10F);
            txtHeadDepartment.Location = new Point(255, 153);
            txtHeadDepartment.Margin = new Padding(3, 2, 3, 2);
            txtHeadDepartment.Name = "txtHeadDepartment";
            txtHeadDepartment.Size = new Size(316, 25);
            txtHeadDepartment.TabIndex = 123;
            // 
            // txtCollegeName
            // 
            txtCollegeName.Font = new Font("Segoe UI", 10F);
            txtCollegeName.Location = new Point(255, 200);
            txtCollegeName.Margin = new Padding(3, 2, 3, 2);
            txtCollegeName.Name = "txtCollegeName";
            txtCollegeName.Size = new Size(316, 25);
            txtCollegeName.TabIndex = 124;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(719, 280);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(421, 29);
            txtSearch.TabIndex = 125;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11F);
            btnSearch.Location = new Point(1145, 280);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(76, 28);
            btnSearch.TabIndex = 126;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 733);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtCollegeName);
            Controls.Add(txtHeadDepartment);
            Controls.Add(btnLogout);
            Controls.Add(dataGridView1);
            Controls.Add(btnNew);
            Controls.Add(btnInsert);
            Controls.Add(txtStudyPrice);
            Controls.Add(txtDepartmentLocation);
            Controls.Add(txtDepartmentName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Department";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department Management";
            Load += Department_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private DataGridView dataGridView1;
        private Button btnNew;
        private Button btnInsert;
        private TextBox txtStudyPrice;
        private TextBox txtDepartmentLocation;
        private TextBox txtDepartmentName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button btnUpdate;
        private TextBox txtHeadDepartment;
        private TextBox txtCollegeName;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}