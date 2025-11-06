using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace Jeep.View
{
    public partial class OperatorForm : Form
    {
        private Guna2ShadowForm shadowForm;
        private bool isEdit = false;
        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
        private int? operatorID; // null = add mode, not null = edit mode
        public OperatorForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
        }
        public OperatorForm(int? operatorID = null, int? organizationID = null, string operatorName = null,
                    string noOfVehicle = null, string franchiseNo = null, string contact = null, string address = null)
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);

            // Load data first
            LoadOrganizations();

            this.operatorID = operatorID;

            if (operatorID.HasValue)
            {

                this.lbl_title.Text = "Edit Operator";
                btn_edit.Visible = true;
                btn_add.Visible = false;

                txtOperatorName.Text = operatorName;
                txtNoVecicle.Text = noOfVehicle;
                txtNoFranchise.Text = franchiseNo;
                txtContactNumber.Text = contact;
                txtAddress.Text = address;

                // ✅ Ensure cmbOrganization is ready before assigning
                if (organizationID.HasValue)
                {
                    cmbOrganization.SelectedValue = organizationID.Value;
                   
                }
            }
            else
            {
                this.Text = "Add Operator";
                btn_add.Text = "Save";
            }
        }


        private void LoadOrganizations()
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=jeepney"))
            {
                con.Open();
                string query = "SELECT OrganizationID, OrganizationName FROM organization";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbOrganization.DataSource = dt;
                cmbOrganization.DisplayMember = "OrganizationName";
                cmbOrganization.ValueMember = "OrganizationID";

                cmbOrganization.SelectedIndex = -1;
                cmbOrganization.Text = "Select Organization";

                // ✅ Debug check
                Console.WriteLine("Loaded organizations:");
                foreach (DataRow row in dt.Rows)
                    Console.WriteLine($"{row["OrganizationID"]} - {row["OrganizationName"]}");
            }
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateInputs()
        {
            // 🔹 Organization
            if (cmbOrganization.SelectedIndex == -1)
            {
                MessageBox.Show("Organization name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(cmbOrganization.Text.Trim(), @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Organization name should contain only letters, numbers, and spaces.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Operator Name
            if (string.IsNullOrWhiteSpace(txtOperatorName.Text))
            {
                MessageBox.Show("Operator’s name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtOperatorName.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Operator’s name should contain only letters and spaces.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Number of Vehicles
            if (string.IsNullOrWhiteSpace(txtNoVecicle.Text))
            {
                MessageBox.Show("Number of vehicles is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNoVecicle.Text.Trim(), @"^\d+$"))
            {
                MessageBox.Show("Number of vehicles should contain only digits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 LTFRB Franchise No.
            if (string.IsNullOrWhiteSpace(txtNoFranchise.Text))
            {
                MessageBox.Show("LTFRB Franchise Number is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNoFranchise.Text.Trim(), @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("LTFRB Franchise Number should contain only letters and numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Contact Number Validation
            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                MessageBox.Show("Contact number is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if it starts with 09 and has 11 digits total
            string contact = txtContactNumber.Text.Trim();
            if (!System.Text.RegularExpressions.Regex.IsMatch(contact, @"^09\d{9}$"))
            {
                MessageBox.Show("Contact number must start with '09' and contain exactly 11 digits (e.g., 09123456789).",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            // 🔹 Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtAddress.Text.Trim().Length < 5)
            {
                MessageBox.Show("Address should be at least 5 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int organizationID = Convert.ToInt32(cmbOrganization.SelectedValue);
            string operatorName = txtOperatorName.Text.Trim();
            int noOfVehicle = Convert.ToInt32(txtNoVecicle.Text.Trim());
            string franchiseNo = txtNoFranchise.Text.Trim();
            string contact = txtContactNumber.Text.Trim();
            string address = txtAddress.Text.Trim();

            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"UPDATE operator 
                         SET OrganizationID=@OrganizationID, 
                             OperatorName=@OperatorName, 
                             NoOfVehicle=@NoOfVehicle, 
                             FranchiseNo=@FranchiseNo, 
                             ContactNumber=@ContactNumber, 
                             Address=@Address 
                         WHERE OperatorID=@OperatorID";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@OrganizationID", organizationID);
                    cmd.Parameters.AddWithValue("@OperatorName", operatorName);
                    cmd.Parameters.AddWithValue("@NoOfVehicle", noOfVehicle);
                    cmd.Parameters.AddWithValue("@FranchiseNo", franchiseNo);
                    cmd.Parameters.AddWithValue("@ContactNumber", contact);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@OperatorID", operatorID);

                    try
                    {
                        cmd.ExecuteNonQuery();

                        // ✅ Audit log for Edit
                        AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Edit", "Operators",
                            $"Updated operator '{operatorName}' under organization '{cmbOrganization}' with {noOfVehicle} vehicle(s)");
                        MessageBox.Show("Operator updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating operator: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int organizationID = Convert.ToInt32(cmbOrganization.SelectedValue);
            string operatorName = txtOperatorName.Text.Trim();
            int noOfVehicle = Convert.ToInt32(txtNoVecicle.Text.Trim());
            string franchiseNo = txtNoFranchise.Text.Trim();
            string contact = txtContactNumber.Text.Trim();
            string address = txtAddress.Text.Trim();

            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"INSERT INTO operator 
                        (OrganizationID, OperatorName, NoOfVehicle, FranchiseNo, ContactNumber, Address)
                        VALUES (@OrganizationID, @OperatorName, @NoOfVehicle, @FranchiseNo, @ContactNumber, @Address)";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@OrganizationID", organizationID);
                    cmd.Parameters.AddWithValue("@OperatorName", operatorName);
                    cmd.Parameters.AddWithValue("@NoOfVehicle", noOfVehicle);
                    cmd.Parameters.AddWithValue("@FranchiseNo", franchiseNo);
                    cmd.Parameters.AddWithValue("@ContactNumber", contact);
                    cmd.Parameters.AddWithValue("@Address", address);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        // ✅ Audit log for Add
                        AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Add", "Operators",
                            $"Added operator '{operatorName}' under organization '{cmbOrganization}' with {noOfVehicle} vehicle(s)");
                        MessageBox.Show("Operator added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding operator: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                }

        private void OperatorForm_Load(object sender, EventArgs e)
        {
            LoadOrganizations(); 
        }
    }
}
