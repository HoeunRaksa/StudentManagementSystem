

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
            panel1.Name = "panel1";
            panel1.Size = new Size(1464, 84);
            panel1.TabIndex = 103;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.cross;
            pictureBox1.Location = new Point(1403, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 13F);
            btnLogout.Location = new Point(1253, 463);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(143, 45);
            btnLogout.TabIndex = 122;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(90, 514);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1306, 443);
            dataGridView1.TabIndex = 121;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 13F);
            btnNew.Location = new Point(743, 463);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(134, 45);
            btnNew.TabIndex = 105;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 13F);
            btnInsert.Location = new Point(475, 463);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(131, 45);
            btnInsert.TabIndex = 104;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtStudyPrice
            // 
            txtStudyPrice.Font = new Font("Segoe UI", 10F);
            txtStudyPrice.Location = new Point(926, 207);
            txtStudyPrice.Name = "txtStudyPrice";
            txtStudyPrice.Size = new Size(451, 30);
            txtStudyPrice.TabIndex = 119;
            // 
            // txtDepartmentLocation
            // 
            txtDepartmentLocation.Font = new Font("Segoe UI", 10F);
            txtDepartmentLocation.Location = new Point(926, 143);
            txtDepartmentLocation.Name = "txtDepartmentLocation";
            txtDepartmentLocation.Size = new Size(451, 30);
            txtDepartmentLocation.TabIndex = 118;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Font = new Font("Segoe UI", 10F);
            txtDepartmentName.Location = new Point(291, 143);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(361, 30);
            txtDepartmentName.TabIndex = 117;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(719, 380);
            label8.Name = "label8";
            label8.Size = new Size(97, 32);
            label8.TabIndex = 113;
            label8.Text = "Search :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(682, 204);
            label7.Name = "label7";
            label7.Size = new Size(131, 30);
            label7.TabIndex = 112;
            label7.Text = "Study Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(682, 143);
            label6.Name = "label6";
            label6.Size = new Size(227, 30);
            label6.TabIndex = 111;
            label6.Text = "Department Location :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(71, 267);
            label5.Name = "label5";
            label5.Size = new Size(162, 30);
            label5.TabIndex = 110;
            label5.Text = "College Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(71, 201);
            label4.Name = "label4";
            label4.Size = new Size(198, 30);
            label4.TabIndex = 109;
            label4.Text = "Head Department :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(71, 140);
            label2.Name = "label2";
            label2.Size = new Size(204, 30);
            label2.TabIndex = 108;
            label2.Text = "Department Name :";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 13F);
            btnUpdate.Location = new Point(997, 463);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 45);
            btnUpdate.TabIndex = 106;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtHeadDepartment
            // 
            txtHeadDepartment.Font = new Font("Segoe UI", 10F);
            txtHeadDepartment.Location = new Point(291, 204);
            txtHeadDepartment.Name = "txtHeadDepartment";
            txtHeadDepartment.Size = new Size(361, 30);
            txtHeadDepartment.TabIndex = 123;
            // 
            // txtCollegeName
            // 
            txtCollegeName.Font = new Font("Segoe UI", 10F);
            txtCollegeName.Location = new Point(291, 267);
            txtCollegeName.Name = "txtCollegeName";
            txtCollegeName.Size = new Size(361, 30);
            txtCollegeName.TabIndex = 124;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(822, 374);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(481, 37);
            txtSearch.TabIndex = 125;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11F);
            btnSearch.Location = new Point(1309, 374);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 38);
            btnSearch.TabIndex = 126;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click; // Add this line
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 977);
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
            Name = "Department";
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