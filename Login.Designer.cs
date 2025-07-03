using System.ComponentModel;

namespace StudentManagementSystem;

partial class Login
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
        label2 = new Label();
        txtuser = new TextBox();
        label3 = new Label();
        txtpassword = new TextBox();
        btnlogin = new Button();
        button1 = new Button();
        pictureBox1 = new PictureBox();
        panel1 = new Panel();
        label1 = new Label();
        pictureBox2 = new PictureBox();
        ((ISupportInitialize)pictureBox1).BeginInit();
        panel1.SuspendLayout();
        ((ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(59, 152);
        label2.Name = "label2";
        label2.Size = new Size(125, 31);
        label2.TabIndex = 1;
        label2.Text = "Email ";
        // 
        // txtuser
        // 
        txtuser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtuser.Location = new Point(59, 185);
        txtuser.Margin = new Padding(3, 2, 3, 2);
        txtuser.Multiline = true;
        txtuser.Name = "txtuser";
        txtuser.Size = new Size(363, 43);
        txtuser.TabIndex = 2;
        // 
        // label3
        // 
        label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(59, 238);
        label3.Name = "label3";
        label3.Size = new Size(125, 31);
        label3.TabIndex = 3;
        label3.Text = "Password ";
        // 
        // txtpassword
        // 
        txtpassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtpassword.Location = new Point(59, 271);
        txtpassword.Margin = new Padding(3, 2, 3, 2);
        txtpassword.Multiline = true;
        txtpassword.Name = "txtpassword";
        txtpassword.Size = new Size(363, 43);
        txtpassword.TabIndex = 4;
        // 
        // btnlogin
        // 
        btnlogin.BackColor = Color.CornflowerBlue;
        btnlogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnlogin.Location = new Point(130, 343);
        btnlogin.Margin = new Padding(3, 2, 3, 2);
        btnlogin.Name = "btnlogin";
        btnlogin.Size = new Size(226, 43);
        btnlogin.TabIndex = 5;
        btnlogin.Text = "Login";
        btnlogin.UseVisualStyleBackColor = false;
        btnlogin.Click += btnlogin_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.Transparent;
        button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Location = new Point(130, 402);
        button1.Margin = new Padding(3, 2, 3, 2);
        button1.Name = "button1";
        button1.Size = new Size(226, 43);
        button1.TabIndex = 6;
        button1.Text = "Close";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.college_building_academic_building_university_in_traditional_english_style_with_trees_and_a_green_lawn_and_playground_illustration_on_white_background_free_vector;
        pictureBox1.Location = new Point(481, 19);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(533, 490);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 11;
        pictureBox1.TabStop = false;
        // 
        // panel1
        // 
        panel1.BackColor = Color.DarkOrange;
        panel1.Controls.Add(label1);
        panel1.Location = new Point(1, 1);
        panel1.Margin = new Padding(3, 2, 3, 2);
        panel1.Name = "panel1";
        panel1.Size = new Size(1020, 67);
        panel1.TabIndex = 12;
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(413, 22);
        label1.Name = "label1";
        label1.Size = new Size(157, 33);
        label1.TabIndex = 1;
        label1.Text = "Login Form";
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.user__2_;
        pictureBox2.Location = new Point(181, 78);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(131, 71);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 13;
        pictureBox2.TabStop = false;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1016, 459);
        Controls.Add(pictureBox2);
        Controls.Add(panel1);
        Controls.Add(pictureBox1);
        Controls.Add(button1);
        Controls.Add(btnlogin);
        Controls.Add(txtpassword);
        Controls.Add(label3);
        Controls.Add(txtuser);
        Controls.Add(label2);
        Margin = new Padding(3, 2, 3, 2);
        Name = "Login";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ((ISupportInitialize)pictureBox1).EndInit();
        panel1.ResumeLayout(false);
        ((ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox txtuser;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnlogin;

    private System.Windows.Forms.TextBox txtpassword;

    private System.Windows.Forms.Label label2;

#endregion
    private PictureBox pictureBox1;
    private Panel panel1;
    private Label label1;
    private PictureBox pictureBox2;
}