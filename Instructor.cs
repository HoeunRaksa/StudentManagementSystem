using Microsoft.Data.SqlClient;
using System.Data;
using StudentManagementSysytem;

namespace StudentManagementSystem
{
    public partial class Instructor: Form
    {
        public Instructor()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Male", "Female" });
            comboBox1.SelectedIndex = 0;
            txtInstructorID.ReadOnly = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Load += new System.EventHandler(this.Instructor_Load);

            dataGridView1.CellClick += dataGridView1_CellClick; // Bind the event
            btnSearch.Click += btnSearch_Click;
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            LoadInstructorData();
        }

        private void LoadInstructorData()
        {
            SqlConnection conn = HandleConnection.GetConnection();

            try
            {
                string query = @"
            SELECT 
                instructorID,
                instructorNameKH,
                instructorNameEN,
                CASE gender 
                    WHEN 0 THEN 'Male'
                    WHEN 1 THEN 'Female'
                    ELSE 'Unknown'
                END AS gender,
                birthdate,
                address,
                email,
                phone,
                title,
                office,
                CASE status 
                    WHEN 1 THEN 'Teaching'
                    WHEN 0 THEN 'Stopped'
                    ELSE 'Unknown'
                END AS status
            FROM tbInstructor";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


       private void btnInsert_Click(object sender, EventArgs e)
{
    SqlConnection conn = HandleConnection.GetConnection();

    try
    {
        int gendervalue = comboBox1.Text == "Male" ? 0 : 1;
        string getLastIDQuery = "SELECT TOP 1 instructorID FROM tbInstructor ORDER BY instructorID DESC";
        string newInstructorID = "INS001"; // Default if no existing IDs

        using (SqlCommand idCmd = new SqlCommand(getLastIDQuery, conn))
        {
            object result = idCmd.ExecuteScalar();
            if (result != null)
            {
                string lastID = result.ToString(); // e.g., "INS005"
                int number = int.Parse(lastID.Substring(3)) + 1;
                newInstructorID = "INS" + number.ToString("D3"); // Format as 3-digit number
            }
        }
        
        string insertQuery = "INSERT INTO tbInstructor " +
                             "(instructorID, instructorNameKH, instructorNameEN, gender, birthdate, address, email, phone, title, office, status) " +
                             "VALUES (@InstructorID, @NameKH, @NameEN, @Gender, @BirthDate, @Address, @Email, @Phone, @Title, @Office, @Status)";

        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
        {
            cmd.Parameters.AddWithValue("@InstructorID", newInstructorID);
            cmd.Parameters.AddWithValue("@NameKH", txtNameKH.Text);
            cmd.Parameters.AddWithValue("@NameEN", txtNameEN.Text);
            cmd.Parameters.AddWithValue("@Gender", gendervalue);// Assumes gender is 0 or 1
            cmd.Parameters.AddWithValue("@BirthDate", dateTimePickerBirthDate.Value);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Title", txtDepartment.Text);
            cmd.Parameters.AddWithValue("@Office", txtDegree.Text);
            cmd.Parameters.AddWithValue("@Status", chkStatus.Checked ? 1 : 0); // Convert checkbox to int

            int rows = cmd.ExecuteNonQuery();
            MessageBox.Show(rows > 0 ? "Instructor inserted successfully!" : "Insert failed.");
            LoadInstructorData();
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
}

private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (dataGridView1.CurrentRow == null) return;
    if (e.RowIndex >= 0)
    {
        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

        // Use DBNull checks before assigning values
        txtInstructorID.Text = row.Cells["InstructorID"].Value?.ToString() ?? string.Empty;
        txtNameKH.Text = row.Cells["InstructorNameKH"].Value?.ToString() ?? string.Empty;
        txtNameEN.Text = row.Cells["InstructorNameEN"].Value?.ToString() ?? string.Empty;
        
        // Gender handling
        comboBox1.Text = row.Cells["Gender"].Value?.ToString() ?? "Male"; // Default to Male if DBNull
        
        // Date handling (DBNull check)
        if (DateTime.TryParse(row.Cells["BirthDate"].Value?.ToString(), out DateTime pickedDate))
        {
            dateTimePickerBirthDate.Value = pickedDate;
        }
        else
        {
            dateTimePickerBirthDate.Value = DateTime.Now; // Default date if DBNull
        }

        txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? string.Empty;
        txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
        txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? string.Empty;
        txtDepartment.Text = row.Cells["Title"].Value?.ToString() ?? string.Empty;
        txtDegree.Text = row.Cells["Office"].Value?.ToString() ?? string.Empty;

        // Status (DBNull to boolean)
        chkStatus.Checked = string.Equals(row.Cells["status"].Value?.ToString(), "Teaching", StringComparison.OrdinalIgnoreCase);
        // Disable ID textbox for editing
        txtInstructorID.Enabled = false;
    }
}


        private void lblAddress_Click(object sender, EventArgs e) { }
        private void lblDegree_Click(object sender, EventArgs e) { }
        private void richText_TextChanged(object sender, EventArgs e) { }

       private void btnUpdate_Click(object sender, EventArgs e)
{
    SqlConnection conn = HandleConnection.GetConnection();

    try
    {
        int gendervalue = comboBox1.Text == "Male" ? 0 : 1;
        string query = "UPDATE tbInstructor SET " +
                       "InstructorNameKH = @NameKH, " +
                       "InstructorNameEN = @NameEN, " +
                       "Gender = @Gender, " +
                       "BirthDate = @BirthDate, " +
                       "Address = @Address, " +
                       "Email = @Email, " +
                       "Phone = @Phone, " +
                       "Title = @Title, " +
                       "Office = @Office, " +
                       "Status = @Status " +
                       "WHERE InstructorID = @InstructorID";

        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@InstructorID", txtInstructorID.Text);
            cmd.Parameters.AddWithValue("@NameKH", string.IsNullOrEmpty(txtNameKH.Text) ? DBNull.Value : txtNameKH.Text);
            cmd.Parameters.AddWithValue("@NameEN", string.IsNullOrEmpty(txtNameEN.Text) ? DBNull.Value : txtNameEN.Text);
            cmd.Parameters.AddWithValue("@Gender", string.IsNullOrEmpty(comboBox1.Text) ? DBNull.Value : gendervalue);
            cmd.Parameters.AddWithValue("@BirthDate", dateTimePickerBirthDate.Value == DateTime.MinValue ? DBNull.Value : dateTimePickerBirthDate.Value);
            cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(txtAddress.Text) ? DBNull.Value : txtAddress.Text);
            cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(txtEmail.Text) ? DBNull.Value : txtEmail.Text);
            cmd.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(txtPhone.Text) ? DBNull.Value : txtPhone.Text);
            cmd.Parameters.AddWithValue("@Title", string.IsNullOrEmpty(txtDepartment.Text) ? DBNull.Value : txtDepartment.Text);
            cmd.Parameters.AddWithValue("@Office", string.IsNullOrEmpty(txtDegree.Text) ? DBNull.Value : txtDegree.Text);
            cmd.Parameters.AddWithValue("@Status", chkStatus.Checked ? 1 : 0); // Convert to 1 or 0

            int rows = cmd.ExecuteNonQuery();
            MessageBox.Show(rows > 0 ? "Instructor updated successfully!" : "Update failed.");
            LoadInstructorData(); // Refresh grid
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
}

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            txtInstructorID.Clear();
            txtNameKH.Clear();
            txtNameEN.Clear();
            comboBox1.SelectedIndex = 0;
            dateTimePickerBirthDate.Value = DateTime.Today;
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDepartment.Clear();
            txtDegree.Clear();
            chkStatus.Checked = false;

            txtInstructorID.Enabled = true; // Allow new ID
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            
            SqlConnection conn = HandleConnection.GetConnection();

            try
            {
                
                string query;
                SqlDataAdapter adapter;

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    // ✅ No keyword entered: Load all data
                    query = "SELECT * FROM tbInstructor";
                    adapter = new SqlDataAdapter(query, conn);
                }
                else
                {
                    // ✅ Search by keyword with Khmer support
                    query = @"
                SELECT * FROM tbInstructor
                WHERE
                    instructorID LIKE @keyword OR
                    instructorNameKH LIKE @keyword OR
                    instructorNameEN LIKE @keyword OR
                    gender LIKE @keyword OR
                    phone LIKE @keyword OR
                    email LIKE @keyword";

                    adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                }

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
