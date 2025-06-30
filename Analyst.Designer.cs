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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        label4 = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        label5 = new System.Windows.Forms.Label();
        comboBox2 = new System.Windows.Forms.ComboBox();
        label7 = new System.Windows.Forms.Label();
        comboBox4 = new System.Windows.Forms.ComboBox();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        btnInsert = new System.Windows.Forms.Button();
        btnUpdate = new System.Windows.Forms.Button();
        btnNew = new System.Windows.Forms.Button();
        btnLogout = new System.Windows.Forms.Button();
        label6 = new System.Windows.Forms.Label();
        comboBox3 = new System.Windows.Forms.ComboBox();
        panel1 = new System.Windows.Forms.Panel();
        label8 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(89, 108);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 0;
        label1.Text = "AnalystID";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(78, 162);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(132, 23);
        label2.TabIndex = 1;
        label2.Text = "AnalystReport";
        // 
        // textBox1
        // 
        textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox1.Location = new System.Drawing.Point(195, 96);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(299, 38);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox2.Location = new System.Drawing.Point(195, 159);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(299, 38);
        textBox2.TabIndex = 3;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(78, 234);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(132, 23);
        label3.TabIndex = 4;
        label3.Text = "Date";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dateTimePicker1.Location = new System.Drawing.Point(195, 226);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(383, 30);
        dateTimePicker1.TabIndex = 5;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(729, 147);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 6;
        label4.Text = "StaffKH";
        // 
        // comboBox1
        // 
        comboBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(813, 131);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(293, 39);
        comboBox1.TabIndex = 7;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(738, 200);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 23);
        label5.TabIndex = 8;
        label5.Text = "Role";
        // 
        // comboBox2
        // 
        comboBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new System.Drawing.Point(813, 188);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new System.Drawing.Size(293, 39);
        comboBox2.TabIndex = 9;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(668, 257);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(139, 29);
        label7.TabIndex = 12;
        label7.Text = "Department Name";
        // 
        // comboBox4
        // 
        comboBox4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        comboBox4.FormattingEnabled = true;
        comboBox4.Location = new System.Drawing.Point(813, 247);
        comboBox4.Name = "comboBox4";
        comboBox4.Size = new System.Drawing.Size(293, 39);
        comboBox4.TabIndex = 13;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Location = new System.Drawing.Point(154, 412);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(804, 295);
        dataGridView1.TabIndex = 14;
        // 
        // btnInsert
        // 
        btnInsert.Location = new System.Drawing.Point(154, 337);
        btnInsert.Name = "btnInsert";
        btnInsert.Size = new System.Drawing.Size(120, 42);
        btnInsert.TabIndex = 15;
        btnInsert.Text = "Insert";
        btnInsert.UseVisualStyleBackColor = true;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new System.Drawing.Point(319, 337);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new System.Drawing.Size(123, 42);
        btnUpdate.TabIndex = 16;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // btnNew
        // 
        btnNew.Location = new System.Drawing.Point(525, 337);
        btnNew.Name = "btnNew";
        btnNew.Size = new System.Drawing.Size(123, 42);
        btnNew.TabIndex = 17;
        btnNew.Text = "New";
        btnNew.UseVisualStyleBackColor = true;
        // 
        // btnLogout
        // 
        btnLogout.Location = new System.Drawing.Point(768, 337);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new System.Drawing.Size(130, 42);
        btnLogout.TabIndex = 18;
        btnLogout.Text = "Logout";
        btnLogout.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(729, 88);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(100, 23);
        label6.TabIndex = 19;
        label6.Text = "StaffEN";
        // 
        // comboBox3
        // 
        comboBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        comboBox3.FormattingEnabled = true;
        comboBox3.Location = new System.Drawing.Point(813, 76);
        comboBox3.Name = "comboBox3";
        comboBox3.Size = new System.Drawing.Size(293, 39);
        comboBox3.TabIndex = 20;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.DarkOrange;
        panel1.Controls.Add(label8);
        panel1.Location = new System.Drawing.Point(0, -2);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1293, 68);
        panel1.TabIndex = 21;
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.Location = new System.Drawing.Point(525, 23);
        label8.Name = "label8";
        label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        label8.Size = new System.Drawing.Size(172, 34);
        label8.TabIndex = 22;
        label8.Text = "AnalystForm";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1283, 733);
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
        Text = "Analyst";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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