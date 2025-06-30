
using Microsoft.Data.SqlClient;
using StudentManagementSysytem;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Department : Form
    {
        private int currentDepartmentId = 0;

        public Department()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        //private void LoadDepartments()
        //{
        //    using (SqlConnection conn = HandleConnection.GetConnection())
        //    {
        //        if (conn == null) return;

        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand("spGetAllDepartments", conn);
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            DataTable dt = new DataTable();
        //            da.Fill(dt);

        //            dt.Columns.Add("No", typeof(int)).SetOrdinal(0);
        //            for (int i = 0; i < dt.Rows.Count; i++)
        //            {
        //                dt.Rows[i]["No"] = i + 1;
        //            }

        //            dataGridView1.DataSource = dt;

        //            dataGridView1.Columns["departmentID"].Visible = false;
        //            dataGridView1.Columns["status"].Visible = false;

        //            dataGridView1.Columns["DepartmentID"].HeaderText = "DepartmentID";
        //            dataGridView1.Columns["departmentName"].HeaderText = "DepartmentName";
        //            dataGridView1.Columns["headDepartment"].HeaderText = "HeadDepartment";
        //            dataGridView1.Columns["collegeName"].HeaderText = "CollegeName";
        //            dataGridView1.Columns["location"].HeaderText = "Location";
        //            dataGridView1.Columns["studyPrice"].HeaderText = "StudyPrice";
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Data loading error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
        private void LoadDepartments()
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                try
                {
                    SqlCommand cmd = new SqlCommand("spGetAllDepartments", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Remove the auto-number column ("No") since we're using DepartmentID
                    // dt.Columns.Add("No", typeof(int)).SetOrdinal(0); // Remove this line

                    dataGridView1.DataSource = dt;

                    // Configure column visibility and headers
                    dataGridView1.Columns["departmentID"].Visible = true;
                    dataGridView1.Columns["departmentID"].HeaderText = "DepartmentID";
                    dataGridView1.Columns["departmentName"].HeaderText = "DepartmentName";
                    dataGridView1.Columns["headDepartment"].HeaderText = "HeadDepartment";
                    dataGridView1.Columns["collegeName"].HeaderText = "CollegeName";
                    dataGridView1.Columns["location"].HeaderText = "Location";
                    dataGridView1.Columns["studyPrice"].HeaderText = "StudyPrice";

                    // Hide unnecessary columns
                    dataGridView1.Columns["status"].Visible = false;
                    dataGridView1.Columns["created_at"].Visible = false;

                    // Format the StudyPrice column
                    dataGridView1.Columns["studyPrice"].DefaultCellStyle.Format = "N2";
                    dataGridView1.Columns["studyPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    // Make DepartmentID the first column
                    dataGridView1.Columns["departmentID"].DisplayIndex = 0;

                    // Auto-size columns for better display
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data loading error: " + ex.Message,
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }
        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    // Get search term from TextBox (txtSearch)
        //    string searchTerm = txtSearch.Text.Trim();

        //    // If search is empty, reload all departments
        //    if (string.IsNullOrWhiteSpace(searchTerm))
        //    {
        //        LoadDepartments();
        //        return;
        //    }

        //    using (SqlConnection conn = HandleConnection.GetConnection())
        //    {
        //        if (conn == null) return;

        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand("spSearchDepartmentsByName", conn);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@departmentName", "%" + searchTerm + "%");

        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            DataTable dt = new DataTable();
        //            da.Fill(dt);

        //            // Apply the same column formatting as LoadDepartments()
        //            dataGridView1.DataSource = dt;

        //            // Configure columns to match your main grid
        //            dataGridView1.Columns["departmentID"].HeaderText = "ID";
        //            dataGridView1.Columns["departmentName"].HeaderText = "Department Name";
        //            dataGridView1.Columns["headDepartment"].HeaderText = "Head Department";
        //            dataGridView1.Columns["collegeName"].HeaderText = "College Name";
        //            dataGridView1.Columns["location"].HeaderText = "Location";
        //            dataGridView1.Columns["studyPrice"].HeaderText = "Study Price";
        //            dataGridView1.Columns["studyPrice"].DefaultCellStyle.Format = "N2";

        //            // Hide unnecessary columns
        //            dataGridView1.Columns["status"].Visible = false;
        //            dataGridView1.Columns["created_at"].Visible = false;

        //            if (dt.Rows.Count == 0)
        //            {
        //                MessageBox.Show("No departments found matching '" + searchTerm + "'",
        //                              "Search Results",
        //                              MessageBoxButtons.OK,
        //                              MessageBoxIcon.Information);
        //                LoadDepartments(); // Reload all departments if no results
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Search error: " + ex.Message,
        //                          "Error",
        //                          MessageBoxButtons.OK,
        //                          MessageBoxIcon.Error);
        //        }
        //    }
        //}
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                LoadDepartments();
                return;
            }

            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                try
                {
                    SqlCommand cmd = new SqlCommand("spSearchDepartmentsByName", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@departmentName", "%" + searchTerm + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Clear existing columns to prevent duplicate columns
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = dt;

                    // Configure column visibility and headers
                    if (dataGridView1.Columns["departmentID"] != null)
                        dataGridView1.Columns["departmentID"].HeaderText = "ID";

                    if (dataGridView1.Columns["departmentName"] != null)
                        dataGridView1.Columns["departmentName"].HeaderText = "Department Name";

                    if (dataGridView1.Columns["headDepartment"] != null)
                        dataGridView1.Columns["headDepartment"].HeaderText = "Head Department";

                    if (dataGridView1.Columns["collegeName"] != null)
                        dataGridView1.Columns["collegeName"].HeaderText = "College Name";

                    if (dataGridView1.Columns["location"] != null)
                        dataGridView1.Columns["location"].HeaderText = "Location";

                    if (dataGridView1.Columns["studyPrice"] != null)
                    {
                        dataGridView1.Columns["studyPrice"].HeaderText = "Study Price";
                        dataGridView1.Columns["studyPrice"].DefaultCellStyle.Format = "N2";
                    }

                    // Hide unnecessary columns if they exist
                    string[] columnsToHide = { "status", "created_at" };
                    foreach (string col in columnsToHide)
                    {
                        if (dataGridView1.Columns[col] != null)
                            dataGridView1.Columns[col].Visible = false;
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No departments found matching '" + searchTerm + "'",
                                      "Search Results",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        LoadDepartments();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search error: " + ex.Message,
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                try
                {
                    SqlCommand cmd = new SqlCommand("spInsertDepartment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@departmentName", txtDepartmentName.Text.Trim());
                    cmd.Parameters.AddWithValue("@headDepartment", txtHeadDepartment.Text.Trim());
                    cmd.Parameters.AddWithValue("@collegeName", txtCollegeName.Text.Trim());
                    cmd.Parameters.AddWithValue("@location", txtDepartmentLocation.Text.Trim());
                    cmd.Parameters.AddWithValue("@studyPrice", decimal.Parse(txtStudyPrice.Text));

                    int newId = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show($"Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    LoadDepartments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentDepartmentId == 0)
            {
                MessageBox.Show("Please select a department to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                if (conn == null) return;

                try
                {
                    SqlCommand cmd = new SqlCommand("spUpdateDepartment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@departmentID", currentDepartmentId);
                    cmd.Parameters.AddWithValue("@departmentName", txtDepartmentName.Text.Trim());
                    cmd.Parameters.AddWithValue("@headDepartment", txtHeadDepartment.Text.Trim());
                    cmd.Parameters.AddWithValue("@collegeName", txtCollegeName.Text.Trim());
                    cmd.Parameters.AddWithValue("@location", txtDepartmentLocation.Text.Trim());
                    cmd.Parameters.AddWithValue("@studyPrice", decimal.Parse(txtStudyPrice.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadDepartments();
                        currentDepartmentId = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            currentDepartmentId = 0;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        //        currentDepartmentId = Convert.ToInt32(row.Cells["departmentID"].Value);
        //        txtDepartmentName.Text = row.Cells["departmentName"].Value.ToString();
        //        txtHeadDepartment.Text = row.Cells["headDepartment"].Value.ToString();
        //        txtCollegeName.Text = row.Cells["collegeName"].Value.ToString();
        //        txtDepartmentLocation.Text = row.Cells["location"].Value.ToString();
        //        txtStudyPrice.Text = row.Cells["studyPrice"].Value.ToString();
        //    }
        //}
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentDepartmentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["departmentID"].Value);

                txtDepartmentName.Text = dataGridView1.Rows[e.RowIndex].Cells["departmentName"].Value.ToString();
                txtHeadDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells["headDepartment"].Value.ToString();
                txtCollegeName.Text = dataGridView1.Rows[e.RowIndex].Cells["collegeName"].Value.ToString();
                txtDepartmentLocation.Text = dataGridView1.Rows[e.RowIndex].Cells["location"].Value.ToString();
                txtStudyPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["studyPrice"].Value.ToString();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtDepartmentName.Text))
            {
                MessageBox.Show("Please enter department name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHeadDepartment.Text))
            {
                MessageBox.Show("Please enter head department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCollegeName.Text))
            {
                MessageBox.Show("Please enter college name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtStudyPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid study price (must be positive number).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txtDepartmentName.Clear();
            txtHeadDepartment.Clear();
            txtCollegeName.Clear();
            txtDepartmentLocation.Clear();
            txtStudyPrice.Clear();
        }
    }
}