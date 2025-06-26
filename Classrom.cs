using System.Data;
using Microsoft.Data.SqlClient;
using StudentManagementSysytem; 

namespace StudentManagementSystem
{
    public partial class Classroom : Form
    {
        public Classroom()
        {
            InitializeComponent();
            LoadData();
            LoadDepartmentIDs();
        }

        private void LoadData()
        {
            using (SqlConnection con = HandleConnection.GetConnection())
            {
                if (con == null) return;

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * From tbClassroom", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void LoadDepartmentIDs()
        {
            using (SqlConnection con = HandleConnection.GetConnection())
            {
                if (con == null) return;

                SqlCommand cmd = new SqlCommand("SELECT DepartmentID, DepartmentName FROM tbDepartment", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "DeepartmentName";
                comboBox1.ValueMember = "DepartmentID";
            }
        }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = HandleConnection.GetConnection())
            {
                if (con == null) return;

                try
                {
                    SqlCommand cmd = new SqlCommand("spInsertClassroom", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClassroomID", Convert.ToInt32(textBox2.Text));
                    cmd.Parameters.AddWithValue("@ClassroomName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@DepartmentID", Convert.ToInt32(comboBox1.SelectedValue));
                    cmd.Parameters.AddWithValue("@RoomLocation", txtRoomlocation.Text);
                    cmd.Parameters.AddWithValue("@Building", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Capacity", Convert.ToInt32(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Status", chkFree.Checked);
                    cmd.Parameters.AddWithValue("@Generation", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Shift", Convert.ToString(comboBox2.SelectedValue));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Classroom inserted successfully.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert failed: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = HandleConnection.GetConnection())
            {
                if (con == null) return;

                try
                {
                    SqlCommand cmd = new SqlCommand("spUpdateClassroom", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClassroomID", Convert.ToInt32(textBox2.Text));
                    cmd.Parameters.AddWithValue("@ClassroomName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@DepartmentID", Convert.ToInt32(comboBox1.SelectedValue));
                    cmd.Parameters.AddWithValue("@RoomLocation", txtRoomlocation.Text);
                    cmd.Parameters.AddWithValue("@Building", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Capacity", Convert.ToInt32(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Status", chkFree.Checked);
                    cmd.Parameters.AddWithValue("@Generation", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Shift", Convert.ToString(comboBox2.SelectedValue));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Classroom updated successfully.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Clear();
            textBox5.Clear();
            txtRoomlocation.Clear();
            chkFree.Checked = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Optional: implement label click event if needed
        } // Shift dropdown added
    }
}
