using Microsoft.Data.SqlClient;
using StudentManagementSysytem;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Schedule : Form
    {
        private int selectedScheduleID = -1;

        public Schedule()
        {
            InitializeComponent();

            // Attach event handlers
            comboDepartment.SelectedIndexChanged += ComboDepartment_SelectedIndexChanged;
            comboInstructorID.SelectedIndexChanged += ComboFilter_SelectedIndexChanged;
            comboSubject.SelectedIndexChanged += ComboFilter_SelectedIndexChanged;
            comboInstructorID.SelectedIndexChanged += ComboInstructorID_SelectedIndexChanged;
            comboScheduleID.SelectedIndexChanged += ComboScheduleID_SelectedIndexChanged;

            btnInsert.Click += BtnInsert_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnRefresh.Click += BtnRefresh_Click;

            dataGridViewSchedule.SelectionChanged += DataGridViewSchedule_SelectionChanged;

            LoadComboBoxes();
            LoadScheduleIDs();
            LoadScheduleDetails();
            selectedScheduleID = -1;
            comboDepartment.SelectedIndex = -1;
            comboInstructorID.SelectedIndex = -1;
            comboSubject.SelectedIndex = -1;
            comboClassroom.SelectedIndex = -1;
            comboDay.SelectedIndex = -1;
            comboYear.SelectedIndex = -1;
            comboSemester.SelectedIndex = -1;
            comboScheduleID.SelectedIndex = -1;
        }

        private void LoadComboBoxes()
        {
            using SqlConnection conn = HandleConnection.GetConnection();
            if (conn == null) return;

            FillCombo(comboDepartment, "SELECT departmentID, departmentName FROM tbDepartment", "departmentID", "departmentName", conn);
            FillCombo(comboInstructorID, "SELECT instructorID, instructorNameEN FROM tbInstructor", "instructorID", "instructorID", conn);
            FillCombo(comboClassroom, "SELECT classroomID, classroomName FROM tbClassroom", "classroomID", "classroomName", conn);

            comboDay.Items.Clear();
            comboDay.Items.AddRange(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });

            comboYear.Items.Clear();
            comboYear.Items.AddRange(new object[] { 1, 2, 3, 4 });

            comboSemester.Items.Clear();
            comboSemester.Items.AddRange(new object[] { 1, 2 });

            // Reset selections
            comboDepartment.SelectedIndex = -1;
            comboInstructorID.SelectedIndex = -1;
            comboSubject.SelectedIndex = -1;
            comboClassroom.SelectedIndex = -1;
            comboDay.SelectedIndex = -1;
            comboYear.SelectedIndex = -1;
            comboSemester.SelectedIndex = -1;
        }

        private void ComboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDepartment.SelectedValue == null) return;

            if (int.TryParse(comboDepartment.SelectedValue.ToString(), out int deptID))
            {
                using SqlConnection conn = HandleConnection.GetConnection();
                if (conn == null) return;

                string query = "SELECT subjectID, subjectName FROM tbSubject WHERE departmentID = @deptID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@deptID", deptID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboSubject.ValueMember = "subjectID";
                comboSubject.DisplayMember = "subjectName";
                comboSubject.DataSource = dt;
                comboSubject.SelectedIndex = -1;
            }

            LoadScheduleDetails();
        }

        private void ComboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadScheduleDetails();
        }

        private void LoadScheduleDetails()
        {
            try
            {
                using SqlConnection conn = HandleConnection.GetConnection();
                if (conn == null) return;

                string query = "SELECT * FROM vw_ScheduleDetails WHERE 1=1";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (comboDepartment.SelectedValue != null && int.TryParse(comboDepartment.SelectedValue.ToString(), out int departmentID))
                {
                    query += " AND departmentID = @departmentID";
                    cmd.Parameters.AddWithValue("@departmentID", departmentID);
                }

                if (comboInstructorID.SelectedValue != null)
                {
                    query += " AND instructorID = @instructorID";
                    cmd.Parameters.AddWithValue("@instructorID", comboInstructorID.SelectedValue.ToString());
                }

                if (comboSubject.SelectedValue != null && int.TryParse(comboSubject.SelectedValue.ToString(), out int subjectID))
                {
                    query += " AND subjectID = @subjectID";
                    cmd.Parameters.AddWithValue("@subjectID", subjectID);
                }

                cmd.CommandText = query;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewSchedule.DataSource = dt;

                string[] hiddenCols = {  "departmentID", "subjectID", "classroomID", "instructorID" };
                foreach (var col in hiddenCols)
                {
                    if (dataGridViewSchedule.Columns.Contains(col))
                        dataGridViewSchedule.Columns[col].Visible = false;
                }

                if (dataGridViewSchedule.Columns.Contains("scheduleID"))
                {
                    dataGridViewSchedule.Columns["scheduleID"].Visible = true;
                    dataGridViewSchedule.Columns["scheduleID"].DisplayIndex = 0;
                }

                dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewSchedule.ScrollBars = ScrollBars.Vertical;
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schedule: " + ex.Message);
            }
        }

        private void ComboInstructorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboInstructorID.SelectedValue == null)
            {
                txtInstructorName.Text = string.Empty;
                return;
            }

            string selectedInstructorID = comboInstructorID.SelectedValue.ToString();

            using SqlConnection conn = HandleConnection.GetConnection();
            if (conn == null) return;

            string query = "SELECT instructorNameEN FROM tbInstructor WHERE instructorID = @instructorID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@instructorID", selectedInstructorID);

            object result = cmd.ExecuteScalar();
            txtInstructorName.Text = result != null ? result.ToString() : string.Empty;
        }

        private void LoadScheduleIDs()
        {
            using SqlConnection conn = HandleConnection.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT scheduleID FROM tbSchedule", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboScheduleID.DisplayMember = "scheduleID";
            comboScheduleID.ValueMember = "scheduleID";
            comboScheduleID.DataSource = dt;
            comboScheduleID.SelectedIndex = -1;
        }



        private void ComboScheduleID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (comboScheduleID.SelectedValue == null) return;

            if (int.TryParse(comboScheduleID.SelectedValue.ToString(), out int selectedID))
            {
                using SqlConnection conn = HandleConnection.GetConnection();
                if (conn == null) return;

                string query = "SELECT * FROM vw_ScheduleDetails WHERE scheduleID = @scheduleID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@scheduleID", selectedID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewSchedule.DataSource = dt;

                string[] hiddenCols = { "departmentID", "subjectID", "classroomID", "instructorID" };
                foreach (var col in hiddenCols)
                {
                    if (dataGridViewSchedule.Columns.Contains(col))
                        dataGridViewSchedule.Columns[col].Visible = false;
                }

            }

            if (comboScheduleID.SelectedValue != null && int.TryParse(comboScheduleID.SelectedValue.ToString(), out int sid))
            {
               
                selectedScheduleID = sid;
                LoadScheduleByID(sid); // optional: load into ComboBoxes
            }

            

        }

        private void LoadScheduleByID(int scheduleID)
        {
            using SqlConnection conn = HandleConnection.GetConnection();
            string query = "SELECT * FROM vw_ScheduleDetails WHERE scheduleID = @scheduleID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@scheduleID", scheduleID);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                comboDepartment.SelectedValue = reader["departmentID"];
                comboSubject.SelectedValue = reader["subjectID"];
                comboClassroom.SelectedValue = reader["classroomID"];
                comboInstructorID.SelectedValue = reader["instructorID"];
                comboDay.SelectedItem = reader["scheduleDay"].ToString();
                comboYear.SelectedItem = Convert.ToInt32(reader["year"]);
                comboSemester.SelectedItem = Convert.ToInt32(reader["semester"]);

                if (TimeSpan.TryParse(reader["timeStart"].ToString(), out TimeSpan ts))
                    timeStart.Value = DateTime.Today.Add(ts);
                if (TimeSpan.TryParse(reader["timeEnd"].ToString(), out TimeSpan te))
                    timeEnd.Value = DateTime.Today.Add(te);
            }
            reader.Close();
        }







        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using SqlConnection conn = HandleConnection.GetConnection();
                if (conn == null) return;

                int year = Convert.ToInt32(comboYear.SelectedItem);
                int semester = Convert.ToInt32(comboSemester.SelectedItem);
                int subjectID = Convert.ToInt32(comboSubject.SelectedValue);
                int classroomID = Convert.ToInt32(comboClassroom.SelectedValue);
                int departmentID = Convert.ToInt32(comboDepartment.SelectedValue);
                string instructorID = comboInstructorID.SelectedValue.ToString();

                string insertScheduleSql = @"
                    INSERT INTO tbSchedule (scheduleDay, semester, status, subjectID, classroomID, year)
                    VALUES (@scheduleDay, @semester, 1, @subjectID, @classroomID, @year);
                    SELECT CAST(SCOPE_IDENTITY() AS int);";

                SqlCommand cmdSchedule = new SqlCommand(insertScheduleSql, conn);
                cmdSchedule.Parameters.AddWithValue("@scheduleDay", comboDay.SelectedItem.ToString());
                cmdSchedule.Parameters.AddWithValue("@semester", semester);
                cmdSchedule.Parameters.AddWithValue("@year", year);
                cmdSchedule.Parameters.AddWithValue("@subjectID", subjectID);
                cmdSchedule.Parameters.AddWithValue("@classroomID", classroomID);

                int newScheduleID = (int)cmdSchedule.ExecuteScalar();

                SqlCommand cmdDetail = new SqlCommand("sp_InsertUpdateScheduleDetail", conn);
                cmdDetail.CommandType = CommandType.StoredProcedure;

                cmdDetail.Parameters.AddWithValue("@scheduleID", newScheduleID);
                cmdDetail.Parameters.AddWithValue("@departmentID", departmentID);
                cmdDetail.Parameters.AddWithValue("@classroomID", classroomID);
                cmdDetail.Parameters.AddWithValue("@instructorID", instructorID);
                cmdDetail.Parameters.AddWithValue("@subjectID", subjectID);
                cmdDetail.Parameters.AddWithValue("@year", year);
                cmdDetail.Parameters.AddWithValue("@semester", semester);
                cmdDetail.Parameters.AddWithValue("@timeStart", timeStart.Value.ToString("HH:mm:ss"));
                cmdDetail.Parameters.AddWithValue("@timeEnd", timeEnd.Value.ToString("HH:mm:ss"));

                cmdDetail.ExecuteNonQuery();

                MessageBox.Show($"✅ Inserted Schedule ID = {newScheduleID}");
                LoadScheduleDetails();
                LoadScheduleIDs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert error: " + ex.Message);
            }
            selectedScheduleID = -1;
            comboDepartment.SelectedIndex = -1;
            comboInstructorID.SelectedIndex = -1;
            comboSubject.SelectedIndex = -1;
            comboClassroom.SelectedIndex = -1;
            comboDay.SelectedIndex = -1;
            comboYear.SelectedIndex = -1;
            comboSemester.SelectedIndex = -1;
            comboScheduleID.SelectedIndex = -1;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (comboScheduleID.SelectedValue == null || selectedScheduleID == -1)
            {
                MessageBox.Show("⚠️ Please select a ScheduleID to update.");
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                using SqlConnection conn = HandleConnection.GetConnection();
                int scheduleID = selectedScheduleID;
                int year = Convert.ToInt32(comboYear.SelectedItem);
                int semester = Convert.ToInt32(comboSemester.SelectedItem);
                int subjectID = Convert.ToInt32(comboSubject.SelectedValue);
                int classroomID = Convert.ToInt32(comboClassroom.SelectedValue);
                int departmentID = Convert.ToInt32(comboDepartment.SelectedValue);
                string instructorID = comboInstructorID.SelectedValue.ToString();

                string updateScheduleSql = @"
            UPDATE tbSchedule
            SET scheduleDay = @scheduleDay,
                semester = @semester,
                year = @year,
                subjectID = @subjectID,
                classroomID = @classroomID
            WHERE scheduleID = @scheduleID";

                SqlCommand cmd = new SqlCommand(updateScheduleSql, conn);
                cmd.Parameters.AddWithValue("@scheduleDay", comboDay.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@semester", semester);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@subjectID", subjectID);
                cmd.Parameters.AddWithValue("@classroomID", classroomID);
                cmd.Parameters.AddWithValue("@scheduleID", scheduleID);
                cmd.ExecuteNonQuery();

                SqlCommand cmdDetail = new SqlCommand("sp_InsertUpdateScheduleDetail", conn);
                cmdDetail.CommandType = CommandType.StoredProcedure;

                cmdDetail.Parameters.AddWithValue("@scheduleID", scheduleID);
                cmdDetail.Parameters.AddWithValue("@departmentID", departmentID);
                cmdDetail.Parameters.AddWithValue("@classroomID", classroomID);
                cmdDetail.Parameters.AddWithValue("@instructorID", instructorID);
                cmdDetail.Parameters.AddWithValue("@subjectID", subjectID);
                cmdDetail.Parameters.AddWithValue("@year", year);
                cmdDetail.Parameters.AddWithValue("@semester", semester);
                cmdDetail.Parameters.AddWithValue("@timeStart", timeStart.Value.ToString("HH:mm:ss"));
                cmdDetail.Parameters.AddWithValue("@timeEnd", timeEnd.Value.ToString("HH:mm:ss"));

                cmdDetail.ExecuteNonQuery();

                MessageBox.Show("✅ Schedule updated successfully.");
                LoadScheduleDetails();
                LoadScheduleIDs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
            selectedScheduleID = -1;
            comboDepartment.SelectedIndex = -1;
            comboInstructorID.SelectedIndex = -1;
            comboSubject.SelectedIndex = -1;
            comboClassroom.SelectedIndex = -1;
            comboDay.SelectedIndex = -1;
            comboYear.SelectedIndex = -1;
            comboSemester.SelectedIndex = -1;
            comboScheduleID.SelectedIndex = -1;
        }



        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            selectedScheduleID = -1;
            comboDepartment.SelectedIndex = -1;
            comboInstructorID.SelectedIndex = -1;
            comboSubject.SelectedIndex = -1;
            comboClassroom.SelectedIndex = -1;
            comboDay.SelectedIndex = -1;
            comboYear.SelectedIndex = -1;
            comboSemester.SelectedIndex = -1;
            comboScheduleID.SelectedIndex = -1;     

            LoadScheduleDetails();
            
        }

        private void DataGridViewSchedule_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSchedule.SelectedRows.Count > 0)
            {
                var row = dataGridViewSchedule.SelectedRows[0];
                selectedScheduleID = Convert.ToInt32(row.Cells["scheduleID"].Value);
                comboDepartment.SelectedValue = row.Cells["departmentID"].Value;
                comboInstructorID.SelectedValue = row.Cells["instructorID"].Value;
                comboSubject.SelectedValue = row.Cells["subjectID"].Value;
                comboClassroom.SelectedValue = row.Cells["classroomID"].Value;
                comboDay.SelectedItem = row.Cells["scheduleDay"].Value.ToString();
                comboYear.SelectedItem = Convert.ToInt32(row.Cells["year"].Value);
                comboSemester.SelectedItem = Convert.ToInt32(row.Cells["semester"].Value);

                if (TimeSpan.TryParse(row.Cells["timeStart"].Value?.ToString(), out TimeSpan start))
                    timeStart.Value = DateTime.Today.Add(start);
                if (TimeSpan.TryParse(row.Cells["timeEnd"].Value?.ToString(), out TimeSpan end))
                    timeEnd.Value = DateTime.Today.Add(end);
            }
        }

        private bool ValidateInputs()
        {
            if (comboDepartment.SelectedIndex == -1 ||
                comboInstructorID.SelectedIndex == -1 ||
                comboSubject.SelectedIndex == -1 ||
                comboClassroom.SelectedIndex == -1 ||
                comboDay.SelectedIndex == -1 ||
                comboYear.SelectedIndex == -1 ||
                comboSemester.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Fill in all fields.");
                return false;
            }
            return true;
        }

        private void FillCombo(ComboBox combo, string query, string valueMember, string displayMember, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            combo.ValueMember = valueMember;
            combo.DisplayMember = displayMember;
            combo.DataSource = dt;
            combo.SelectedIndex = -1;
        }
    }
}
