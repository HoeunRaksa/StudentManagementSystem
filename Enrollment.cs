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
using StudentManagementSysytem;

namespace StudentManagementSystem
{
    public partial class Enrollment : Form
    {
        public Enrollment()
        {

            InitializeComponent();
            LoadData();
            LoadComboBoxes();
            txtStudentID.ReadOnly = true;
            dgvEnrollment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.KeyPreview = true;
            this.KeyDown += Student_sForm_KeyDown;
            txtSearch.KeyDown += txtSearch_KeyDown;
            btnInsert.Click += btnInsert_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnLogout.Click += btnLogOut_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnNew.Click += btnNew_Click;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = HandleConnection.GetConnection();

            try
            {
                //if (conn.State != ConnectionState.Open)
                //    conn.Open();

                SqlCommand cmd = new SqlCommand("spInsertEnrollment", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                string newStudentID = GenerateEnrollmentID();  // now uses its own connection

                cmd.Parameters.AddWithValue("@enStudentID", newStudentID);

                cmd.Parameters.AddWithValue("@enStudentNameEN", txtNameEN.Text);
                cmd.Parameters.AddWithValue("@enStudentNameKH", txtNameKH.Text);
                cmd.Parameters.AddWithValue("@Gender", chkMale.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@ParentPhone", txtParentPhone.Text);
                //cmd.Parameters.AddWithValue("@BirthAddress", txtBirthAddress.Text);


                cmd.Parameters.AddWithValue("@ResultScore", txtScore.Text);
                cmd.Parameters.AddWithValue("@ResultGrade", txtGrade.Text);
                cmd.Parameters.AddWithValue("@Result", chkPass.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                cmd.Parameters.AddWithValue("@EnDate", dtpEnrollDate.Value);
                cmd.Parameters.AddWithValue("@Status", chkActive.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@DepartmentID", cboDepartmentID.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        //Button Update

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var conn = HandleConnection.GetConnection())
            {
                try
                {
                    //if (conn.State != ConnectionState.Open)
                    //    conn.Open();

                    SqlCommand cmd = new SqlCommand("spUpdateEnrollment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //  Use existing StudentID from textbox
                    cmd.Parameters.AddWithValue("@enStudentID", txtStudentID.Text);

                    cmd.Parameters.AddWithValue("@enStudentNameEN", txtNameEN.Text);
                    cmd.Parameters.AddWithValue("@enStudentNameKH", txtNameKH.Text);
                    cmd.Parameters.AddWithValue("@Gender", chkMale.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@ParentPhone", txtParentPhone.Text);
                    cmd.Parameters.AddWithValue("@ResultScore", txtScore.Text);
                    cmd.Parameters.AddWithValue("@ResultGrade", txtGrade.Text);
                    cmd.Parameters.AddWithValue("@Result", chkPass.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@EnDate", dtpEnrollDate.Value);
                    cmd.Parameters.AddWithValue("@Status", chkActive.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@DepartmentID", cboDepartmentID.SelectedValue);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Button Logout
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Form1 fm1 = new Form1();
            //fm1.Show();
            //this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }

        //Button New
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();

        }

        private void SearchEnrollment()
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadData(); // Show all students if search box is empty
                return;     // Exit the method early
            }
            using (var conn = HandleConnection.GetConnection())
            {
                //if (conn.State != ConnectionState.Open)
                //    conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbEnrollment WHERE enStudentID = @enStudentID", conn);
                da.SelectCommand.Parameters.AddWithValue("@enStudentID", txtSearch.Text.Trim());

                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];


                    txtStudentID.Text = row["enStudentID"].ToString();
                    txtNameEN.Text = row["enStudentNameEN"].ToString();
                    txtNameKH.Text = row["enStudentNameKH"].ToString();
                    bool gender = row["gender"].ToString() == "1";
                    chkMale.Checked = gender;
                    chkFemale.Checked = !gender;
                    dtpBirthDate.Value = Convert.ToDateTime(row["birthDate"]);
                    txtPhone.Text = row["phone"].ToString();
                    txtParentPhone.Text = row["parentPhone"].ToString();
                    txtScore.Text = row["resultScore"].ToString();
                    txtGrade.Text = row["resultGrade"].ToString();

                    bool result = row["result"].ToString() == "1";
                    chkPass.Checked = result;
                    chkFailed.Checked = !result;

                    txtAddress.Text = row["address"].ToString();
                    bool status = row["status"].ToString() == "1";
                    chkActive.Checked = status;
                    chkInactive.Checked = !status;
                    cboDepartmentID.SelectedValue = Convert.ToInt32(row["departmentID"]);

                    // Add text columns
                    dt.Columns.Add("GenderText", typeof(string));
                    dt.Columns.Add("ResultText", typeof(string));
                    dt.Columns.Add("StatusText", typeof(string));

                    foreach (DataRow r in dt.Rows)
                    {
                        r["GenderText"] = r["gender"].ToString() == "1" ? "Male" : "Female";
                        r["ResultText"] = r["result"].ToString() == "1" ? "Pass" : "Failed";
                        r["StatusText"] = r["status"].ToString() == "1" ? "Active" : "Inactive";
                    }

                    // Display in DataGridView
                    sub_LoadData();

                    dgvEnrollment.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Enrollment not found.");
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SearchEnrollment();
            }
        }
        private void ClearForm()
        {
            txtStudentID.Text = GenerateEnrollmentID(); // Auto-generate ID here
            //txtStudentID.Clear();
            txtNameKH.Clear();
            txtNameEN.Clear();
            chkMale.Checked = false;
            chkFemale.Checked = false;
            dtpBirthDate.Value = DateTime.Today;
            txtPhone.Clear();
            txtParentPhone.Clear();
            txtScore.Clear();
            txtGrade.Clear();
            chkPass.Checked = false;
            chkFailed.Checked = false;
            txtAddress.Clear();
            dtpEnrollDate.Value = DateTime.Today;
            chkActive.Checked = false;
            chkInactive.Checked = false;
            cboDepartmentID.SelectedIndex = -1;
            txtSearch.Clear();
        }

        private void LoadData()
        {
            try
            {
                using (var conn = HandleConnection.GetConnection())
                {
                    //if (conn.State != ConnectionState.Open)
                    //    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbEnrollment", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Add extra columns for text display
                    dt.Columns.Add("GenderText", typeof(string));
                    dt.Columns.Add("ResultText", typeof(string));
                    dt.Columns.Add("StatusText", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        bool isMale = row["gender"].ToString() == "True" || row["gender"].ToString() == "1";
                        row["GenderText"] = isMale ? "Male" : "Female";

                        bool isPass = row["result"].ToString() == "True" || row["result"].ToString() == "1";
                        row["ResultText"] = isPass ? "Pass" : "Failed";

                        bool isActive = row["status"].ToString() == "True" || row["status"].ToString() == "1";
                        row["StatusText"] = isActive ? "Active" : "Inactive ";
                    }

                    // Bind to DataGridView
                    sub_LoadData();

                    dgvEnrollment.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load failed: " + ex.Message);
            }
        }
        private void Student_sForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ActiveControl == txtSearch)
                    return;

                e.SuppressKeyPress = true;
                Control nextControl = GetNextControl(this.ActiveControl, true);
                while (nextControl != null)
                {

                    if (nextControl is TextBox || nextControl is ComboBox || nextControl is DateTimePicker)
                    {
                        nextControl.Focus();
                        break;
                    }
                    nextControl = GetNextControl(nextControl, true);
                }
            }
        }

        private void LoadComboBoxes()
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                SqlDataAdapter daDept = new SqlDataAdapter("SELECT departmentID, departmentName FROM tbDepartment", conn);
                DataTable dtDept = new DataTable();
                daDept.Fill(dtDept);
                cboDepartmentID.DataSource = dtDept;
                cboDepartmentID.ValueMember = "departmentID";
                cboDepartmentID.DisplayMember = "departmentName";
                cboDepartmentID.SelectedIndex = -1;
            }
        }

        private void sub_LoadData()
        {
            dgvEnrollment.DataSource = null;
            dgvEnrollment.AutoGenerateColumns = false;
            dgvEnrollment.Columns.Clear();

            dgvEnrollment.Columns.Add("enStudentID", "ID");
            dgvEnrollment.Columns["enStudentID"].DataPropertyName = "enStudentID";

            dgvEnrollment.Columns.Add("enStudentNameEN", "Name EN");
            dgvEnrollment.Columns["enStudentNameEN"].DataPropertyName = "enStudentNameEN";

            dgvEnrollment.Columns.Add("enStudentNameKH", "Name KH");
            dgvEnrollment.Columns["enStudentNameKH"].DataPropertyName = "enStudentNameKH";


            dgvEnrollment.Columns.Add("GenderText", "Gender");
            dgvEnrollment.Columns["GenderText"].DataPropertyName = "GenderText";

            dgvEnrollment.Columns.Add("birthdate", "Birth Date");
            dgvEnrollment.Columns["birthdate"].DataPropertyName = "birthdate";

            dgvEnrollment.Columns.Add("phone", "Phone");
            dgvEnrollment.Columns["phone"].DataPropertyName = "phone";

            dgvEnrollment.Columns.Add("parentPhone", "Parent Phone");
            dgvEnrollment.Columns["parentPhone"].DataPropertyName = "parentPhone";

            dgvEnrollment.Columns.Add("resultScore", "Score");
            dgvEnrollment.Columns["resultScore"].DataPropertyName = "resultScore";

            dgvEnrollment.Columns.Add("resultGrade", "Grade");
            dgvEnrollment.Columns["resultGrade"].DataPropertyName = "resultGrade";

            dgvEnrollment.Columns.Add("ResultText", "Result");
            dgvEnrollment.Columns["ResultText"].DataPropertyName = "ResultText";

            dgvEnrollment.Columns.Add("address", "Address");
            dgvEnrollment.Columns["address"].DataPropertyName = "address";

            dgvEnrollment.Columns.Add("enDate", "Enroll Date");
            dgvEnrollment.Columns["enDate"].DataPropertyName = "enDate";

            dgvEnrollment.Columns.Add("StatusText", "Status");
            dgvEnrollment.Columns["StatusText"].DataPropertyName = "StatusText";

            dgvEnrollment.Columns.Add("departmentID", "Department ID");
            dgvEnrollment.Columns["departmentID"].DataPropertyName = "departmentID";

            HideColumns();
        }

        private void HideColumns()
        {
            string[] hidden = {  "address", "address" };
            foreach (string col in hidden)
            {
                if (dgvEnrollment.Columns.Contains(col))
                    dgvEnrollment.Columns[col].Visible = false;
            }
        }

        //Generate ID 
        private string GenerateEnrollmentID()
        {
            string newID = "EN0001";

            using (SqlConnection conn = new SqlConnection(HandleConnection.ConnnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 enStudentID FROM tbEnrollment ORDER BY enStudentID DESC", conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastID = result.ToString(); // e.g., ST0009
                    int num = int.Parse(lastID.Substring(2));
                    num++;
                    newID = "EN" + num.ToString("D4");
                }
            }

            return newID;
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {

        }
    }
}
