namespace StudentManagementSystem;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void btnlogin_Click(object sender, EventArgs e)
    {
         Main main = new Main();
         main.Show();
         this.Hide();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}