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
        panel1 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        enrollment = new System.Windows.Forms.Button();
        staff = new System.Windows.Forms.Button();
        student = new System.Windows.Forms.Button();
        instructor = new System.Windows.Forms.Button();
        department = new System.Windows.Forms.Button();
        subject = new System.Windows.Forms.Button();
        classroom = new System.Windows.Forms.Button();
        schedule = new System.Windows.Forms.Button();
        payment = new System.Windows.Forms.Button();
        result = new System.Windows.Forms.Button();
        final = new System.Windows.Forms.Button();
        analyst = new System.Windows.Forms.Button();
        logout = new System.Windows.Forms.Button();
        close = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.DarkOrange;
        panel1.Controls.Add(label1);
        panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        panel1.Location = new System.Drawing.Point(-2, -1);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1310, 119);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.800001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(374, 35);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(540, 59);
        label1.TabIndex = 1;
        label1.Text = "Student Management System";
        // 
        // enrollment
        // 
        enrollment.BackColor = System.Drawing.SystemColors.ActiveBorder;
        enrollment.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        enrollment.Location = new System.Drawing.Point(97, 213);
        enrollment.Name = "enrollment";
        enrollment.Size = new System.Drawing.Size(173, 73);
        enrollment.TabIndex = 1;
        enrollment.Text = "Enrollment";
        enrollment.UseVisualStyleBackColor = false;
        enrollment.Click += enrollment_Click;
        // 
        // staff
        // 
        staff.BackColor = System.Drawing.SystemColors.ActiveBorder;
        staff.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        staff.Location = new System.Drawing.Point(372, 213);
        staff.Name = "staff";
        staff.Size = new System.Drawing.Size(173, 73);
        staff.TabIndex = 2;
        staff.Text = "Staff";
        staff.UseVisualStyleBackColor = false;
        staff.Click += staff_Click;
        // 
        // student
        // 
        student.BackColor = System.Drawing.SystemColors.ActiveBorder;
        student.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        student.Location = new System.Drawing.Point(658, 213);
        student.Name = "student";
        student.Size = new System.Drawing.Size(173, 73);
        student.TabIndex = 3;
        student.Text = "Student";
        student.UseVisualStyleBackColor = false;
        student.Click += student_Click;
        // 
        // instructor
        // 
        instructor.BackColor = System.Drawing.SystemColors.ActiveBorder;
        instructor.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        instructor.Location = new System.Drawing.Point(945, 213);
        instructor.Name = "instructor";
        instructor.Size = new System.Drawing.Size(173, 73);
        instructor.TabIndex = 4;
        instructor.Text = "Instructor";
        instructor.UseVisualStyleBackColor = false;
        instructor.Click += instructor_Click;
        // 
        // department
        // 
        department.BackColor = System.Drawing.SystemColors.ActiveBorder;
        department.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        department.Location = new System.Drawing.Point(97, 349);
        department.Name = "department";
        department.Size = new System.Drawing.Size(173, 73);
        department.TabIndex = 5;
        department.Text = "Department";
        department.UseVisualStyleBackColor = false;
        department.Click += department_Click;
        // 
        // subject
        // 
        subject.BackColor = System.Drawing.SystemColors.ActiveBorder;
        subject.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        subject.Location = new System.Drawing.Point(372, 349);
        subject.Name = "subject";
        subject.Size = new System.Drawing.Size(173, 73);
        subject.TabIndex = 6;
        subject.Text = "Subject";
        subject.UseVisualStyleBackColor = false;
        subject.Click += subject_Click;
        // 
        // classroom
        // 
        classroom.BackColor = System.Drawing.SystemColors.ActiveBorder;
        classroom.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        classroom.Location = new System.Drawing.Point(658, 349);
        classroom.Name = "classroom";
        classroom.Size = new System.Drawing.Size(173, 73);
        classroom.TabIndex = 7;
        classroom.Text = "Classroom";
        classroom.UseVisualStyleBackColor = false;
        classroom.Click += classroom_Click;
        // 
        // schedule
        // 
        schedule.BackColor = System.Drawing.SystemColors.ActiveBorder;
        schedule.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        schedule.Location = new System.Drawing.Point(945, 349);
        schedule.Name = "schedule";
        schedule.Size = new System.Drawing.Size(173, 73);
        schedule.TabIndex = 8;
        schedule.Text = "Schedule";
        schedule.UseVisualStyleBackColor = false;
        schedule.Click += schedule_Click;
        // 
        // payment
        // 
        payment.BackColor = System.Drawing.SystemColors.ActiveBorder;
        payment.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        payment.Location = new System.Drawing.Point(97, 490);
        payment.Name = "payment";
        payment.Size = new System.Drawing.Size(173, 73);
        payment.TabIndex = 9;
        payment.Text = "Payment";
        payment.UseVisualStyleBackColor = false;
        payment.Click += payment_Click;
        // 
        // result
        // 
        result.BackColor = System.Drawing.SystemColors.ActiveBorder;
        result.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        result.Location = new System.Drawing.Point(372, 490);
        result.Name = "result";
        result.Size = new System.Drawing.Size(173, 73);
        result.TabIndex = 10;
        result.Text = "Result";
        result.UseVisualStyleBackColor = false;
        result.Click += result_Click;
        // 
        // final
        // 
        final.BackColor = System.Drawing.SystemColors.ActiveBorder;
        final.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        final.Location = new System.Drawing.Point(658, 490);
        final.Name = "final";
        final.Size = new System.Drawing.Size(173, 73);
        final.TabIndex = 11;
        final.Text = "FinalResult";
        final.UseVisualStyleBackColor = false;
        final.Click += final_Click;
        // 
        // analyst
        // 
        analyst.BackColor = System.Drawing.SystemColors.ActiveBorder;
        analyst.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        analyst.Location = new System.Drawing.Point(945, 490);
        analyst.Name = "analyst";
        analyst.Size = new System.Drawing.Size(173, 73);
        analyst.TabIndex = 12;
        analyst.Text = "Analyst";
        analyst.UseVisualStyleBackColor = false;
        analyst.Click += analyst_Click;
        // 
        // logout
        // 
        logout.BackColor = System.Drawing.SystemColors.ActiveBorder;
        logout.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        logout.Location = new System.Drawing.Point(97, 623);
        logout.Name = "logout";
        logout.Size = new System.Drawing.Size(173, 73);
        logout.TabIndex = 13;
        logout.Text = "=>";
        logout.UseVisualStyleBackColor = false;
        logout.Click += logout_Click;
        // 
        // close
        // 
        close.BackColor = System.Drawing.SystemColors.ActiveBorder;
        close.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        close.ForeColor = System.Drawing.Color.Red;
        close.Location = new System.Drawing.Point(372, 623);
        close.Name = "close";
        close.Size = new System.Drawing.Size(173, 73);
        close.TabIndex = 14;
        close.Text = "X";
        close.UseVisualStyleBackColor = false;
        close.Click += close_Click;
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1283, 753);
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
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Main";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button logout;

    private System.Windows.Forms.Button close;

    private System.Windows.Forms.Button staff;
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
}