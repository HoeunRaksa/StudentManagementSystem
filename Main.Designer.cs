using System.ComponentModel;

namespace StudentManagementSystem;

partial class Main
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
        panel1 = new Panel();
        label1 = new Label();
        enrollment = new Button();
        student = new Button();
        instructor = new Button();
        department = new Button();
        subject = new Button();
        classroom = new Button();
        schedule = new Button();
        payment = new Button();
        result = new Button();
        final = new Button();
        analyst = new Button();
        logout = new Button();
        close = new Button();
        staff = new Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.DarkOrange;
        panel1.Controls.Add(label1);
        panel1.ForeColor = SystemColors.ButtonHighlight;
        panel1.Location = new Point(-2, -1);
        panel1.Margin = new Padding(3, 2, 3, 2);
        panel1.Name = "panel1";
        panel1.Size = new Size(1146, 89);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 0);
        label1.Location = new Point(327, 26);
        label1.Name = "label1";
        label1.Size = new Size(472, 44);
        label1.TabIndex = 1;
        label1.Text = "Student Management System";
        // 
        // enrollment
        // 
        enrollment.BackColor = SystemColors.ActiveBorder;
        enrollment.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        enrollment.Location = new Point(85, 160);
        enrollment.Margin = new Padding(3, 2, 3, 2);
        enrollment.Name = "enrollment";
        enrollment.Size = new Size(151, 55);
        enrollment.TabIndex = 1;
        enrollment.Text = "Enrollment";
        enrollment.UseVisualStyleBackColor = false;
        enrollment.Click += enrollment_Click;
        // 
        // student
        // 
        student.BackColor = SystemColors.ActiveBorder;
        student.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        student.Location = new Point(576, 160);
        student.Margin = new Padding(3, 2, 3, 2);
        student.Name = "student";
        student.Size = new Size(151, 55);
        student.TabIndex = 3;
        student.Text = "Student";
        student.UseVisualStyleBackColor = false;
        student.Click += student_Click;
        // 
        // instructor
        // 
        instructor.BackColor = SystemColors.ActiveBorder;
        instructor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        instructor.Location = new Point(827, 160);
        instructor.Margin = new Padding(3, 2, 3, 2);
        instructor.Name = "instructor";
        instructor.Size = new Size(151, 55);
        instructor.TabIndex = 4;
        instructor.Text = "Instructor";
        instructor.UseVisualStyleBackColor = false;
        instructor.Click += instructor_Click;
        // 
        // department
        // 
        department.BackColor = SystemColors.ActiveBorder;
        department.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        department.Location = new Point(85, 262);
        department.Margin = new Padding(3, 2, 3, 2);
        department.Name = "department";
        department.Size = new Size(151, 55);
        department.TabIndex = 5;
        department.Text = "Department";
        department.UseVisualStyleBackColor = false;
        department.Click += department_Click;
        // 
        // subject
        // 
        subject.BackColor = SystemColors.ActiveBorder;
        subject.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        subject.Location = new Point(326, 262);
        subject.Margin = new Padding(3, 2, 3, 2);
        subject.Name = "subject";
        subject.Size = new Size(151, 55);
        subject.TabIndex = 6;
        subject.Text = "Subject";
        subject.UseVisualStyleBackColor = false;
        subject.Click += subject_Click;
        // 
        // classroom
        // 
        classroom.BackColor = SystemColors.ActiveBorder;
        classroom.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        classroom.Location = new Point(576, 262);
        classroom.Margin = new Padding(3, 2, 3, 2);
        classroom.Name = "classroom";
        classroom.Size = new Size(151, 55);
        classroom.TabIndex = 7;
        classroom.Text = "Classroom";
        classroom.UseVisualStyleBackColor = false;
        classroom.Click += classroom_Click;
        // 
        // schedule
        // 
        schedule.BackColor = SystemColors.ActiveBorder;
        schedule.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        schedule.Location = new Point(827, 262);
        schedule.Margin = new Padding(3, 2, 3, 2);
        schedule.Name = "schedule";
        schedule.Size = new Size(151, 55);
        schedule.TabIndex = 8;
        schedule.Text = "Schedule";
        schedule.UseVisualStyleBackColor = false;
        schedule.Click += schedule_Click;
        // 
        // payment
        // 
        payment.BackColor = SystemColors.ActiveBorder;
        payment.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        payment.Location = new Point(85, 368);
        payment.Margin = new Padding(3, 2, 3, 2);
        payment.Name = "payment";
        payment.Size = new Size(151, 55);
        payment.TabIndex = 9;
        payment.Text = "Payment";
        payment.UseVisualStyleBackColor = false;
        payment.Click += payment_Click;
        // 
        // result
        // 
        result.BackColor = SystemColors.ActiveBorder;
        result.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        result.Location = new Point(326, 368);
        result.Margin = new Padding(3, 2, 3, 2);
        result.Name = "result";
        result.Size = new Size(151, 55);
        result.TabIndex = 10;
        result.Text = "Result";
        result.UseVisualStyleBackColor = false;
        result.Click += result_Click;
        // 
        // final
        // 
        final.BackColor = SystemColors.ActiveBorder;
        final.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        final.Location = new Point(576, 368);
        final.Margin = new Padding(3, 2, 3, 2);
        final.Name = "final";
        final.Size = new Size(151, 55);
        final.TabIndex = 11;
        final.Text = "FinalResult";
        final.UseVisualStyleBackColor = false;
        final.Click += final_Click;
        // 
        // analyst
        // 
        analyst.BackColor = SystemColors.ActiveBorder;
        analyst.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        analyst.Location = new Point(827, 368);
        analyst.Margin = new Padding(3, 2, 3, 2);
        analyst.Name = "analyst";
        analyst.Size = new Size(151, 55);
        analyst.TabIndex = 12;
        analyst.Text = "Analyst";
        analyst.UseVisualStyleBackColor = false;
        analyst.Click += analyst_Click;
        // 
        // logout
        // 
        logout.BackColor = SystemColors.ActiveBorder;
        logout.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        logout.Location = new Point(325, 457);
        logout.Margin = new Padding(3, 2, 3, 2);
        logout.Name = "logout";
        logout.Size = new Size(151, 55);
        logout.TabIndex = 13;
        logout.Text = "=>";
        logout.UseVisualStyleBackColor = false;
        logout.Click += logout_Click;
        // 
        // close
        // 
        close.BackColor = SystemColors.ActiveBorder;
        close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        close.ForeColor = Color.Red;
        close.Location = new Point(85, 457);
        close.Margin = new Padding(3, 2, 3, 2);
        close.Name = "close";
        close.Size = new Size(151, 55);
        close.TabIndex = 14;
        close.Text = "X";
        close.UseVisualStyleBackColor = false;
        close.Click += close_Click;
        // 
        // staff
        // 
        staff.BackColor = SystemColors.ActiveBorder;
        staff.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        staff.Location = new Point(326, 160);
        staff.Margin = new Padding(3, 2, 3, 2);
        staff.Name = "staff";
        staff.Size = new Size(151, 55);
        staff.TabIndex = 2;
        staff.Text = "Staff";
        staff.UseVisualStyleBackColor = false;
        staff.Click += staff_Click;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1079, 565);
        Controls.Add(close);
        Controls.Add(logout);
        Controls.Add(analyst);
        Controls.Add(final);
        Controls.Add(result);
        Controls.Add(payment);
        Controls.Add(schedule);
        Controls.Add(classroom);
        Controls.Add(subject);
        Controls.Add(department);
        Controls.Add(instructor);
        Controls.Add(student);
        Controls.Add(staff);
        Controls.Add(enrollment);
        Controls.Add(panel1);
        Margin = new Padding(3, 2, 3, 2);
        Name = "Main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Main";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button logout;

    private System.Windows.Forms.Button close;
    private System.Windows.Forms.Button student;
    private System.Windows.Forms.Button instructor;
    private System.Windows.Forms.Button department;
    private System.Windows.Forms.Button subject;
    private System.Windows.Forms.Button classroom;
    private System.Windows.Forms.Button schedule;
    private System.Windows.Forms.Button payment;
    private System.Windows.Forms.Button result;
    private System.Windows.Forms.Button final;
    private System.Windows.Forms.Button analyst;

    private System.Windows.Forms.Button enrollment;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;

    #endregion

    private Button staff;
}