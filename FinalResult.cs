using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using StudentManagementSysytem;

namespace StudentManagementSystem
{
    public partial class FinalResult : Form
    {
        private bool isLoading = false;

        public FinalResult()
        {
            InitializeComponent();

            LoadComboBoxes();
            cbdepartment.SelectedIndexChanged += ComboBoxes_SelectionChanged;
            cbclass.SelectedIndexChanged += ComboBoxes_SelectionChanged;
            cbgeneration.SelectedIndexChanged += ComboBoxes_SelectionChanged;
            cbyear.SelectedIndexChanged += ComboBoxes_SelectionChanged;
            cbshift.SelectedIndexChanged += ComboBoxes_SelectionChanged;
            cbsemester.SelectedIndexChanged += ComboBoxes_SelectionChanged;
        }
        private void LoadComboBoxes()
        {
            isLoading = true;
            using var conn = HandleConnection.GetConnection();

            // 1. Departments
            using (var cmd = new SqlCommand("SELECT departmentID, departmentName FROM tbDepartment WHERE status = 1", conn))
            using (var reader = cmd.ExecuteReader())
            {
                var dt = new DataTable();
                dt.Load(reader);
                cbdepartment.DisplayMember = "departmentName";
                cbdepartment.ValueMember = "departmentID";
                cbdepartment.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    cbdepartment.SelectedValue = Convert.ToInt32(dt.Rows[0]["departmentID"]);
                }

            }

            // 2. Classes with "All Classes"
            using (var cmd = new SqlCommand("SELECT classroomID, classroomName FROM tbClassroom WHERE status = 1", conn))
            using (var reader = cmd.ExecuteReader())
            {
                var dt = new DataTable();
                dt.Load(reader);
                DataRow allRow = dt.NewRow();
                allRow["classroomID"] = 0;
                allRow["classroomName"] = "All Classes";
                dt.Rows.InsertAt(allRow, 0);
                cbclass.DisplayMember = "classroomName";
                cbclass.ValueMember = "classroomID";
                cbclass.DataSource = dt;
            }


            // 3. Generations with "All Generations"
            using (var cmd = new SqlCommand("SELECT DISTINCT generation FROM tbStudent ORDER BY generation", conn))
            using (var reader = cmd.ExecuteReader())
            {
                var dt = new DataTable();
                dt.Columns.Add("generationText");
                dt.Columns.Add("generation");

                DataRow allRow = dt.NewRow();
                allRow["generation"] = 0;
                allRow["generationText"] = "All Generations";
                dt.Rows.Add(allRow);

                while (reader.Read())
                {
                    var genValue = reader["generation"];
                    var row = dt.NewRow();
                    row["generation"] = genValue;
                    row["generationText"] = $"Generation {genValue}";
                    dt.Rows.Add(row);
                }


                cbgeneration.DisplayMember = "generationText";
                cbgeneration.ValueMember = "generation";
                cbgeneration.DataSource = dt;
            }

            // 4. Years with "All Years"
            // 4. Years manual list: current year down to 10 years ago
            var dtYear = new DataTable();
            dtYear.Columns.Add("yearText");
            dtYear.Columns.Add("year");

            int currentYear = DateTime.Now.Year;

            // Add "All Years" option
            dtYear.Rows.Add("All Years", 0);

            // Add years from current down to 10 years ago
            for (int y = currentYear; y >= currentYear - 10; y--)
            {
                dtYear.Rows.Add(y.ToString(), y);
            }

            cbyear.DisplayMember = "yearText";
            cbyear.ValueMember = "year";
            cbyear.DataSource = dtYear;


            // 5. Shifts with "All Shifts"
            // 5. Shifts fixed list (no DB)
            var dtShift = new DataTable();
            dtShift.Columns.Add("shiftText");
            dtShift.Columns.Add("shift");

            dtShift.Rows.Add("All Shifts", DBNull.Value);
            dtShift.Rows.Add("Morning", "Morning");
            dtShift.Rows.Add("Afternoon", "Afternoon");
            dtShift.Rows.Add("Night", "Night");

            cbshift.DisplayMember = "shiftText";
            cbshift.ValueMember = "shift";
            cbshift.DataSource = dtShift;


            // 6. Semesters static list
            var dtSemester = new DataTable();
            dtSemester.Columns.Add("semesterText");
            dtSemester.Columns.Add("semester");

            dtSemester.Rows.Add("All Semesters", 0);
            dtSemester.Rows.Add("Semester 1", 1);
            dtSemester.Rows.Add("Semester 2", 2);

            cbsemester.DisplayMember = "semesterText";
            cbsemester.ValueMember = "semester";
            cbsemester.DataSource = dtSemester;
            if (cbdepartment.Items.Count > 0)
            {
                int deptID = Convert.ToInt32(cbdepartment.SelectedValue);
                LoadClassroomsByDepartment(deptID);
                LoadFinalResultsWithCurrentSelections();
            }

            isLoading = false;
        }

        private void LoadClassroomsByDepartment(int departmentID)
        {
            try
            {
                using var conn = HandleConnection.GetConnection();

                var cmd = new SqlCommand("SELECT classroomID, classroomName FROM tbClassroom WHERE departmentID = @departmentID AND status = 1", conn);
                cmd.Parameters.AddWithValue("@departmentID", departmentID);

                using var reader = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);

                DataRow allClassRow = dt.NewRow();
                allClassRow["classroomID"] = 0;
                allClassRow["classroomName"] = "All Classes";
                dt.Rows.InsertAt(allClassRow, 0);

                cbclass.DisplayMember = "classroomName";
                cbclass.ValueMember = "classroomID";
                cbclass.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading classrooms: {ex.Message}");
            }
        }

        private void ComboBoxes_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;

            if (sender == cbdepartment)
            {
                int deptID = Convert.ToInt32(cbdepartment.SelectedValue);
                LoadClassroomsByDepartment(deptID);
            }

            LoadFinalResultsWithCurrentSelections();
        }

        private void LoadFinalResultsWithCurrentSelections()
        {
            try
            {
                int departmentID = Convert.ToInt32(cbdepartment.SelectedValue);
                int classroomID = cbclass.SelectedValue != null ? Convert.ToInt32(cbclass.SelectedValue) : 0;
                int generation = cbgeneration.SelectedValue != null ? Convert.ToInt32(cbgeneration.SelectedValue) : 0;
                byte semester = cbsemester.SelectedValue != null ? Convert.ToByte(cbsemester.SelectedValue) : (byte)0;
                int createdYear = cbyear.SelectedValue != null ? Convert.ToInt32(cbyear.SelectedValue) : 0;

                string shift = (cbshift.SelectedValue != null && cbshift.SelectedValue != DBNull.Value)
                    ? cbshift.SelectedValue.ToString()
                    : null;

                LoadFinalResults(departmentID, classroomID, generation, semester, createdYear, shift);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading final results: {ex.Message}");
            }
        }

        private void LoadFinalResults(int departmentID, int classroomID, int generation, byte semester, int createdYear, string shift)
        {
            try
            {
                using var conn = HandleConnection.GetConnection();

                using var cmd = new SqlCommand("sp_ShowStudentFinalResultWithDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@departmentID", departmentID);
                cmd.Parameters.AddWithValue("@classroomID", classroomID == 0 ? DBNull.Value : (object)classroomID);
                cmd.Parameters.AddWithValue("@generation", generation == 0 ? DBNull.Value : (object)generation);
                cmd.Parameters.AddWithValue("@semester", semester == 0 ? DBNull.Value : (object)semester);
                cmd.Parameters.AddWithValue("@createdYear", createdYear == 0 ? DBNull.Value : (object)createdYear);
                cmd.Parameters.AddWithValue("@shift", string.IsNullOrEmpty(shift) ? DBNull.Value : (object)shift);

                using var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                dataOne.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading final results: {ex.Message}");
            }
        }
    }
}
