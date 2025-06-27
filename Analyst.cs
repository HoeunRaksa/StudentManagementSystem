using System.Data;
using Microsoft.Data.SqlClient;
using StudentManagementSysytem;

namespace StudentManagementSystem
{
    public partial class Analyst : Form
    {
        public Analyst()
        {
            InitializeComponent();
            LoadComboBoxes(); 
            LoadAnalystData();
        }
        
        private void LoadComboBoxes()
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                // Load Staff ID
                SqlDataAdapter staffIdAdapter = new SqlDataAdapter("SELECT staffID FROM tbStaff WHERE status = 1", conn);
                DataTable dtStaffID = new DataTable();
                staffIdAdapter.Fill(dtStaffID);
                comboBox1.DataSource = dtStaffID;
                comboBox1.DisplayMember = "staffID";
                comboBox1.ValueMember = "staffID";

                // Load Role
                SqlDataAdapter roleAdapter = new SqlDataAdapter("SELECT DISTINCT role FROM tbStaff WHERE status = 1", conn);
                DataTable dtRole = new DataTable();
                roleAdapter.Fill(dtRole);
                comboBox2.DataSource = dtRole;
                comboBox2.DisplayMember = "role";
                comboBox2.ValueMember = "role";

                // Load Department ID
                SqlDataAdapter deptIdAdapter = new SqlDataAdapter("SELECT departmentID FROM tbDepartment WHERE status = 1", conn);
                DataTable dtDeptID = new DataTable();
                deptIdAdapter.Fill(dtDeptID);
                comboBox3.DataSource = dtDeptID;
                comboBox3.DisplayMember = "departmentID";
                comboBox3.ValueMember = "departmentID";

                // Load Department Name
                SqlDataAdapter deptNameAdapter = new SqlDataAdapter("SELECT departmentName FROM tbDepartment WHERE status = 1", conn);
                DataTable dtDeptName = new DataTable();
                deptNameAdapter.Fill(dtDeptName);
                comboBox4.DataSource = dtDeptName;
                comboBox4.DisplayMember = "departmentName";
                comboBox4.ValueMember = "departmentName";
            }
        }

        // Load Analyst Table to DataGridView
        private void LoadAnalystData()
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbAnalyst", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // INSERT
        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertAnalyst", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AnalystID", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@AnalystReport", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@StaffID", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Role", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@DepartmentID", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@DepartmentName", comboBox4.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert successful.", "Success");
                    LoadAnalystData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert failed: " + ex.Message);
                }
            }
        }

        // UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_UpdateAnalyst", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AnalystID", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@AnalystReport", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@StaffID", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Role", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@DepartmentID", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@DepartmentName", comboBox4.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successful.", "Success");
                    LoadAnalystData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }

        // NEW (Clear all fields)
        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

        // LOGOUT (Close form)
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Or redirect to LoginForm
            }
        }
    }
}
