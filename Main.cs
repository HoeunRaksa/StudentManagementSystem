
namespace StudentManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormClosing += Main_FormClosing;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            this.Hide();
            childForm.FormClosed += (s, args) => this.Show();
            childForm.Show();
        }

        private void enrollment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Enrollment());
        }

        private void staff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff_sForm());
        }

        private void student_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Student_Form());
        }

        private void instructor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Instructor());
        }

        private void department_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Department());
        }

        private void subject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Subjectcs());
             // Assuming you have Subject form
        }

        private void classroom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Classroom());
        }

        private void schedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Schedule());
        }

        private void payment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Payment());
        }

        private void result_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResultForm());
        }

        private void final_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FinalResult());
        }

        private void analyst_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Analyst());
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.FormClosed += (s, args) => Application.Exit(); // Ensure app quits if login is closed
            login.Show();
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
