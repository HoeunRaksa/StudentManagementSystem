namespace StudentManagementSystem
{
    partial class Subjectcs
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            comboDepartmentID = new ComboBox();
            comboDepartmentName = new ComboBox();
            txtsubject = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.Location = new Point(151, 233);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 36;
            label3.Text = "Subject Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(151, 297);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 37;
            label1.Text = "Department ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(151, 364);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 38;
            label2.Text = "Department Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label5);
            panel1.ForeColor = Color.DarkOrange;
            panel1.Location = new Point(3, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1470, 84);
            panel1.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Pixel);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(633, 31);
            label5.Name = "label5";
            label5.Size = new Size(86, 30);
            label5.TabIndex = 0;
            label5.Text = "Subject";
            // 
            // comboDepartmentID
            // 
            comboDepartmentID.FormattingEnabled = true;
            comboDepartmentID.Location = new Point(326, 289);
            comboDepartmentID.Name = "comboDepartmentID";
            comboDepartmentID.Size = new Size(223, 28);
            comboDepartmentID.TabIndex = 42;
            // 
            // comboDepartmentName
            // 
            comboDepartmentName.FormattingEnabled = true;
            comboDepartmentName.Location = new Point(326, 360);
            comboDepartmentName.Name = "comboDepartmentName";
            comboDepartmentName.Size = new Size(223, 28);
            comboDepartmentName.TabIndex = 43;
            // 
            // txtsubject
            // 
            txtsubject.Location = new Point(326, 233);
            txtsubject.Name = "txtsubject";
            txtsubject.Size = new Size(223, 27);
            txtsubject.TabIndex = 44;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(151, 467);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 48);
            btnInsert.TabIndex = 45;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(299, 467);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 48);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(470, 467);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 48);
            btnRefresh.TabIndex = 47;
            btnRefresh.Text = "refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(724, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(563, 453);
            dataGridView1.TabIndex = 48;
            // 
            // Subjectcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 977);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtsubject);
            Controls.Add(comboDepartmentName);
            Controls.Add(comboDepartmentID);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Subjectcs";
            Text = "Subjectcs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private ComboBox comboDepartmentID;
        private ComboBox comboDepartmentName;
        private TextBox txtsubject;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnRefresh;
        private DataGridView dataGridView1;
    }
}