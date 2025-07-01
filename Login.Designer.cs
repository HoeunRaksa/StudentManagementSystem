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
        panel1 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        txtuser = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        txtpassword = new System.Windows.Forms.TextBox();
        btnlogin = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.DarkOrange;
        panel1.Controls.Add(label1);
        panel1.Location = new System.Drawing.Point(0, -2);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(821, 89);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(340, 30);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(179, 44);
        label1.TabIndex = 1;
        label1.Text = "Login Form";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(147, 154);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(143, 41);
        label2.TabIndex = 1;
        label2.Text = "User name :";
        // 
        // txtuser
        // 
        txtuser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtuser.Location = new System.Drawing.Point(322, 154);
        txtuser.Name = "txtuser";
        txtuser.Size = new System.Drawing.Size(331, 38);
        txtuser.TabIndex = 2;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(147, 228);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(143, 41);
        label3.TabIndex = 3;
        label3.Text = "Password :";
        // 
        // txtpassword
        // 
        txtpassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtpassword.Location = new System.Drawing.Point(322, 225);
        txtpassword.Name = "txtpassword";
        txtpassword.Size = new System.Drawing.Size(331, 38);
        txtpassword.TabIndex = 4;
        // 
        // btnlogin
        // 
        btnlogin.BackColor = System.Drawing.Color.Chartreuse;
        btnlogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnlogin.Location = new System.Drawing.Point(212, 346);
        btnlogin.Name = "btnlogin";
        btnlogin.Size = new System.Drawing.Size(142, 57);
        btnlogin.TabIndex = 5;
        btnlogin.Text = "Login";
        btnlogin.UseVisualStyleBackColor = false;
        btnlogin.Click += btnlogin_Click;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.Red;
        button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.Location = new System.Drawing.Point(469, 346);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(142, 57);
        button1.TabIndex = 6;
        button1.Text = "Close";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // Login
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(815, 450);
        Controls.Add(button1);
        Controls.Add(btnlogin);
        Controls.Add(txtpassword);
        Controls.Add(label3);
        Controls.Add(txtuser);
        Controls.Add(label2);
        Controls.Add(panel1);
        Text = "Login";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox txtuser;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnlogin;

    private System.Windows.Forms.TextBox txtpassword;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}