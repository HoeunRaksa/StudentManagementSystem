using Microsoft.Data.SqlClient;
using StudentManagementSysytem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Subjectcs : Form
    {
        int selectedSubjectID = -1;
        public Subjectcs()
        {
            InitializeComponent();
            LoadDepartments();
            LoadSubjects();
            SetDefaultComboBoxIndex();

           
            dataGridView1.CellClick += dataGridView1_CellClick;
            btnInsert.Click += btnInsert_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnRefresh.Click += btnRefresh_Click;
        }



        private void LoadDepartments()
        {
            using SqlConnection conn = HandleConnection.GetConnection();
            if (conn == null) return;



            string query = "SELECT departmentID, departmentName FROM tbDepartment WHERE status = 1";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);



            comboDepartmentID.DataSource = dt;
            comboDepartmentID.DisplayMember = "departmentID";
            comboDepartmentID.ValueMember = "departmentID";

            comboDepartmentName.DataSource = dt;
            comboDepartmentName.DisplayMember = "departmentName";
            comboDepartmentName.ValueMember = "departmentID";
            comboDepartmentID.SelectedIndexChanged -= ComboDepartmentID_SelectedIndexChanged;
            comboDepartmentID.SelectedIndexChanged += ComboDepartmentID_SelectedIndexChanged;
        }
        private void ComboDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDepartmentID.SelectedValue != null && int.TryParse(comboDepartmentID.SelectedValue.ToString(), out int departmentID))
            {
                comboDepartmentName.SelectedValue = departmentID;
                FilterDataGridViewByDepartmentID(departmentID);
            }
        }

        private void LoadSubjects()
        {
            using SqlConnection conn = HandleConnection.GetConnection();
            if (conn == null) return;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_Subject", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
           conn.Close();
        }

        private void SetDefaultComboBoxIndex()
        {
            comboDepartmentID.SelectedIndex = -1;
            comboDepartmentName.SelectedIndex = -1;
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtsubject.Text.Trim() == "" || comboDepartmentID.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter subject name and select department.");
                return;
            }

            using SqlConnection conn = HandleConnection.GetConnection();
            if (conn == null) return;

            SqlCommand cmd = new SqlCommand("sp_InsertUpdateSubject", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@subjectID", DBNull.Value);
            cmd.Parameters.AddWithValue("@subjectName", txtsubject.Text.Trim());
            cmd.Parameters.AddWithValue("@departmentID", Convert.ToInt32(comboDepartmentID.SelectedValue));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Subject inserted successfully!");

            LoadSubjects();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSubjectID == -1)
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            using SqlConnection conn = HandleConnection.GetConnection();
            if (conn == null) return;

            SqlCommand cmd = new SqlCommand("sp_InsertUpdateSubject", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@subjectID", selectedSubjectID);
            cmd.Parameters.AddWithValue("@subjectName", txtsubject.Text.Trim());
            cmd.Parameters.AddWithValue("@departmentID", Convert.ToInt32(comboDepartmentID.SelectedValue));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Subject updated successfully!");

            LoadSubjects();
            ClearForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
            LoadSubjects();
            ClearForm();

           
        }

      
        private void FilterDataGridViewByDepartmentID(int departmentID)
        {
            using SqlConnection conn = HandleConnection.GetConnection();
            if (conn == null) return;

            string query = "SELECT * FROM vw_Subject WHERE departmentID  = @departmentID ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@departmentID ", departmentID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedSubjectID = Convert.ToInt32(row.Cells["subjectID"].Value);
                LoadSubjectDetails(selectedSubjectID);
            }
        }

        private void LoadSubjectDetails(int subjectID)
        {
            using SqlConnection conn = HandleConnection.GetConnection();
            if (conn == null) return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Subject WHERE subjectID = @subjectID", conn);
            cmd.Parameters.AddWithValue("@subjectID", subjectID);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtsubject.Text = reader["subjectName"].ToString();
                comboDepartmentID.SelectedValue = reader["departmentID"];
                comboDepartmentName.SelectedValue = reader["departmentID"];
            }
        }

        private void ClearForm()
        {
            

            txtsubject.Clear();
            comboDepartmentID.SelectedIndex = -1;
            comboDepartmentName.SelectedIndex = -1;
           
            selectedSubjectID = -1;
           
        }
    }
}
