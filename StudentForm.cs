using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class Student_Form : Form
    {
        public Student_Form()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxes();
            txtStudentID.ReadOnly = true;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.KeyPreview = true;
            this.KeyDown += Student_sForm_KeyDown;
            txtSearch.KeyDown += txtSearch_KeyDown;
            btnInsert.Click += btnInsert_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnLogout.Click += btnLogOut_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnNew.Click += btnNew_Click;
        }

       //Button Insert 

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = HandleConnection.GetConnection();

            try
            {
                //if (conn.State != ConnectionState.Open)
                //    conn.Open();

                SqlCommand cmd = new SqlCommand("spInsertStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                string newStudentID = GenerateStudentID();  // now uses its own connection

                cmd.Parameters.AddWithValue("@StudentID", newStudentID);
                 
                cmd.Parameters.AddWithValue("@NameEN", txtNameEN.Text);
                cmd.Parameters.AddWithValue("@NameKH", txtNameKH.Text);
                cmd.Parameters.AddWithValue("@Gender", chkMale.Checked ? 0 : 1);
                cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@ParentPhone", txtParentPhone.Text);
                cmd.Parameters.AddWithValue("@BirthAddress", txtBirthAddress.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@EnterDate", dtpEnterDate.Value);
                cmd.Parameters.AddWithValue("@Generation", txtGeneration.Text);
                cmd.Parameters.AddWithValue("@Status", chkStudy.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@DepartmentID", cboDepartmentID.SelectedValue);
                cmd.Parameters.AddWithValue("@ClassID", cboClassID.SelectedValue);

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

                    SqlCommand cmd = new SqlCommand("spUpdateStudent", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // ✅ Use existing StudentID from textbox
                    cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);

                    cmd.Parameters.AddWithValue("@NameEN", txtNameEN.Text);
                    cmd.Parameters.AddWithValue("@NameKH", txtNameKH.Text);
                    cmd.Parameters.AddWithValue("@Gender", chkMale.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@ParentPhone", txtParentPhone.Text);
                    cmd.Parameters.AddWithValue("@BirthAddress", txtBirthAddress.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@EnterDate", dtpEnterDate.Value);
                    cmd.Parameters.AddWithValue("@Generation", txtGeneration.Text);
                    cmd.Parameters.AddWithValue("@Status", chkStudy.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@DepartmentID", cboDepartmentID.SelectedValue);
                    cmd.Parameters.AddWithValue("@ClassID", cboClassID.SelectedValue);

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
        }

        //Button New
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void SearchStudent()
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

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbStudent WHERE studentID = @StudentID", conn);
                da.SelectCommand.Parameters.AddWithValue("@StudentID", txtSearch.Text.Trim());

                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Fill textboxes
                    txtStudentID.Text = row["studentID"].ToString();
                    txtNameEN.Text = row["studentNameEN"].ToString();
                    txtNameKH.Text = row["studentNameKH"].ToString();

                    bool gender = row["gender"].ToString() == "1";
                    chkMale.Checked = gender;
                    chkFemale.Checked = !gender;

                    dtpBirthDate.Value = Convert.ToDateTime(row["birthDate"]);
                    txtEmail.Text = row["email"].ToString();
                    txtPhone.Text = row["phone"].ToString();
                    txtParentPhone.Text = row["parentPhone"].ToString();
                    txtBirthAddress.Text = row["birthAddress"].ToString();
                    txtAddress.Text = row["address"].ToString();
                    dtpEnterDate.Value = Convert.ToDateTime(row["enterDate"]);
                    txtGeneration.Text = row["generation"].ToString();

                    bool status = row["status"].ToString() == "1";
                    chkStudy.Checked = status;
                    chkStopStudy.Checked = !status;

                    cboDepartmentID.SelectedValue = Convert.ToInt32(row["departmentID"]);
                    cboClassID.SelectedValue = Convert.ToInt32(row["classroomID"]);

                    // Add text columns
                    dt.Columns.Add("GenderText", typeof(string));
                    dt.Columns.Add("StatusText", typeof(string));

                    foreach (DataRow r in dt.Rows)
                    {
                        r["GenderText"] = r["gender"].ToString() == "1" ? "Male" : "Female";
                        r["StatusText"] = r["status"].ToString() == "1" ? "Study" : "Stop Study";
                    }

                    // Display in DataGridView
                    sub_LoadData(); 

                    dgvStudent.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Student not found.");
                } 
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SearchStudent();
            }
        }
        private void ClearForm()
        {
            txtStudentID.Text = GenerateStudentID(); // Auto-generate ID here
            //txtStudentID.Clear();
            txtNameKH.Clear();
            txtNameEN.Clear();
            chkMale.Checked = false;
            chkFemale.Checked = false;
            dtpBirthDate.Value = DateTime.Today;
            txtEmail.Clear();
            txtPhone.Clear();
            txtParentPhone.Clear();
            txtBirthAddress.Clear();
            txtAddress.Clear();
            dtpEnterDate.Value = DateTime.Today;
            txtGeneration.Clear();
            chkStudy.Checked = false;
            chkStopStudy.Checked = false;
            cboDepartmentID.SelectedIndex = -1;
            cboClassID.SelectedIndex = -1;
        }
         
        private void LoadData()
        {
            try
            {
                using (var conn = HandleConnection.GetConnection())
                {
                    //if (conn.State != ConnectionState.Open)
                    //    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbStudent", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Add extra columns for text display
                    dt.Columns.Add("GenderText", typeof(string));
                    dt.Columns.Add("StatusText", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        bool isMale = row["gender"].ToString() == "True" || row["gender"].ToString() == "1";
                        row["GenderText"] = isMale ? "Male" : "Female";

                        bool isStudying = row["status"].ToString() == "True" || row["status"].ToString() == "1";
                        row["StatusText"] = isStudying ? "Study" : "Stop Study";
                    }

                    // Bind to DataGridView
                    sub_LoadData(); 

                    dgvStudent.DataSource = dt;
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

        private void LoadComboBoxes()
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                //if (conn.State != ConnectionState.Open)
                //    conn.Open();

                SqlDataAdapter daDept = new SqlDataAdapter("SELECT departmentID, departmentName FROM tbDepartment", conn);
                DataTable dtDept = new DataTable();
                daDept.Fill(dtDept);
                cboDepartmentID.DataSource = dtDept;
                cboDepartmentID.ValueMember = "departmentID";
                //cboDepartmentID.DisplayMember = "departmentName"; //  
                cboDepartmentID.SelectedIndex = -1;

                SqlDataAdapter daClass = new SqlDataAdapter("SELECT classroomID, classroomName FROM tbClassroom", conn);
                DataTable dtClass = new DataTable();
                daClass.Fill(dtClass);
                cboClassID.DataSource = dtClass;
                cboClassID.ValueMember = "classroomID";
                //cboClassID.DisplayMember = "classroomName";
                cboClassID.SelectedIndex = -1;

            }
        }

        private void sub_LoadData()
        {
            dgvStudent.DataSource = null;
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.Columns.Clear();

            dgvStudent.Columns.Add("studentID", "ID");
            dgvStudent.Columns["studentID"].DataPropertyName = "studentID"; 

            dgvStudent.Columns.Add("studentNameEN", "Name EN");
            dgvStudent.Columns["studentNameEN"].DataPropertyName = "studentNameEN";

            dgvStudent.Columns.Add("studentNameKH", "Name KH");
            dgvStudent.Columns["studentNameKH"].DataPropertyName = "studentNameKH";


            dgvStudent.Columns.Add("GenderText", "Gender");
            dgvStudent.Columns["GenderText"].DataPropertyName = "GenderText";

            dgvStudent.Columns.Add("birthdate", "Birth Date");
            dgvStudent.Columns["birthdate"].DataPropertyName = "birthdate";

            dgvStudent.Columns.Add("email", "Email");
            dgvStudent.Columns["email"].DataPropertyName = "email";

            dgvStudent.Columns.Add("phone", "Phone");
            dgvStudent.Columns["phone"].DataPropertyName = "phone";

            dgvStudent.Columns.Add("parentPhone", "Parent Phone");
            dgvStudent.Columns["parentPhone"].DataPropertyName = "parentPhone";

            dgvStudent.Columns.Add("birthAddress", "Birth Address");
            dgvStudent.Columns["birthAddress"].DataPropertyName = "birthAddress";

            dgvStudent.Columns.Add("address", "Address");
            dgvStudent.Columns["address"].DataPropertyName = "address";

            dgvStudent.Columns.Add("enterDate", "Enter Date");
            dgvStudent.Columns["enterDate"].DataPropertyName = "enterDate";

            dgvStudent.Columns.Add("generation", "Generation");
            dgvStudent.Columns["generation"].DataPropertyName = "generation";

            dgvStudent.Columns.Add("StatusText", "Status");
            dgvStudent.Columns["StatusText"].DataPropertyName = "StatusText";

            dgvStudent.Columns.Add("departmentID", "Department ID");
            dgvStudent.Columns["departmentID"].DataPropertyName = "departmentID";

            dgvStudent.Columns.Add("classroomID", "Class ID");
            dgvStudent.Columns["classroomID"].DataPropertyName = "classroomID"; 
        }

        //Generate ID 
        private string GenerateStudentID()
        {
            string newID = "ST0001";

            using (SqlConnection conn = new SqlConnection(HandleConnection.ConnnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 studentID FROM tbStudent ORDER BY studentID DESC", conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastID = result.ToString(); // e.g., ST0009
                    int num = int.Parse(lastID.Substring(2));
                    num++;
                    newID = "ST" + num.ToString("D4");
                }
            }

            return newID;
        } 
    }
}
