using Microsoft.Data.SqlClient;
using StudentManagementSysytem;
namespace StudentManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtuser.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlConnection con = HandleConnection.GetConnection();
                string query = "SELECT * FROM tbStaff WHERE email = @email AND password = @password AND status = 1";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password); // Plaintext for now — use hash in real apps

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Optional: forgot password or cancel
            Application.Exit();
        }
    }
}
