using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using StudentManagementSysytem;

namespace StudentManagementSystem
{
    public partial class Analyst : Form
    {
        public Analyst()
        {
            InitializeComponent();
            textBox1.ReadOnly = true; // AnalystID is auto-generated
            btnInsert.Click += btnInsert_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnNew.Click += btnNew_Click;
            btnLogout.Click += btnLogout_Click;
            LoadComboBoxes();
            LoadAnalystData();

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        // Load ComboBoxes for Staff, Role, Department
        private void LoadComboBoxes()
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                // StaffID
                SqlDataAdapter staffAdapter = new SqlDataAdapter("SELECT StaffNameEN, StaffNameKH, StaffID FROM tbStaff", conn);
                DataTable dtStaff = new DataTable();
                staffAdapter.Fill(dtStaff);
                comboBox1.DataSource = dtStaff;
                comboBox1.DisplayMember = "StaffNameKH";
                comboBox1.ValueMember = "StaffID";
                comboBox3.DataSource = dtStaff;
                comboBox3.DisplayMember = "StaffNameEN";
                comboBox3.ValueMember = "StaffID";

                // Role
                SqlDataAdapter roleAdapter = new SqlDataAdapter("SELECT DISTINCT Role FROM tbStaff WHERE Status = 1", conn);
                DataTable dtRole = new DataTable();
                roleAdapter.Fill(dtRole);
                comboBox2.DataSource = dtRole;
                comboBox2.DisplayMember = "Role";
                comboBox2.ValueMember = "Role";

                // Department
                SqlDataAdapter deptNameAdapter = new SqlDataAdapter("SELECT DepartmentID, DepartmentName FROM tbDepartment", conn);
                DataTable dtDeptName = new DataTable();
                deptNameAdapter.Fill(dtDeptName);
                comboBox4.DataSource = dtDeptName;
                comboBox4.DisplayMember = "DepartmentName";
                comboBox4.ValueMember = "DepartmentID";
            }
        }

        // Load Analyst Data to DataGridView
        private void LoadAnalystData()
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                SqlCommand cmd = new SqlCommand("spGetAllAnalyst", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.DataSource = dt;

                // ✅ Hide ClassroomID column
                if (dataGridView1.Columns.Contains("AnalystID"))
                {
                    dataGridView1.Columns["AnalystID"].Visible = false;
                }

                if (dataGridView1.Columns.Contains("StaffID"))
                {
                    dataGridView1.Columns["StaffID"].Visible=false;
                }

                if (dataGridView1.Columns.Contains("DepartmentID"))
                {
                    dataGridView1.Columns["DepartmentID"].Visible=false;
                }
            }
        }

        // Insert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                try
                {
                    if (comboBox4.SelectedValue == null)
                    {
                        MessageBox.Show("Please select a department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("spInsertAnalyst", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AnalystReport", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@StaffID", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@Role", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@DepartmentID", Convert.ToInt32(comboBox4.SelectedValue));  // ✅ INT
                    cmd.Parameters.AddWithValue("@DepartmentName", comboBox4.Text);                         // ✅ STRING

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



        // Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if an analyst row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Validate AnalystID as string
            string analystId = selectedRow.Cells["AnalystID"]?.Value?.ToString();
            if (string.IsNullOrEmpty(analystId))
            {
                MessageBox.Show("Selected Analyst ID is invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                try
                {
                    SqlCommand cmd = new SqlCommand("spUpdateAnalyst", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AnalystID", analystId); // Use string for AnalystID
                    cmd.Parameters.AddWithValue("@AnalystReport", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@StaffID", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@Role", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@DepartmentID", Convert.ToInt32(comboBox4.SelectedValue));
                    cmd.Parameters.AddWithValue("@DepartmentName", comboBox4.Text); // Optional, if required by your SP

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Update successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAnalystData(); // Refresh your DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // New (Clear)
        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

        // Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Populate form when selecting a row in DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
                return;

            var row = dataGridView1.CurrentRow;

            // Make sure AnalystID is selected properly
            string analystId = row.Cells["AnalystID"]?.Value?.ToString();
            if (string.IsNullOrEmpty(analystId))
            {
                return;
            }

            // Set TextBox1 with AnalystID
            textBox1.Text = analystId;

            // Set the other fields from the selected row
            textBox2.Text = row.Cells["AnalystReport"]?.Value?.ToString() ?? string.Empty;

            if (row.Cells["Date"]?.Value != DBNull.Value)
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Date"].Value);
            else
                dateTimePicker1.Value = DateTime.Now;

            // Set StaffID, Role, and DepartmentID safely
            comboBox1.SelectedValue = row.Cells["StaffID"]?.Value;
            comboBox2.Text = row.Cells["Role"]?.Value?.ToString() ?? string.Empty;
            comboBox4.SelectedValue = row.Cells["DepartmentID"]?.Value;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: handle event or remove it if unused
        }
    }
}
