using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

using System.Drawing;

using MySql.Data.MySqlClient;
namespace Jeep.View
{
    public partial class BaranggayForm : Form
    {
        private Guna2ShadowForm shadowForm;
        bool isEdit = false;
      
        private int selectedBarangayID;

        public BaranggayForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
        }
        public BaranggayForm(bool isEdit)
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
            this.isEdit = isEdit;
            btn_add.Visible = false;
            btn_edit.Visible = true;
            lbl_title.Text = "EDIT BARANGAY";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadBarangayData(int barangayID, string barangayName)
        {
            selectedBarangayID = barangayID;
            txtBarangayName.Text = barangayName;
        }

        // 🔹 Shared validation function (used for Add & Edit)
        private bool ValidateBarangay()
        {
            string barangayName = txtBarangayName.Text.Trim();

            if (string.IsNullOrWhiteSpace(barangayName))
            {
                MessageBox.Show("Barangay name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (barangayName.Length < 3)
            {
                MessageBox.Show("Barangay name should be at least 3 characters long.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateBarangay()) return; // ✅ validation check

            string barangayName = txtBarangayName.Text.Trim();
            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Check if barangay already exists
                    string checkQuery = "SELECT COUNT(*) FROM barangay WHERE BarangayName = @BarangayName";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@BarangayName", barangayName);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (exists > 0)
                        {
                            MessageBox.Show("Barangay already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert
                    string query = "INSERT INTO barangay (BarangayName) VALUES (@BarangayName)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BarangayName", barangayName);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Barangay added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Add", "BarangayForm",
     $"Added barangay '{txtBarangayName.Text}'");

                // ✅ auto refresh parent DataGridView
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding barangay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateBarangay()) return; // ✅ validation check

            string barangayName = txtBarangayName.Text.Trim();
            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Check if another barangay with same name exists (avoid duplicates)
                    string checkQuery = "SELECT COUNT(*) FROM barangay WHERE BarangayName = @BarangayName AND BarangayID != @BarangayID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@BarangayName", barangayName);
                        checkCmd.Parameters.AddWithValue("@BarangayID", selectedBarangayID);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (exists > 0)
                        {
                            MessageBox.Show("Another barangay with the same name already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Update
                    string query = "UPDATE barangay SET BarangayName = @BarangayName WHERE BarangayID = @BarangayID";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BarangayName", barangayName);
                        cmd.Parameters.AddWithValue("@BarangayID", selectedBarangayID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Barangay updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Edit", "BarangayForm",
    $"Updated barangay '{txtBarangayName.Text}'");
                // ✅ auto refresh parent DataGridView
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating barangay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
