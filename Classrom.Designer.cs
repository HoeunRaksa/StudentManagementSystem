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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        txtRoomlocation = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        chkFree = new System.Windows.Forms.CheckBox();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        btnInsert = new System.Windows.Forms.Button();
        btnUpdate = new System.Windows.Forms.Button();
        btnNew = new System.Windows.Forms.Button();
        btnLogout = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        textBox4 = new System.Windows.Forms.TextBox();
        label8 = new System.Windows.Forms.Label();
        textBox5 = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        comboBox2 = new System.Windows.Forms.ComboBox();
        panel1 = new System.Windows.Forms.Panel();
        label10 = new System.Windows.Forms.Label();
        txtSearch = new System.Windows.Forms.TextBox();
        label11 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(57, 89);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 0;
        label1.Text = "Classroom ID";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(36, 137);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(138, 23);
        label2.TabIndex = 1;
        label2.Text = "Classroom Name";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(27, 205);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(120, 23);
        label3.TabIndex = 2;
        label3.Text = "Building Name";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(636, 84);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(198, 47);
        label5.TabIndex = 8;
        label5.Text = "Room Location";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(646, 205);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(123, 23);
        label6.TabIndex = 9;
        label6.Text = "Capacity";
        // 
        // txtRoomlocation
        // 
        txtRoomlocation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtRoomlocation.Location = new System.Drawing.Point(775, 74);
        txtRoomlocation.Name = "txtRoomlocation";
        txtRoomlocation.Size = new System.Drawing.Size(367, 38);
        txtRoomlocation.TabIndex = 10;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(82, 252);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(75, 23);
        label7.TabIndex = 12;
        label7.Text = "Status";
        label7.Click += label7_Click;
        // 
        // chkFree
        // 
        chkFree.Location = new System.Drawing.Point(177, 251);
        chkFree.Name = "chkFree";
        chkFree.Size = new System.Drawing.Size(104, 24);
        chkFree.TabIndex = 13;
        chkFree.Text = "Free\r\n";
        chkFree.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Location = new System.Drawing.Point(69, 494);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(1055, 217);
        dataGridView1.TabIndex = 16;
        // 
        // btnInsert
        // 
        btnInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnInsert.Location = new System.Drawing.Point(177, 415);
        btnInsert.Name = "btnInsert";
        btnInsert.Size = new System.Drawing.Size(134, 49);
        btnInsert.TabIndex = 17;
        btnInsert.Text = "Insert";
        btnInsert.UseVisualStyleBackColor = true;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new System.Drawing.Point(384, 415);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new System.Drawing.Size(128, 49);
        btnUpdate.TabIndex = 18;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // btnNew
        // 
        btnNew.Location = new System.Drawing.Point(581, 415);
        btnNew.Name = "btnNew";
        btnNew.Size = new System.Drawing.Size(136, 49);
        btnNew.TabIndex = 19;
        btnNew.Text = "New";
        btnNew.UseVisualStyleBackColor = true;
        // 
        // btnLogout
        // 
        btnLogout.Location = new System.Drawing.Point(785, 415);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new System.Drawing.Size(131, 49);
        btnLogout.TabIndex = 20;
        btnLogout.Text = "logout";
        btnLogout.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(595, 144);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(161, 23);
        label4.TabIndex = 21;
        label4.Text = "Department Name";
        // 
        // comboBox1
        // 
        comboBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(775, 134);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(367, 39);
        comboBox1.TabIndex = 22;
        // 
        // textBox1
        // 
        textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox1.Location = new System.Drawing.Point(775, 193);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(367, 38);
        textBox1.TabIndex = 23;
        // 
        // textBox2
        // 
        textBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox2.Location = new System.Drawing.Point(177, 77);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(367, 38);
        textBox2.TabIndex = 24;
        // 
        // textBox3
        // 
        textBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox3.Location = new System.Drawing.Point(177, 135);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(367, 38);
        textBox3.TabIndex = 25;
        // 
        // textBox4
        // 
        textBox4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox4.Location = new System.Drawing.Point(177, 193);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(367, 38);
        textBox4.TabIndex = 26;
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(656, 263);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(123, 23);
        label8.TabIndex = 27;
        label8.Text = "Generation";
        // 
        // textBox5
        // 
        textBox5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox5.Location = new System.Drawing.Point(775, 251);
        textBox5.Name = "textBox5";
        textBox5.Size = new System.Drawing.Size(367, 38);
        textBox5.TabIndex = 28;
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(82, 294);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(75, 23);
        label9.TabIndex = 29;
        label9.Text = "Shift";
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new System.Drawing.Point(177, 294);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new System.Drawing.Size(120, 28);
        comboBox2.TabIndex = 30;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.DarkOrange;
        panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        panel1.Controls.Add(label10);
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1304, 49);
        panel1.TabIndex = 31;
        // 
        // label10
        // 
        label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label10.Location = new System.Drawing.Point(490, 5);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(225, 40);
        label10.TabIndex = 32;
        label10.Text = "Classrom Form";
        label10.Click += label10_Click;
        // 
        // txtSearch
        // 
        txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtSearch.Location = new System.Drawing.Point(163, 349);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(379, 38);
        txtSearch.TabIndex = 32;
        // 
        // label11
        // 
        label11.Location = new System.Drawing.Point(82, 361);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(75, 23);
        label11.TabIndex = 33;
        label11.Text = "Search :";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(1283, 733);
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
        Location = new System.Drawing.Point(19, 19);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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