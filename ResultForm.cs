using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;  // Use this or System.Data.SqlClient based on your setup
using StudentManagementSysytem; // Assuming this contains your HandleConnection class

namespace StudentManagementSystem
{
    public partial class ResultForm : Form
    {
        private DataSet ds = new DataSet();
        private bool _isUpdatingControls = false;
        private bool isLoading = false;

        public ResultForm()
        {
            InitializeComponent();
            LoadDepartments();

            comboShift.Items.AddRange(new string[] { "All", "morning", "afternoon", "night" });
            LoadCreatedYears(2020, DateTime.Now.Year);
            LoadSemesters();
            combodepartment.SelectedIndexChanged += combodepartment_SelectedIndexChanged;
            comboclassroom.SelectedIndexChanged += filterComboChanged;
            combogeneration.SelectedIndexChanged += filterComboChanged;
            comboShift.SelectedIndexChanged += filterComboChanged;
            comboCreateAt.SelectedIndexChanged += filterComboChanged;
            combosemester.SelectedIndexChanged += filterComboChanged;
            btnSave.Click += btnSave_Click;

            dataOne.SelectionChanged += dataselectionchange;
            dataOne.DataError += (s, e) => { e.ThrowException = false; };

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (combodepartment.Items.Count > 0)
            {
                int deptID = GetComboBoxSelectedValueAsInt(combodepartment);
                if (deptID > 0)
                {
                    LoadClassrooms(deptID);
                    selection(deptID, null, null, null, null, null);
                }
            }

            LoadGenerations();

            if (comboShift.Items.Count > 0)
                comboShift.SelectedIndex = 0;  // "All"

            if (combogeneration.Items.Count > 0)
                combogeneration.SelectedIndex = 0;

            if (comboCreateAt.Items.Count > 0)
                comboCreateAt.SelectedIndex = 0; // "All"

            if (combosemester.Items.Count > 0)
                combosemester.SelectedIndex = 0; // "All"
        }

        private void LoadCreatedYears(int startYear, int endYear)
        {
            comboCreateAt.Items.Clear();
            comboCreateAt.Items.Add("All");
            for (int year = startYear; year <= endYear; year++)
            {
                comboCreateAt.Items.Add(year);
            }
            comboCreateAt.SelectedIndex = 0; // Default to "All"
        }

        private void LoadSemesters()
        {
            combosemester.Items.Clear();
            combosemester.Items.Add("All");
            combosemester.Items.Add("1");
            combosemester.Items.Add("2");
            combosemester.SelectedIndex = 0;
        }

        private void SetDataSourceWithFilter()
        {
            if (!ds.Tables.Contains("StudentScoresByDepartment"))
                return;

            var table = ds.Tables["StudentScoresByDepartment"];

            if (table.Columns.Contains("studentID"))
                table.Columns["studentID"].AllowDBNull = true;

            var view = new DataView(table);
            if (table.Columns.Contains("studentID"))
                view.RowFilter = "studentID IS NOT NULL";

            dataOne.DataSource = view;
        }

        private void HideColumns()
        {
            string[] hidden = {"studentNameEN", "generation", "shift", "departmentID", "classroomID", "classroomName", "departmentName", "createdYear", "semester" };
            foreach (string col in hidden)
            {
                if (dataOne.Columns.Contains(col))
                    dataOne.Columns[col].Visible = false;
            }
        }

        private void selection(int departmentID, int? classroomID = null, int? generation = null, string shift = null, byte? semester = null, int? createdYear = null)
        {
            if (isLoading) return;
            isLoading = true;

            using var conn = HandleConnection.GetConnection();
            using var cmd = new SqlCommand("sp_GetStudentScoresByDepartmentClassGenerationShift", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@departmentID", SqlDbType.Int).Value = departmentID;
            cmd.Parameters.Add("@classroomID", SqlDbType.Int).Value = classroomID ?? (object)DBNull.Value;
            cmd.Parameters.Add("@generation", SqlDbType.Int).Value = generation ?? (object)DBNull.Value;
            cmd.Parameters.Add("@shift", SqlDbType.VarChar, 30).Value = (object)shift ?? DBNull.Value;
            cmd.Parameters.Add("@semester", SqlDbType.TinyInt).Value = semester ?? (object)DBNull.Value;
            cmd.Parameters.Add("@createdYear", SqlDbType.Int).Value = createdYear ?? (object)DBNull.Value;

            using var adapter = new SqlDataAdapter(cmd);
            ds.Tables.Clear();

            try
            {
                adapter.Fill(ds, "StudentScoresByDepartment");

                if (!ds.Tables.Contains("StudentScoresByDepartment") || ds.Tables["StudentScoresByDepartment"].Rows.Count == 0)
                {
                    dataOne.DataSource = null;
                    MessageBox.Show("There is no classes and students in this generation yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stuid.Text = "";
                    stuname.Text = "";
                    return;
                }

                SetDataSourceWithFilter();
                HideColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading student scores:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isLoading = false;
            }
        }

        private void filterComboChanged(object sender, EventArgs e)
        {
            if (_isUpdatingControls) return;

            int departmentID = GetComboBoxSelectedValueAsInt(combodepartment);
            if (departmentID == 0) return;

            int? classroomID = null;
            if (comboclassroom.Enabled && comboclassroom.SelectedValue != null)
            {
                int cid = GetComboBoxSelectedValueAsInt(comboclassroom);
                if (cid > 0) classroomID = cid;  // If 0 (All), then classroomID stays null = no filter
            }

            int? gen = null;
            if (combogeneration.SelectedItem != null && combogeneration.SelectedItem.ToString() != "All")
            {
                if (int.TryParse(combogeneration.SelectedItem.ToString(), out int genVal))
                    gen = genVal;
            }

            string shift = comboShift.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(shift) || shift == "All")
                shift = null;

            byte? semester = null;
            if (combosemester.SelectedItem != null && combosemester.SelectedItem.ToString() != "All")
            {
                if (byte.TryParse(combosemester.SelectedItem.ToString(), out byte sem))
                    semester = sem;
            }

            int? createdYear = null;
            if (comboCreateAt.SelectedItem != null && comboCreateAt.SelectedItem.ToString() != "All")
            {
                if (int.TryParse(comboCreateAt.SelectedItem.ToString(), out int year))
                    createdYear = year;
            }

            selection(departmentID, classroomID, gen, shift, semester, createdYear);
        }

        private void combodepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingControls) return;

            int deptID = GetComboBoxSelectedValueAsInt(combodepartment);
            if (deptID > 0)
            {
                LoadClassrooms(deptID);
                selection(deptID, null, null, null, null, null);
            }
            else
            {
                comboclassroom.DataSource = null;
                comboclassroom.Items.Clear();
                comboclassroom.Enabled = false;
                dataOne.DataSource = null;
            }
        }

        private void dataselectionchange(object sender, EventArgs e)
        {
            try
            {
                if (dataOne.CurrentRow != null &&
                    !dataOne.CurrentRow.IsNewRow &&
                    dataOne.CurrentRow.Index >= 0 &&
                    dataOne.CurrentRow.Index < dataOne.Rows.Count)
                {
                    var row = dataOne.CurrentRow;
                    stuid.Text = row.Cells["studentID"]?.Value?.ToString() ?? "";
                    stuname.Text = row.Cells["studentNameEN"]?.Value?.ToString() ?? "";
                }
                else
                {
                    stuid.Text = "";
                    stuname.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message, "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stuid.Text = "";
                stuname.Text = "";
            }
        }

        private void LoadDepartments()
        {
            _isUpdatingControls = true;
            var dt = GetDepartments();
            combodepartment.DataSource = dt;
            combodepartment.DisplayMember = "departmentName";
            combodepartment.ValueMember = "departmentID";
            _isUpdatingControls = false;

            if (combodepartment.Items.Count > 0)
                combodepartment.SelectedIndex = 0;
        }

        private DataTable GetDepartments()
        {
            using var conn = HandleConnection.GetConnection();
            using var cmd = new SqlCommand("SELECT departmentID, departmentName FROM tbDepartment", conn);
            using var adapter = new SqlDataAdapter(cmd);

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void LoadClassrooms(int departmentID)
        {
            _isUpdatingControls = true;

            using var conn = HandleConnection.GetConnection();
            using var cmd = new SqlCommand("SELECT classroomID, classroomName FROM tbClassroom WHERE departmentID = @departmentID", conn);
            cmd.Parameters.AddWithValue("@departmentID", departmentID);

            using var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                // Add "All" option
                DataRow allRow = dt.NewRow();
                allRow["classroomID"] = 0;
                allRow["classroomName"] = "All";
                dt.Rows.InsertAt(allRow, 0);

                comboclassroom.DataSource = dt;
                comboclassroom.DisplayMember = "classroomName";
                comboclassroom.ValueMember = "classroomID";
                comboclassroom.Enabled = true;
                comboclassroom.SelectedIndex = 0;
            }
            else
            {
                comboclassroom.DataSource = null;
                comboclassroom.Items.Clear();
                comboclassroom.Enabled = false;
            }

            _isUpdatingControls = false;
        }

        private void LoadGenerations()
        {
            _isUpdatingControls = true;

            using var conn = HandleConnection.GetConnection();
            using var cmd = new SqlCommand("SELECT DISTINCT generation FROM tbStudent ORDER BY generation DESC", conn);

            var dt = new DataTable();
            using var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            var generations = new System.Collections.Generic.List<string> { "All" };
            foreach (DataRow row in dt.Rows)
            {
                generations.Add(row["generation"].ToString());
            }

            combogeneration.DataSource = generations;

            _isUpdatingControls = false;
        }

        private int GetComboBoxSelectedValueAsInt(ComboBox comboBox)
        {
            if (comboBox.SelectedValue == null)
                return 0;

            if (comboBox.SelectedValue is int val)
                return val;

            if (int.TryParse(comboBox.SelectedValue.ToString(), out int result))
                return result;

            return 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Load subjectName-to-subjectID mapping
                Dictionary<string, int> subjectNameToID = new Dictionary<string, int>();
                using (var conn = HandleConnection.GetConnection())
                {
                    if (conn == null)
                    {
                        MessageBox.Show("Cannot connect to database.");
                        return;
                    }

                    using (var cmd = new SqlCommand("SELECT subjectName, subjectID FROM tbSubject", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string subjectName = reader["subjectName"].ToString();
                            int subjectID = Convert.ToInt32(reader["subjectID"]);
                            subjectNameToID[subjectName] = subjectID;
                        }
                    }
                }

                // 2. Prepare DataTable matching ScoreTableType
                DataTable dtScores = new DataTable();
                dtScores.Columns.Add("resultID", typeof(int));
                dtScores.Columns.Add("score", typeof(decimal));
                dtScores.Columns.Add("created_at", typeof(DateTime));
                dtScores.Columns.Add("semester", typeof(byte));
                dtScores.Columns.Add("studentNameEN", typeof(string));
                dtScores.Columns.Add("studentNameKH", typeof(string));
                dtScores.Columns.Add("subjectName", typeof(string));
                dtScores.Columns.Add("studentID", typeof(string));
                dtScores.Columns.Add("subjectID", typeof(int));

                // 3. Columns to skip
                HashSet<string> nonSubjectColumns = new HashSet<string>
        {
            "resultID", "studentNameEN", "studentNameKH", "studentID", "created_at", "semester"
        };

                // 4. Loop through DataGridView rows
                using (var conn2 = HandleConnection.GetConnection())
                {
                    if (conn2 == null)
                    {
                        MessageBox.Show("Cannot connect to database.");
                        return;
                    }

                    foreach (DataGridViewRow row in dataOne.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string studentNameEN = row.Cells["studentNameEN"].Value?.ToString() ?? "";
                        string studentNameKH = row.Cells["studentNameKH"].Value?.ToString() ?? "";
                        string studentID = row.Cells["studentID"].Value?.ToString() ?? "";

                        // 🔄 Get 'created_at' from cell or ComboBox
                        DateTime createdAt;
                        if (dataOne.Columns.Contains("created_at") && row.Cells["created_at"].Value != null &&
                            DateTime.TryParse(row.Cells["created_at"].Value.ToString(), out DateTime parsedDate))
                        {
                            createdAt = parsedDate;
                        }
                        else
                        {
                            int createdYear = DateTime.Now.Year;
                            if (comboCreateAt.SelectedItem != null && comboCreateAt.SelectedItem.ToString() != "All" &&
                                int.TryParse(comboCreateAt.SelectedItem.ToString(), out int year))
                                createdYear = year;

                            createdAt = new DateTime(createdYear, DateTime.Now.Month, DateTime.Now.Day);
                        }

                        // 🔄 Get 'semester' from cell or ComboBox
                        byte semester = 1;
                        if (dataOne.Columns.Contains("semester") && row.Cells["semester"].Value != null &&
                            byte.TryParse(row.Cells["semester"].Value.ToString(), out byte parsedSem))
                        {
                            semester = parsedSem;
                        }
                        else if (combosemester.SelectedItem != null && combosemester.SelectedItem.ToString() != "All" &&
                                 byte.TryParse(combosemester.SelectedItem.ToString(), out byte comboSem))
                        {
                            semester = comboSem;
                        }

                        foreach (DataGridViewColumn col in dataOne.Columns)
                        {
                            string colName = col.Name;
                            if (nonSubjectColumns.Contains(colName)) continue;
                            if (!subjectNameToID.ContainsKey(colName)) continue;

                            decimal score = 0;
                            object val = row.Cells[colName].Value;
                            if (val != null && val != DBNull.Value)
                                if (decimal.TryParse(val.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsedScore))
                                {
                                    if (parsedScore >= 0 && parsedScore <= 999.99m)
                                        score = parsedScore;
                                    else
                                        continue; // skip invalid score
                                }
                                else
                                {
                                    continue; // skip if not a number
                                }

                            int subjectID = subjectNameToID[colName];

                            // 🔍 Lookup resultID
                            int? resultID = null;
                            using (var lookupCmd = new SqlCommand(@"
                        SELECT resultID FROM tbResult 
                        WHERE studentID = @studentID 
                        AND subjectID = @subjectID 
                        AND semester = @semester 
                        AND YEAR(created_at) = @year", conn2))
                            {
                                lookupCmd.Parameters.AddWithValue("@studentID", studentID);
                                lookupCmd.Parameters.AddWithValue("@subjectID", subjectID);
                                lookupCmd.Parameters.AddWithValue("@semester", semester);
                                lookupCmd.Parameters.AddWithValue("@year", createdAt.Year);
                                var res = lookupCmd.ExecuteScalar();
                                if (res != null && res != DBNull.Value)
                                    resultID = Convert.ToInt32(res);
                            }

                            // ➕ Add row to DataTable
                            DataRow dr = dtScores.NewRow();
                            dr["resultID"] = resultID.HasValue ? (object)resultID.Value : DBNull.Value;
                            dr["score"] = score;
                            dr["created_at"] = createdAt;
                            dr["semester"] = semester;
                            dr["studentNameEN"] = studentNameEN;
                            dr["studentNameKH"] = studentNameKH;
                            dr["subjectName"] = colName;
                            dr["studentID"] = studentID;
                            dr["subjectID"] = subjectID;

                            dtScores.Rows.Add(dr);
                        }
                    }

                    if (dtScores.Rows.Count == 0)
                    {
                        MessageBox.Show("No scores to save!");
                        return;
                    }

                    // 5. Execute stored procedure
                    using (var cmd2 = new SqlCommand("sp_InsertOrUpdateStudentScoresBatch", conn2)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        var param = cmd2.Parameters.AddWithValue("@Scores", dtScores);
                        param.SqlDbType = SqlDbType.Structured;
                        param.TypeName = "dbo.ScoreTableType";

                        int rowsAffected = cmd2.ExecuteNonQuery();
                        MessageBox.Show($"Scores saved successfully! Rows affected: {rowsAffected}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save scores: " + ex.Message);
            }
        }


    }
}
