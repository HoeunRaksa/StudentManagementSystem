using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //using (SqlConnection conn = HandleConnection.GetConnection())
            //SqlConnection conn = HandleConnection.GetConnection();
            using (var conn = HandleConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("spInsertEnrollment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                    cmd.Parameters.AddWithValue("@NameEN", txtNameEN.Text);
                    cmd.Parameters.AddWithValue("@NameKH", txtNameKH.Text);
                    cmd.Parameters.AddWithValue("@Gender", chkMale.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@ParentPhone", txtParentPhone.Text);
                    cmd.Parameters.AddWithValue("@Score", decimal.Parse(txtScore.Text));
                    cmd.Parameters.AddWithValue("@Grade", txtGrade.Text);
                    cmd.Parameters.AddWithValue("@Result", chkPass.Checked ? "Pass" : "Failed");
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@EnrollDate", dtpEnrollDate.Value);
                    cmd.Parameters.AddWithValue("@Status", chkStudy.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@DepartmentID", int.Parse(cboDepartmentID.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enrollment inserted successfully.");
                    //LoadData();
                    //ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert failed: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateEnrollment", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                    cmd.Parameters.AddWithValue("@NameEN", txtNameEN.Text);
                    cmd.Parameters.AddWithValue("@NameKH", txtNameKH.Text);
                    cmd.Parameters.AddWithValue("@Gender", chkMale.Checked ? 0 : 1);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@ParentPhone", txtParentPhone.Text);
                    cmd.Parameters.AddWithValue("@Score", decimal.Parse(txtScore.Text));
                    cmd.Parameters.AddWithValue("@Grade", txtGrade.Text);
                    cmd.Parameters.AddWithValue("@Result", chkPass.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@EnrollDate", dtpEnrollDate.Value);
                    cmd.Parameters.AddWithValue("@Status", chkStudy.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@DepartmentID", int.Parse(cboDepartmentID.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enrollment updated successfully.");
                    LoadData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtStudentID.Clear();
            txtNameEN.Clear();
            txtNameKH.Clear();
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
            chkStudy.Checked = false;
            chkStopStudy.Checked = false;
            cboDepartmentID.SelectedIndex = -1;
        }

        private void LoadData()
        {
            using (SqlConnection conn = HandleConnection.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbEnrollment", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Add readable columns
                dt.Columns.Add("GenderText", typeof(string));
                dt.Columns.Add("ResultText", typeof(string));
                dt.Columns.Add("StatusText", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    row["GenderText"] = row["gender"].ToString() == "1" ? "Female" : "Male";
                    row["ResultText"] = row["result"].ToString() == "Pass" ? "Pass" : "Failed";
                    row["StatusText"] = row["status"].ToString() == "1" ? "Study" : "Stop";
                }

                dgvEnrollment.DataSource = null;
                dgvEnrollment.AutoGenerateColumns = false;
                dgvEnrollment.Columns.Clear();

                dgvEnrollment.Columns.Add("enStudentID", "Student ID");
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

                dgvEnrollment.DataSource = dt;
            }
        }




        private void Enrollment_Load(object sender, EventArgs e)
        {

        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
