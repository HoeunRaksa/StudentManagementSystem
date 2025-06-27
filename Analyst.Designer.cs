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
        label6 = new System.Windows.Forms.Label();
        comboBox3 = new System.Windows.Forms.ComboBox();
        label7 = new System.Windows.Forms.Label();
        comboBox4 = new System.Windows.Forms.ComboBox();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        btnInsert = new System.Windows.Forms.Button();
        btnUpdate = new System.Windows.Forms.Button();
        btnNew = new System.Windows.Forms.Button();
        btnLogout = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(78, 111);
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
        textBox1.Location = new System.Drawing.Point(195, 108);
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
        label4.Location = new System.Drawing.Point(738, 117);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 6;
        label4.Text = "StaffID";
        // 
        // comboBox1
        // 
        comboBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(813, 105);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(293, 39);
        comboBox1.TabIndex = 7;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(738, 162);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 23);
        label5.TabIndex = 8;
        label5.Text = "Role";
        // 
        // comboBox2
        // 
        comboBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new System.Drawing.Point(813, 154);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new System.Drawing.Size(293, 39);
        comboBox2.TabIndex = 9;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(683, 221);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(124, 23);
        label6.TabIndex = 10;
        label6.Text = "Department ID";
        // 
        // comboBox3
        // 
        comboBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        comboBox3.FormattingEnabled = true;
        comboBox3.Location = new System.Drawing.Point(813, 209);
        comboBox3.Name = "comboBox3";
        comboBox3.Size = new System.Drawing.Size(293, 39);
        comboBox3.TabIndex = 11;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(668, 274);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(139, 29);
        label7.TabIndex = 12;
        label7.Text = "Department Name";
        // 
        // comboBox4
        // 
        comboBox4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        comboBox4.FormattingEnabled = true;
        comboBox4.Location = new System.Drawing.Point(813, 264);
        comboBox4.Name = "comboBox4";
        comboBox4.Size = new System.Drawing.Size(293, 39);
        comboBox4.TabIndex = 13;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Location = new System.Drawing.Point(90, 412);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(1016, 295);
        dataGridView1.TabIndex = 14;
        // 
        // button1
        // 
        btnInsert.Location = new System.Drawing.Point(90, 337);
        btnInsert.Name = "btnInsert";
        btnInsert.Size = new System.Drawing.Size(120, 42);
        btnInsert.TabIndex = 15;
        btnInsert.Text = "Insert";
        btnInsert.UseVisualStyleBackColor = true;
        btnInsert.Click += new System.EventHandler(btnInsert_Click);
        
        // 
        // button2
        // 
        btnUpdate.Location = new System.Drawing.Point(271, 337);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new System.Drawing.Size(123, 42);
        btnUpdate.TabIndex = 16;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += new System.EventHandler(btnUpdate_Click);
        // 
        // button3
        // 
        btnNew.Location = new System.Drawing.Point(471, 337);
        btnNew.Name = "btnNew";
        btnNew.Size = new System.Drawing.Size(123, 42);
        btnNew.TabIndex = 17;
        btnNew.Text = "New";
        btnNew.UseVisualStyleBackColor = true;
        btnNew.Click += new System.EventHandler(btnNew_Click);
        
        // 
        // button4
        // 
        btnLogout.Location = new System.Drawing.Point(656, 337);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new System.Drawing.Size(130, 42);
        btnLogout.TabIndex = 18;
        btnLogout.Text = "Logout";
        btnLogout.UseVisualStyleBackColor = true;
        btnLogout.Click += new System.EventHandler(btnLogout_Click);
        
        // 
        // Analyst
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1283, 733);
        Controls.Add(btnLogout);
        Controls.Add(btnNew);
        Controls.Add(btnUpdate);
        Controls.Add(btnInsert);
        Controls.Add(dataGridView1);
        Controls.Add(comboBox4);
        Controls.Add(label7);
        Controls.Add(comboBox3);
        Controls.Add(label6);
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
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnNew;
    private System.Windows.Forms.Button btnLogout;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox comboBox3;
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