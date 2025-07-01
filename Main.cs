namespace StudentManagementSystem;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
    }

    private void enrollment_Click(object sender, EventArgs e)
    {
        Enrollment enrollment = new Enrollment();
        enrollment.Show();
    }

    private void staff_Click(object sender, EventArgs e)
    {
       Staff_sForm staff_sform = new Staff_sForm();
       staff_sform.Show();
    }

    private void student_Click(object sender, EventArgs e)
    {
        Student_Form student_form = new Student_Form();
        student_form.Show();
    }

    private void instructor_Click(object sender, EventArgs e)
    {
        Instructor instructor = new Instructor();
        instructor.Show();
    }

    private void department_Click(object sender, EventArgs e)
    {
        Department department = new Department();
        department.Show();
    }

    private void subject_Click(object sender, EventArgs e)
    {
        
    }

    private void classroom_Click(object sender, EventArgs e)
    {
        Classroom classroom = new Classroom();
        classroom.Show();
    }

    private void schedule_Click(object sender, EventArgs e)
    {
        Schedule schedule = new Schedule();
        schedule.Show();
    }

    private void payment_Click(object sender, EventArgs e)
    {
        Payment payment = new Payment();
        payment.Show();
    }

    private void result_Click(object sender, EventArgs e)
    {
        ResultForm result_form = new ResultForm();
        result_form.Show();
    }

    private void final_Click(object sender, EventArgs e)
    {
        FinalResult final_result = new FinalResult();
        final_result.Show();
    }

    private void analyst_Click(object sender, EventArgs e)
    {
        Analyst analyst = new Analyst();
        analyst.Show();
    }

    private void logout_Click(object sender, EventArgs e)
    {
        Login login = new Login();
        login.Show();
        this.Close();
    }

    private void close_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}