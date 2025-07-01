using Microsoft.Data.SqlClient;
using System.Data;
using StudentManagementSysytem;
namespace StudentManagementSystem
{
    public partial class Instructor : Form
    {
        public Instructor()
        {
            InitializeComponent();
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
                string query = "SELECT * FROM tbInstructor";
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
            cmd.Parameters.AddWithValue("@Gender", Convert.ToByte(txtGender.Text)); // Assumes gender is 0 or 1
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
            if (dataGridView1.CurrentRow ==null) return ;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtInstructorID.Text = row.Cells["InstructorID"].Value?.ToString();
                txtNameKH.Text = row.Cells["InstructorNameKH"].Value?.ToString();
                txtNameEN.Text = row.Cells["InstructorNameEN"].Value?.ToString();
                txtGender.Text = row.Cells["Gender"].Value?.ToString();
                if (DateTime.TryParse(row.Cells["BirthDate"].Value?.ToString(), out DateTime pickedDate))
                {
                    dateTimePickerBirthDate.Value = pickedDate;
                }


                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtDepartment.Text = row.Cells["Title"].Value?.ToString();
                txtDegree.Text = row.Cells["Office"].Value?.ToString();
                chkStatus.Checked = Convert.ToBoolean(row.Cells["Status"].Value);

                txtInstructorID.Enabled = false; // Disable for editing
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
                    cmd.Parameters.AddWithValue("@NameKH", txtNameKH.Text);
                    cmd.Parameters.AddWithValue("@NameEN", txtNameEN.Text);
                    cmd.Parameters.AddWithValue("@Gender", txtGender.Text);

                    cmd.Parameters.AddWithValue("@BirthDate", dateTimePickerBirthDate.Value);

                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Title", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@Office", txtDegree.Text);
                    cmd.Parameters.AddWithValue("@Status", chkStatus.Checked);

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
            txtGender.Clear();
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
