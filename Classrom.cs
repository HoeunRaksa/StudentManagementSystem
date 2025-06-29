using System.Data;
using Microsoft.Data.SqlClient;
using StudentManagementSysytem;

namespace StudentManagementSystem
{
    public partial class Classroom : Form
    {
        private DataTable classroomData;

        public Classroom()
        {
            InitializeComponent();

            // Add shift options
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new string[] { "Morning", "Afternoon", "Night" });
            comboBox2.SelectedIndex = 0;

            textBox2.ReadOnly = true;

            // Event handlers
            btnInsert.Click += btnInsert_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnNew.Click += btnNew_Click;
            btnLogout.Click += btnLogout_Click;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            txtSearch.TextChanged += txtSearch_TextChanged;

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
                    SqlCommand cmd = new SqlCommand("spGetAllClassroom", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    classroomData = new DataTable();
                    da.Fill(classroomData);

                    dataGridView1.DataSource = classroomData;

                    if (dataGridView1.Columns.Contains("ClassroomID"))
                        dataGridView1.Columns["ClassroomID"].Visible = false;

                    if (dataGridView1.Columns.Contains("DepartmentID"))
                        dataGridView1.Columns["DepartmentID"].Visible = false;
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
                comboBox1.DisplayMember = "DepartmentName";
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

                    cmd.Parameters.AddWithValue("@ClassroomName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@DepartmentID", Convert.ToInt32(comboBox1.SelectedValue));
                    cmd.Parameters.AddWithValue("@RoomLocation", txtRoomlocation.Text);
                    cmd.Parameters.AddWithValue("@BuildingName", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Capacity", Convert.ToInt32(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Status", chkFree.Checked);
                    cmd.Parameters.AddWithValue("@Shift", comboBox2.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Generation", textBox5.Text);

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
                    if (!int.TryParse(textBox2.Text, out int classroomId))
                        throw new Exception("Classroom ID is required and must be a number.");

                    SqlCommand cmd = new SqlCommand("spUpdateClassroom", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ClassroomID", classroomId);
                    cmd.Parameters.AddWithValue("@ClassroomName", string.IsNullOrWhiteSpace(textBox3.Text) ? DBNull.Value : (object)textBox3.Text);
                    cmd.Parameters.AddWithValue("@DepartmentID", comboBox1.SelectedValue ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@RoomLocation", string.IsNullOrWhiteSpace(txtRoomlocation.Text) ? DBNull.Value : (object)txtRoomlocation.Text);
                    cmd.Parameters.AddWithValue("@BuildingName", string.IsNullOrWhiteSpace(textBox4.Text) ? DBNull.Value : (object)textBox4.Text);

                    if (int.TryParse(textBox1.Text, out int capacity))
                        cmd.Parameters.AddWithValue("@Capacity", capacity);
                    else
                        cmd.Parameters.AddWithValue("@Capacity", DBNull.Value);

                    cmd.Parameters.AddWithValue("@Status", chkFree.Checked ? (object)true : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Generation", string.IsNullOrWhiteSpace(textBox5.Text) ? DBNull.Value : (object)textBox5.Text);
                    cmd.Parameters.AddWithValue("@Shift", string.IsNullOrWhiteSpace(comboBox2.Text) ? DBNull.Value : (object)comboBox2.Text);

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
            comboBox2.SelectedIndex = 0;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var row = dataGridView1.CurrentRow;

            textBox2.Text = row.Cells["ClassroomID"].Value?.ToString();
            textBox3.Text = row.Cells["ClassroomName"].Value?.ToString();
            comboBox1.Text = row.Cells["DepartmentName"].Value?.ToString();
            txtRoomlocation.Text = row.Cells["RoomLocation"].Value?.ToString();
            textBox4.Text = row.Cells["BuildingName"].Value?.ToString();
            textBox1.Text = row.Cells["Capacity"].Value?.ToString();
            chkFree.Checked = row.Cells["Status"].Value?.ToString().ToLower() == "free";
            textBox5.Text = row.Cells["Generation"].Value?.ToString();
            comboBox2.Text = row.Cells["Shift"].Value?.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (classroomData == null) return;

            string filter = txtSearch.Text.Trim().Replace("'", "''");

            try
            {
                classroomData.DefaultView.RowFilter = $"DepartmentName LIKE '%{filter}%' OR ClassroomName LIKE '%{filter}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Not implemented
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
