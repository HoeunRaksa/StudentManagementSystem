using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using StudentManagementSystem;
using StudentManagementSysytem;

namespace StudentManagementSystem
{
    public partial class Payment : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        public Payment()
        {
            InitializeComponent();
            LoadPayments();
            LoadStaffIDs();
            LoadStudentIDs();
            LoadPaymentTypes();
            LoadStatusOptions();
            LoadSearchStudentIDs();

            // Wire up search ComboBox event
            cmbSearchStudentID.SelectedIndexChanged += cmbSearchStudentID_SelectedIndexChanged;
        }

        private void LoadPayments()
        {
            try
            {
                using (SqlConnection conn = HandleConnection.GetConnection())
                {
                    if (conn != null)
                    {
                        string query = "SELECT * FROM tbPayment";
                        cmd = new SqlCommand(query, conn);
                        da = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
        }

        private void LoadStaffIDs()
        {
            try
            {
                using (SqlConnection conn = HandleConnection.GetConnection())
                {
                    if (conn != null)
                    {
                        string query = "SELECT StaffID FROM tbStaff";
                        cmd = new SqlCommand(query, conn);
                        da = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);
                        cmbStaffID.DataSource = dt;
                        cmbStaffID.DisplayMember = "StaffID";
                        cmbStaffID.ValueMember = "StaffID";
                        cmbStaffID.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff IDs: " + ex.Message);
            }
        }

        private void LoadStudentIDs()
        {
            try
            {
                using (SqlConnection conn = HandleConnection.GetConnection())
                {
                    if (conn != null)
                    {
                        string query = "SELECT StudentID FROM tbStudent";
                        cmd = new SqlCommand(query, conn);
                        da = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);
                        cmbStudentID.DataSource = dt;
                        cmbStudentID.DisplayMember = "StudentID";
                        cmbStudentID.ValueMember = "StudentID";
                        cmbStudentID.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student IDs: " + ex.Message);
            }
        }

        private void LoadSearchStudentIDs()
        {
            try
            {
                using (SqlConnection conn = HandleConnection.GetConnection())
                {
                    if (conn != null)
                    {
                        string query = "SELECT StudentID FROM tbStudent";
                        cmd = new SqlCommand(query, conn);
                        da = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);

                        cmbSearchStudentID.DataSource = dt;
                        cmbSearchStudentID.DisplayMember = "StudentID";
                        cmbSearchStudentID.ValueMember = "StudentID";
                        cmbSearchStudentID.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading search student IDs: " + ex.Message);
            }
        }

        private void LoadPaymentTypes()
        {
            txtPaymentType.Items.AddRange(new string[] { "Tuition", "Library Fine", "Activity Fee", "Other" });
            txtPaymentType.SelectedIndex = -1;
        }

        private void LoadStatusOptions()
        {
            txtStatus.Items.AddRange(new string[] { "Pending", "Completed", "Failed", "Refunded" });
            txtStatus.SelectedIndex = -1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    using (SqlConnection conn = HandleConnection.GetConnection())
                    {
                        if (conn != null)
                        {
                            string query = @"INSERT INTO tbPayment (StaffID, StudentID, Amount, PaymentDate, PaymentType, Status) 
                                             VALUES (@StaffID, @StudentID, @Amount, @PaymentDate, @PaymentType, @Status)";

                            cmd = new SqlCommand(query, conn);

                            cmd.Parameters.AddWithValue("@StaffID", cmbStaffID.SelectedValue);
                            cmd.Parameters.AddWithValue("@StudentID", cmbStudentID.SelectedValue);
                            cmd.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text));
                            cmd.Parameters.AddWithValue("@PaymentDate", DateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@PaymentType", txtPaymentType.Text);
                            cmd.Parameters.AddWithValue("@Status", txtStatus.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Payment record inserted successfully!");
                            ClearFields();
                            LoadPayments();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting payment: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaymentID.Text))
            {
                MessageBox.Show("Please select a payment to update.");
                return;
            }

            try
            {
                using (SqlConnection conn = HandleConnection.GetConnection())
                {
                    if (conn != null)
                    {
                        List<string> updateFields = new List<string>();
                        cmd = new SqlCommand();
                        cmd.Connection = conn;

                        if (cmbStaffID.SelectedIndex != -1)
                        {
                            updateFields.Add("StaffID = @StaffID");
                            cmd.Parameters.AddWithValue("@StaffID", cmbStaffID.SelectedValue);
                        }

                        if (cmbStudentID.SelectedIndex != -1)
                        {
                            updateFields.Add("StudentID = @StudentID");
                            cmd.Parameters.AddWithValue("@StudentID", cmbStudentID.SelectedValue);
                        }

                        if (!string.IsNullOrWhiteSpace(txtAmount.Text))
                        {
                            if (decimal.TryParse(txtAmount.Text, out decimal amount))
                            {
                                updateFields.Add("Amount = @Amount");
                                cmd.Parameters.AddWithValue("@Amount", amount);
                            }
                            else
                            {
                                MessageBox.Show("Invalid amount format.");
                                return;
                            }
                        }

                        if (DateTimePicker1.ShowCheckBox && DateTimePicker1.Checked)
                        {
                            updateFields.Add("PaymentDate = @PaymentDate");
                            cmd.Parameters.AddWithValue("@PaymentDate", DateTimePicker1.Value);
                        }

                        if (!string.IsNullOrWhiteSpace(txtPaymentType.Text))
                        {
                            updateFields.Add("PaymentType = @PaymentType");
                            cmd.Parameters.AddWithValue("@PaymentType", txtPaymentType.Text);
                        }

                        if (!string.IsNullOrWhiteSpace(txtStatus.Text))
                        {
                            updateFields.Add("Status = @Status");
                            cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                        }

                        if (updateFields.Count == 0)
                        {
                            MessageBox.Show("No fields selected to update.");
                            return;
                        }

                        string query = $"UPDATE tbPayment SET {string.Join(", ", updateFields)} WHERE PaymentID = @PaymentID";
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@PaymentID", txtPaymentID.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment record updated successfully!");
                            ClearFields();
                            LoadPayments();
                        }
                        else
                        {
                            MessageBox.Show("No payment record found with the specified ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payment: " + ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadPayments();
            DateTimePicker1.Value = DateTime.Now;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtPaymentID.Text = row.Cells["PaymentID"].Value.ToString();
                cmbStaffID.SelectedValue = row.Cells["StaffID"].Value.ToString();
                cmbStudentID.SelectedValue = row.Cells["StudentID"].Value.ToString();
                txtAmount.Text = row.Cells["Amount"].Value.ToString();
                DateTimePicker1.Value = Convert.ToDateTime(row.Cells["PaymentDate"].Value);
                DateTimePicker1.Checked = true;
                txtPaymentType.Text = row.Cells["PaymentType"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void cmbSearchStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchStudentID.SelectedIndex != -1)
            {
                FilterPaymentsByStudentID(cmbSearchStudentID.SelectedValue.ToString());
            }
        }

        private void FilterPaymentsByStudentID(string studentID)
        {
            try
            {
                using (SqlConnection conn = HandleConnection.GetConnection())
                {
                    if (conn != null)
                    {
                        string query = "SELECT * FROM tbPayment WHERE StudentID = @StudentID";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        da = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering payments: " + ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            if (cmbStaffID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Staff ID");
                return false;
            }

            if (cmbStudentID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Student ID");
                return false;
            }

            if (string.IsNullOrEmpty(txtAmount.Text) || !decimal.TryParse(txtAmount.Text, out _))
            {
                MessageBox.Show("Please enter a valid amount");
                return false;
            }

            if (string.IsNullOrEmpty(txtPaymentType.Text))
            {
                MessageBox.Show("Please select a payment type");
                return false;
            }

            if (string.IsNullOrEmpty(txtStatus.Text))
            {
                MessageBox.Show("Please select a status");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txtPaymentID.Clear();
            cmbStaffID.SelectedIndex = -1;
            cmbStudentID.SelectedIndex = -1;
            txtAmount.Clear();
            DateTimePicker1.Value = DateTime.Now;
            DateTimePicker1.Checked = false;
            txtPaymentType.SelectedIndex = -1;
            txtStatus.SelectedIndex = -1;
            cmbSearchStudentID.SelectedIndex = -1;
        }

        private string GeneratePaymentID()
        {
            return "PAY-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}
