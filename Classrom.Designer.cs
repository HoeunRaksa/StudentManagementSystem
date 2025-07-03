using System.ComponentModel;

namespace StudentManagementSystem;
partial class Classroom
{
    /// <summary>
    /// Required designer variable.``
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
        label3 = new Label();
        label5 = new Label();
        label6 = new Label();
        txtRoomlocation = new TextBox();
        label7 = new Label();
        chkFree = new CheckBox();
        dataGridView1 = new DataGridView();
        btnInsert = new Button();
        btnUpdate = new Button();
        btnNew = new Button();
        btnLogout = new Button();
        label4 = new Label();
        comboBox1 = new ComboBox();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        textBox4 = new TextBox();
        label8 = new Label();
        textBox5 = new TextBox();
        label9 = new Label();
        comboBox2 = new ComboBox();
        panel1 = new Panel();
        label10 = new Label();
        txtSearch = new TextBox();
        label11 = new Label();
        ((ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new Point(50, 67);
        label1.Name = "label1";
        label1.Size = new Size(88, 17);
        label1.TabIndex = 0;
        label1.Text = "Classroom ID";
        // 
        // label2
        // 
        label2.Location = new Point(32, 103);
        label2.Name = "label2";
        label2.Size = new Size(121, 17);
        label2.TabIndex = 1;
        label2.Text = "Classroom Name";
        // 
        // label3
        // 
        label3.Location = new Point(24, 154);
        label3.Name = "label3";
        label3.Size = new Size(105, 17);
        label3.TabIndex = 2;
        label3.Text = "Building Name";
        // 
        // label5
        // 
        label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(556, 63);
        label5.Name = "label5";
        label5.Size = new Size(173, 35);
        label5.TabIndex = 8;
        label5.Text = "Room Location";
        // 
        // label6
        // 
        label6.Location = new Point(565, 154);
        label6.Name = "label6";
        label6.Size = new Size(108, 17);
        label6.TabIndex = 9;
        label6.Text = "Capacity";
        // 
        // txtRoomlocation
        // 
        txtRoomlocation.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtRoomlocation.Location = new Point(678, 56);
        txtRoomlocation.Margin = new Padding(3, 2, 3, 2);
        txtRoomlocation.Name = "txtRoomlocation";
        txtRoomlocation.Size = new Size(322, 32);
        txtRoomlocation.TabIndex = 10;
        // 
        // label7
        // 
        label7.Location = new Point(72, 189);
        label7.Name = "label7";
        label7.Size = new Size(66, 17);
        label7.TabIndex = 12;
        label7.Text = "Status";
        label7.Click += label7_Click;
        // 
        // chkFree
        // 
        chkFree.Location = new Point(155, 188);
        chkFree.Margin = new Padding(3, 2, 3, 2);
        chkFree.Name = "chkFree";
        chkFree.Size = new Size(91, 18);
        chkFree.TabIndex = 13;
        chkFree.Text = "Free\r\n";
        chkFree.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Location = new Point(60, 370);
        dataGridView1.Margin = new Padding(3, 2, 3, 2);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(923, 163);
        dataGridView1.TabIndex = 16;
        // 
        // btnInsert
        // 
        btnInsert.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnInsert.Location = new Point(155, 311);
        btnInsert.Margin = new Padding(3, 2, 3, 2);
        btnInsert.Name = "btnInsert";
        btnInsert.Size = new Size(117, 37);
        btnInsert.TabIndex = 17;
        btnInsert.Text = "Insert";
        btnInsert.UseVisualStyleBackColor = true;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(336, 311);
        btnUpdate.Margin = new Padding(3, 2, 3, 2);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(112, 37);
        btnUpdate.TabIndex = 18;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // btnNew
        // 
        btnNew.Location = new Point(508, 311);
        btnNew.Margin = new Padding(3, 2, 3, 2);
        btnNew.Name = "btnNew";
        btnNew.Size = new Size(119, 37);
        btnNew.TabIndex = 19;
        btnNew.Text = "New";
        btnNew.UseVisualStyleBackColor = true;
        // 
        // btnLogout
        // 
        btnLogout.Location = new Point(687, 311);
        btnLogout.Margin = new Padding(3, 2, 3, 2);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(115, 37);
        btnLogout.TabIndex = 20;
        btnLogout.Text = "logout";
        btnLogout.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(521, 108);
        label4.Name = "label4";
        label4.Size = new Size(141, 17);
        label4.TabIndex = 21;
        label4.Text = "Department Name";
        // 
        // comboBox1
        // 
        comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(678, 100);
        comboBox1.Margin = new Padding(3, 2, 3, 2);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(322, 33);
        comboBox1.TabIndex = 22;
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(678, 145);
        textBox1.Margin = new Padding(3, 2, 3, 2);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(322, 32);
        textBox1.TabIndex = 23;
        // 
        // textBox2
        // 
        textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox2.Location = new Point(155, 58);
        textBox2.Margin = new Padding(3, 2, 3, 2);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(322, 32);
        textBox2.TabIndex = 24;
        // 
        // textBox3
        // 
        textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox3.Location = new Point(155, 101);
        textBox3.Margin = new Padding(3, 2, 3, 2);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(322, 32);
        textBox3.TabIndex = 25;
        // 
        // textBox4
        // 
        textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox4.Location = new Point(155, 145);
        textBox4.Margin = new Padding(3, 2, 3, 2);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(322, 32);
        textBox4.TabIndex = 26;
        // 
        // label8
        // 
        label8.Location = new Point(574, 197);
        label8.Name = "label8";
        label8.Size = new Size(108, 17);
        label8.TabIndex = 27;
        label8.Text = "Generation";
        // 
        // textBox5
        // 
        textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox5.Location = new Point(678, 188);
        textBox5.Margin = new Padding(3, 2, 3, 2);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(322, 32);
        textBox5.TabIndex = 28;
        // 
        // label9
        // 
        label9.Location = new Point(72, 220);
        label9.Name = "label9";
        label9.Size = new Size(66, 17);
        label9.TabIndex = 29;
        label9.Text = "Shift";
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(155, 220);
        comboBox2.Margin = new Padding(3, 2, 3, 2);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(106, 23);
        comboBox2.TabIndex = 30;
        // 
        // panel1
        // 
        panel1.BackColor = Color.DarkOrange;
        panel1.BorderStyle = BorderStyle.Fixed3D;
        panel1.Controls.Add(label10);
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(3, 2, 3, 2);
        panel1.Name = "panel1";
        panel1.Size = new Size(1142, 38);
        panel1.TabIndex = 31;
        // 
        // label10
        // 
        label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label10.Location = new Point(429, 4);
        label10.Name = "label10";
        label10.Size = new Size(197, 30);
        label10.TabIndex = 32;
        label10.Text = "Classrom Form";
        label10.Click += label10_Click;
        // 
        // txtSearch
        // 
        txtSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtSearch.Location = new Point(143, 262);
        txtSearch.Margin = new Padding(3, 2, 3, 2);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(332, 32);
        txtSearch.TabIndex = 32;
        // 
        // label11
        // 
        label11.Location = new Point(72, 271);
        label11.Name = "label11";
        label11.Size = new Size(66, 17);
        label11.TabIndex = 33;
        label11.Text = "Search :";
        // 
        // Classroom
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1123, 550);
        Controls.Add(label11);
        Controls.Add(txtSearch);
        Controls.Add(panel1);
        Controls.Add(comboBox2);
        Controls.Add(label9);
        Controls.Add(textBox5);
        Controls.Add(label8);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(comboBox1);
        Controls.Add(label4);
        Controls.Add(btnLogout);
        Controls.Add(btnNew);
        Controls.Add(btnUpdate);
        Controls.Add(btnInsert);
        Controls.Add(dataGridView1);
        Controls.Add(chkFree);
        Controls.Add(label7);
        Controls.Add(txtRoomlocation);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Location = new Point(19, 19);
        Margin = new Padding(3, 2, 3, 2);
        Name = "Classroom";
        StartPosition = FormStartPosition.CenterScreen;
        ((ISupportInitialize)dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.TextBox txtSearch;

    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.ComboBox comboBox2;

    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBox5;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnNew;
    private System.Windows.Forms.Button btnLogout;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtRoomlocation;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.CheckBox chkFree;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    #endregion
}