using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using StudentManagementSysytem;

namespace StudentManagementSystem
{
    public partial class Staff_sForm : Form
    {
        SqlCommand cmd = new();
        BindingSource bs = new();
        public Staff_sForm()
        {
            InitializeComponent();
            LoadData();
            this.KeyPreview = true;
            this.KeyDown += Staff_sForm_KeyDown;


            txtStaffID.ReadOnly = true;

            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnInsert.Click += btnInsert_Click;
            btnLogout.Click += btnLogOut_Click;
            btnHome.Click += btnHome_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnNew.Click += btnNew_Click;
            btnRefresh.Click += btnRefresh_Click;
            SearchBar.KeyDown += txtSearchBar_KeyDown;
            dgvStaff.CellClick += dgvStaff_CellClick;
            chkAdmin.CheckedChanged += chkAdmin_CheckedChanged;
            chkStaff.CheckedChanged += chkStaff_CheckedChanged;
            chkWork.CheckedChanged += chkWork_CheckedChanged;
            chkStopWork.CheckedChanged += chkStopWork_CheckedChanged;
            chkMale.CheckedChanged += chkMale_CheckedChanged;
            chkFemale.CheckedChanged += chkFemale_CheckedChanged;
        }

        //Button Insert

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                try
                { 
                    SqlCommand cmd = new SqlCommand("spInsertStaff", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    string newStaffID = GenerateStaffID();
                    txtStaffID.Text = newStaffID;

                    cmd.Parameters.AddWithValue("@staffID", newStaffID);
                    cmd.Parameters.AddWithValue("@namekh", txtNameKH.Text);
                    cmd.Parameters.AddWithValue("@nameen", txtNameEN.Text);
                    cmd.Parameters.AddWithValue("@gender", chkMale.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@birthdate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@role", chkAdmin.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@hireddate", dtpHiredDate.Value);
                    cmd.Parameters.AddWithValue("@salary", decimal.Parse(txtSalary.Text));
                    cmd.Parameters.AddWithValue("@status", chkWork.Checked ? 1 : 0);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted successfully.");
                    LoadData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert failed: " + ex.Message);
                }
            }
        }

        //Btton Update 

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                try
                { 
                    SqlCommand cmd = new SqlCommand("spUpdateStaff", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
                    cmd.Parameters.AddWithValue("@NameKH", txtNameKH.Text);
                    cmd.Parameters.AddWithValue("@NameEN", txtNameEN.Text);
                    cmd.Parameters.AddWithValue("@Gender", chkMale.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Role", chkAdmin.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Passeord", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Salary", decimal.Parse(txtSalary.Text));
                    cmd.Parameters.AddWithValue("@HiredDate", dtpHiredDate.Value);
                    cmd.Parameters.AddWithValue("@Status", chkWork.Checked ? 1 : 0);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully.");
                    LoadData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }

        // Button Logout 

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }
        private void LoadData()
        {
            try
            {
                using (var conn = HandleConnection.GetConnection())
                {
                  
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbStaff", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Add new columns for display text
                    dt.Columns.Add("GenderText", typeof(string));
                    dt.Columns.Add("RoleText", typeof(string));
                    dt.Columns.Add("StatusText", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        // Convert Gender (bit) to "Male" / "Female"
                        bool isMale = row["gender"].ToString() == "True" || row["gender"].ToString() == "1";
                        row["GenderText"] = isMale ? "Male" : "Female";

                        bool isAdmin = row["role"].ToString() == "True" || row["role"].ToString() == "1";
                        row["RoleText"] = isAdmin ? "Admin" : "Staff";

                        // Convert Status (bit) to "Work" / "Stop Work"
                        bool isWorking = row["status"].ToString() == "True" || row["status"].ToString() == "1";
                        row["StatusText"] = isWorking ? "Work" : "Stop Work";
                    }
                    // Bind only the desired columns  
                    sub_LoadData();

                    dgvStaff.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load failed: " + ex.Message);
            }
        }
        private void txtSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                SearchAndFillForm();
            }
        }
        private void Staff_sForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ActiveControl == SearchBar)
                    return;

                e.SuppressKeyPress = true;
                Control nextControl = GetNextControl(this.ActiveControl, true);
                while (nextControl != null)
                {
                    // Allow only certain control types
                    if (nextControl is TextBox || nextControl is ComboBox || nextControl is DateTimePicker)
                    {
                        nextControl.Focus();
                        break;
                    }

                    nextControl = GetNextControl(nextControl, true); // skip and look further
                }
            }
        }

     

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            LoadData();
            ClearForm();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];

                txtStaffID.Text = row.Cells["staffID"].Value?.ToString();
                txtNameKH.Text = row.Cells["staffNameKH"].Value?.ToString();
                txtNameEN.Text = row.Cells["staffNameEN"].Value?.ToString();

                string gender = row.Cells["GenderText"].Value?.ToString();
                chkMale.Checked = gender == "Male";
                chkFemale.Checked = gender == "Female";

                txtAddress.Text = row.Cells["address"].Value?.ToString();

                string role = row.Cells["RoleText"].Value?.ToString();
                chkAdmin.Checked = role == "Admin";
                chkStaff.Checked = role == "Staff";

                txtEmail.Text = row.Cells["email"].Value?.ToString();
                txtPassword.Text = row.Cells["password"].Value?.ToString();
                txtPhone.Text = row.Cells["phone"].Value?.ToString();

                string salaryValue = row.Cells["salary"].Value?.ToString();
                txtSalary.Text = string.IsNullOrWhiteSpace(salaryValue) ? "" : salaryValue; 
                string status = row.Cells["StatusText"].Value?.ToString();
                chkWork.Checked = status == "Work";
                chkStopWork.Checked = status == "Stop Work";

                dtpBirthDate.Value = row.Cells["birthdate"].Value == DBNull.Value ? DateTime.Today: Convert.ToDateTime(row.Cells["birthdate"].Value); 
                dtpHiredDate.Value = row.Cells["hireDate"].Value == DBNull.Value ? DateTime.Today: Convert.ToDateTime(row.Cells["hireDate"].Value);
                   
                    
            }
        } 
        private void ClearForm()
        {
            txtStaffID.Clear();
            txtNameKH.Clear();
            txtNameEN.Clear();
            chkMale.Checked = false;
            chkFemale.Checked = false;
            txtAddress.Clear();
            chkAdmin.Checked = false;
            chkStaff.Checked = false;
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtSalary.Clear();
            dtpBirthDate.Value = DateTime.Today;
            dtpHiredDate.Value = DateTime.Today;
            chkWork.Checked = false;
            chkStopWork.Checked = false;
            SearchBar.Clear();
        } 
        private void SearchAndFillForm()
        {
            SqlConnection conn = HandleConnection.GetConnection(); 
            {
                 
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbStaff WHERE StaffID = @StaffID", conn);
                 

                da.SelectCommand.Parameters.AddWithValue("@StaffID", SearchBar.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    txtStaffID.Text = row["staffID"].ToString();
                    txtNameKH.Text = row["staffNameKH"].ToString();
                    txtNameEN.Text = row["staffNameEN"].ToString();

                    bool gender = row["gender"].ToString() == "1";
                    chkMale.Checked = gender;
                    chkFemale.Checked = !gender;

                    dtpBirthDate.Value = Convert.ToDateTime(row["birthDate"]);

                    txtAddress.Text = row["address"].ToString();

                    bool role = row["role"].ToString() == "1";
                    chkAdmin.Checked = gender;
                    chkStaff.Checked = !gender;

                    txtEmail.Text = row["email"].ToString();
                    txtPassword.Text = row["password"].ToString(); 

                    txtPhone.Text = row["phone"].ToString();
                    dtpHiredDate.Value = Convert.ToDateTime(row["hiredate"]);

                    txtSalary.Text = row["salary"].ToString();

                    bool status = row["status"].ToString() == "1";
                    chkWork.Checked = status;
                    chkStopWork.Checked = !status;

                    dt.Columns.Add("GenderText", typeof(string));
                    dt.Columns.Add("RoleText", typeof(string));
                    dt.Columns.Add("StatusText", typeof(string));

                    foreach (DataRow r in dt.Rows)
                    {
                        r["GenderText"] = r["gender"].ToString() == "1" ? "Male" : "Female";
                        r["RoleText"] = r["gender"].ToString() == "1" ? "Admin" : "Staff";
                        r["StatusText"] = r["status"].ToString() == "1" ? "Study" : "Stop Study";
                    }

                    // Bind only the desired columns 
                    sub_LoadData();
                    dgvStaff.DataSource = dt; 

                }
                else
                {
                    MessageBox.Show("Student not found.");
                } 
            }
        } 
        private void sub_LoadData()
        {
            dgvStaff.DataSource = null;
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.Columns.Clear();

            dgvStaff.Columns.Add("staffID", "ID");
            dgvStaff.Columns["staffID"].DataPropertyName = "staffID";

            dgvStaff.Columns.Add("staffNameKH", "Name KH");
            dgvStaff.Columns["staffNameKH"].DataPropertyName = "staffNameKH";

            dgvStaff.Columns.Add("staffNameEN", "Name EN");
            dgvStaff.Columns["staffNameEN"].DataPropertyName = "staffNameEN";

            dgvStaff.Columns.Add("GenderText", "Gender");
            dgvStaff.Columns["GenderText"].DataPropertyName = "GenderText";

            dgvStaff.Columns.Add("birthdate", "Birth Date");
            dgvStaff.Columns["birthdate"].DataPropertyName = "birthdate";

            dgvStaff.Columns.Add("address", "Address");
            dgvStaff.Columns["address"].DataPropertyName = "address";

            dgvStaff.Columns.Add("RoleText", "Role");
            dgvStaff.Columns["RoleText"].DataPropertyName = "RoleText";

            dgvStaff.Columns.Add("email", "Email");
            dgvStaff.Columns["email"].DataPropertyName = "email";

            dgvStaff.Columns.Add("password", "Password");
            dgvStaff.Columns["password"].DataPropertyName = "password";

            dgvStaff.Columns.Add("phone", "Phone");
            dgvStaff.Columns["phone"].DataPropertyName = "phone";

            dgvStaff.Columns.Add("hireDate", "Hired Date");
            dgvStaff.Columns["hireDate"].DataPropertyName = "hireDate";

            dgvStaff.Columns.Add("salary", "Salary");
            dgvStaff.Columns["salary"].DataPropertyName = "salary";

            dgvStaff.Columns.Add("StatusText", "Status");
            dgvStaff.Columns["StatusText"].DataPropertyName = "StatusText";
            HideColumns();
        }
        private void HideColumns()
        {
            string[] hidden = {"password"};
            foreach (string col in hidden)
            {
                if (dgvStaff.Columns.Contains(col))
                    dgvStaff.Columns[col].Visible = false;
            }
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked)
                chkStaff.Checked = false;
        }

        private void chkStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStaff.Checked)
                chkAdmin.Checked = false;
        }
        private void chkWork_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWork.Checked)
                chkStopWork.Checked = false;
        }

        private void chkStopWork_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStopWork.Checked)
                chkWork.Checked = false;
        }

        private void chkMale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMale.Checked)
                chkFemale.Checked = false;
        }

        private void chkFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemale.Checked)
                chkMale.Checked = false;
        }
        //Genrate ID
        private string GenerateStaffID()
        {
            string newID = "S0001";

            using (SqlConnection conn = new SqlConnection(HandleConnection.ConnnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 staffID FROM tbStaff ORDER BY staffID DESC", conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastID = result.ToString(); // e.g., S0009
                    int num = int.Parse(lastID.Substring(1));
                    num++;
                    newID = "S" + num.ToString("D4");
                }
            }

            return newID;
        } 
    }
}
