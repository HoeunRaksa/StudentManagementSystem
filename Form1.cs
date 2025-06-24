using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using StudentManagementSysytem;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();

            // Load combobox data first
            LoadDepartments();
            LoadClassrooms();

            // Load DataGridView data
            selection();

            // Hook event after loading data
            dataOne.SelectionChanged += dataselectionchange;
        }

        private void selection(int departmentID = 1, int? classroomID = null, int? generation = null, string shift = null)
        {
            using var conn = HandleConnection.GetConnection();
            using var cmd = new SqlCommand("sp_GetStudentScoresByDepartmentClassGenerationShift", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@departmentID", SqlDbType.Int).Value = departmentID;
            cmd.Parameters.Add("@classroomID", SqlDbType.Int).Value = classroomID ?? (object)DBNull.Value;
            cmd.Parameters.Add("@generation", SqlDbType.Int).Value = generation ?? (object)DBNull.Value;
            cmd.Parameters.Add("@shift", SqlDbType.VarChar, 30).Value = (object)shift ?? DBNull.Value;

            using var adapter = new SqlDataAdapter(cmd);
            ds.Tables.Clear();

            try
            {
                adapter.Fill(ds, "StudentScoresByDepartment");
                dataOne.DataSource = ds.Tables["StudentScoresByDepartment"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Process error during fill: " + ex.Message);
            }
        }

        private void dataselectionchange(object sender, EventArgs e)
        {
            if (dataOne.CurrentRow != null && dataOne.CurrentRow.Index >= 0)
            {
                var selectedRow = dataOne.CurrentRow;

                // TextBoxes
                stuid.Text = selectedRow.Cells["studentID"]?.Value?.ToString() ?? string.Empty;
                stuname.Text = selectedRow.Cells["studentNameEN"]?.Value?.ToString() ?? string.Empty;

                // IDs for comboboxes
                var departmentID = selectedRow.Cells["departmentID"]?.Value;
                var classroomID = selectedRow.Cells["classroomID"]?.Value;

                // Set selected values by ID
                if (departmentID != null && departmentID != DBNull.Value)
                    combodepartment.SelectedValue = departmentID;
                else
                    combodepartment.SelectedIndex = -1;

                if (classroomID != null && classroomID != DBNull.Value)
                    comboclassroom.SelectedValue = classroomID;
                else
                    comboclassroom.SelectedIndex = -1;
            }
            else
            {
                // Clear if no row selected
                stuid.Clear();
                stuname.Clear();
                combodepartment.SelectedIndex = -1;
                comboclassroom.SelectedIndex = -1;
            }
        }

        private DataTable GetDepartments()
        {
            DataTable dt = new DataTable();
            using var conn = HandleConnection.GetConnection();
            using var cmd = new SqlCommand("SELECT departmentID, departmentName FROM tbDepartment", conn);
            using var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        private void LoadDepartments()
        {
            var dtDepartments = GetDepartments();
            combodepartment.DataSource = dtDepartments;
            combodepartment.DisplayMember = "departmentName";
            combodepartment.ValueMember = "departmentID";
        }

        private DataTable GetClassrooms()
        {
            DataTable dt = new DataTable();
            using var conn = HandleConnection.GetConnection();
            using var cmd = new SqlCommand("SELECT classroomID, classroomName FROM tbClassroom", conn);
            using var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        private void LoadClassrooms()
        {
            var dtClassrooms = GetClassrooms();
            comboclassroom.DataSource = dtClassrooms;
            comboclassroom.DisplayMember = "classroomName";
            comboclassroom.ValueMember = "classroomID";
        }
    }
}
