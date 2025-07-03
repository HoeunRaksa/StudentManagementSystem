using System.ComponentModel;

namespace StudentManagementSystem;

partial class Analyst
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        label3 = new Label();
        dateTimePicker1 = new DateTimePicker();
        label4 = new Label();
        comboBox1 = new ComboBox();
        label5 = new Label();
        comboBox2 = new ComboBox();
        label7 = new Label();
        comboBox4 = new ComboBox();
        dataGridView1 = new DataGridView();
        btnInsert = new Button();
        btnUpdate = new Button();
        btnNew = new Button();
        btnLogout = new Button();
        label6 = new Label();
        comboBox3 = new ComboBox();
        panel1 = new Panel();
        label8 = new Label();
        ((ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new Point(78, 81);
        label1.Name = "label1";
        label1.Size = new Size(88, 17);
        label1.TabIndex = 0;
        label1.Text = "AnalystID";
        // 
        // label2
        // 
        label2.Location = new Point(68, 122);
        label2.Name = "label2";
        label2.Size = new Size(116, 17);
        label2.TabIndex = 1;
        label2.Text = "AnalystReport";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(171, 72);
        textBox1.Margin = new Padding(3, 2, 3, 2);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(262, 32);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox2.Location = new Point(171, 119);
        textBox2.Margin = new Padding(3, 2, 3, 2);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(262, 32);
        textBox2.TabIndex = 3;
        // 
        // label3
        // 
        label3.Location = new Point(68, 176);
        label3.Name = "label3";
        label3.Size = new Size(116, 17);
        label3.TabIndex = 4;
        label3.Text = "Date";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dateTimePicker1.Location = new Point(171, 170);
        dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(336, 26);
        dateTimePicker1.TabIndex = 5;
        // 
        // label4
        // 
        label4.Location = new Point(638, 110);
        label4.Name = "label4";
        label4.Size = new Size(88, 17);
        label4.TabIndex = 6;
        label4.Text = "StaffKH";
        // 
        // comboBox1
        // 
        comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(711, 98);
        comboBox1.Margin = new Padding(3, 2, 3, 2);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(257, 33);
        comboBox1.TabIndex = 7;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // label5
        // 
        label5.Location = new Point(646, 150);
        label5.Name = "label5";
        label5.Size = new Size(88, 17);
        label5.TabIndex = 8;
        label5.Text = "Role";
        // 
        // comboBox2
        // 
        comboBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(711, 141);
        comboBox2.Margin = new Padding(3, 2, 3, 2);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(257, 33);
        comboBox2.TabIndex = 9;
        // 
        // label7
        // 
        label7.Location = new Point(584, 193);
        label7.Name = "label7";
        label7.Size = new Size(122, 22);
        label7.TabIndex = 12;
        label7.Text = "Department Name";
        // 
        // comboBox4
        // 
        comboBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox4.FormattingEnabled = true;
        comboBox4.Location = new Point(711, 185);
        comboBox4.Margin = new Padding(3, 2, 3, 2);
        comboBox4.Name = "comboBox4";
        comboBox4.Size = new Size(257, 33);
        comboBox4.TabIndex = 13;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Location = new Point(135, 309);
        dataGridView1.Margin = new Padding(3, 2, 3, 2);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(704, 221);
        dataGridView1.TabIndex = 14;
        // 
        // btnInsert
        // 
        btnInsert.Location = new Point(135, 253);
        btnInsert.Margin = new Padding(3, 2, 3, 2);
        btnInsert.Name = "btnInsert";
        btnInsert.Size = new Size(105, 32);
        btnInsert.TabIndex = 15;
        btnInsert.Text = "Insert";
        btnInsert.UseVisualStyleBackColor = true;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(279, 253);
        btnUpdate.Margin = new Padding(3, 2, 3, 2);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(108, 32);
        btnUpdate.TabIndex = 16;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // btnNew
        // 
        btnNew.Location = new Point(459, 253);
        btnNew.Margin = new Padding(3, 2, 3, 2);
        btnNew.Name = "btnNew";
        btnNew.Size = new Size(108, 32);
        btnNew.TabIndex = 17;
        btnNew.Text = "New";
        btnNew.UseVisualStyleBackColor = true;
        // 
        // btnLogout
        // 
        btnLogout.Location = new Point(672, 253);
        btnLogout.Margin = new Padding(3, 2, 3, 2);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(114, 32);
        btnLogout.TabIndex = 18;
        btnLogout.Text = "Logout";
        btnLogout.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        label6.Location = new Point(638, 66);
        label6.Name = "label6";
        label6.Size = new Size(88, 17);
        label6.TabIndex = 19;
        label6.Text = "StaffEN";
        // 
        // comboBox3
        // 
        comboBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox3.FormattingEnabled = true;
        comboBox3.Location = new Point(711, 57);
        comboBox3.Margin = new Padding(3, 2, 3, 2);
        comboBox3.Name = "comboBox3";
        comboBox3.Size = new Size(257, 33);
        comboBox3.TabIndex = 20;
        // 
        // panel1
        // 
        panel1.BackColor = Color.DarkOrange;
        panel1.Controls.Add(label8);
        panel1.Location = new Point(0, -2);
        panel1.Margin = new Padding(3, 2, 3, 2);
        panel1.Name = "panel1";
        panel1.Size = new Size(1131, 51);
        panel1.TabIndex = 21;
        // 
        // label8
        // 
        label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label8.Location = new Point(459, 17);
        label8.Name = "label8";
        label8.RightToLeft = RightToLeft.Yes;
        label8.Size = new Size(150, 26);
        label8.TabIndex = 22;
        label8.Text = "AnalystForm";
        // 
        // Analyst
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1123, 550);
        Controls.Add(panel1);
        Controls.Add(comboBox3);
        Controls.Add(label6);
        Controls.Add(btnLogout);
        Controls.Add(btnNew);
        Controls.Add(btnUpdate);
        Controls.Add(btnInsert);
        Controls.Add(dataGridView1);
        Controls.Add(comboBox4);
        Controls.Add(label7);
        Controls.Add(comboBox2);
        Controls.Add(label5);
        Controls.Add(comboBox1);
        Controls.Add(label4);
        Controls.Add(dateTimePicker1);
        Controls.Add(label3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Margin = new Padding(3, 2, 3, 2);
        Name = "Analyst";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Analyst";
        ((ISupportInitialize)dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.ComboBox comboBox3;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnNew;
    private System.Windows.Forms.Button btnLogout;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox comboBox4;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox comboBox2;

    #endregion
}