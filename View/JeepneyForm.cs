using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Jeep.View
{
    public partial class JeepneyForm : Form
    {
        private Guna2ShadowForm shadowForm;
        private bool isEdit = false;
        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
        private int? jeepneyID;

        public JeepneyForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
          
            
        }
        private void LoadOrganizations()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT OrganizationID, OrganizationName FROM organization";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbOrganization.DataSource = dt;
                cmbOrganization.DisplayMember = "OrganizationName";
                cmbOrganization.ValueMember = "OrganizationID";
            }
        }


        public JeepneyForm(int? id = null, bool editMode = false)
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);

            jeepneyID = id;
            isEdit = editMode;
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (!jeepneyID.HasValue)
            {
                MessageBox.Show("Invalid jeepney record selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"UPDATE jeepney SET 
                                    PlateNumber = @PlateNumber,
                                    OrganizationID = @OrgID,
                                    OperatorName = @OperatorName,
                                    DriverLicensedNo = @LicensedNo,
                                    DriverFullName = @DriverName,
                                    RouteTaken = @RouteTaken
                                 WHERE JeepneyID = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PlateNumber", txtPlateNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@OrgID", cmbOrganization.SelectedValue);
                    cmd.Parameters.AddWithValue("@OperatorName", txtOperator.Text.Trim());
                    cmd.Parameters.AddWithValue("@LicensedNo", txtLicendsedNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@DriverName", txtDriverFullname.Text.Trim());
                    cmd.Parameters.AddWithValue("@RouteTaken", txtRouteTaken.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", jeepneyID.Value);

                    cmd.ExecuteNonQuery();
                }
                AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Edit", "Jeepney",
              $"Updated Jeepney '{txtPlateNumber}' operated by '{txtOperator}' driven by '{txtDriverFullname}' under '{cmbOrganization}'");
                MessageBox.Show("Jeepney details updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }

        private void JeepneyForm_Load(object sender, EventArgs e)
        {
            LoadOrganizations();

            if (isEdit && jeepneyID.HasValue)
            {
                LoadJeepneyDetails(jeepneyID.Value);
                btn_add.Visible = false;
                btn_edit.Visible = true;
            }
            else
            {
                btn_add.Visible = true;
                btn_edit.Visible = false;
            }
        }
        private void LoadJeepneyDetails(int id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT * FROM jeepney WHERE JeepneyID=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtPlateNumber.Text = reader["PlateNumber"].ToString();
                            txtOperator.Text = reader["OperatorName"].ToString();
                            txtLicendsedNumber.Text = reader["DriverLicensedNo"].ToString();
                            txtDriverFullname.Text = reader["DriverFullName"].ToString();
                            txtRouteTaken.Text = reader["RouteTaken"].ToString();
                            cmbOrganization.SelectedValue = reader["OrganizationID"];
                        }
                    }
                }
            }
        }

        private bool ValidateInputs()
        {
            // Plate Number
            if (string.IsNullOrWhiteSpace(txtPlateNumber.Text))
            {
                MessageBox.Show("Jeepney plate number is required.");
                return false;
            }
            if (!Regex.IsMatch(txtPlateNumber.Text, @"^[A-Za-z0-9\-]+$"))
            {
                MessageBox.Show("Jeepney plate number should contain only letters, numbers, and hyphens.");
                return false;
            }

            // Organization
            if (cmbOrganization.SelectedIndex == -1)
            {
                MessageBox.Show("Organization name is required.");
                return false;
            }
            if (!Regex.IsMatch(cmbOrganization.Text, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Organization name should contain only letters, numbers, and spaces.");
                return false;
            }

            // Operator
            if (string.IsNullOrWhiteSpace(txtOperator.Text))
            {
                MessageBox.Show("Operator’s name is required.");
                return false;
            }
            if (!Regex.IsMatch(txtOperator.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Operator’s name should contain only letters and spaces.");
                return false;
            }

            // Licensed Driver
            if (string.IsNullOrWhiteSpace(txtLicendsedNumber.Text))
            {
                MessageBox.Show("Driver license number is required.");
                return false;
            }
            if (!Regex.IsMatch(txtLicendsedNumber.Text, @"^[A-Za-z0-9]+$"))
            {
                MessageBox.Show("Driver license number should contain only letters and numbers.");
                return false;
            }

            // Driver Full Name (readonly)
            if (string.IsNullOrWhiteSpace(txtDriverFullname.Text))
            {
                MessageBox.Show("Driver full name should not be empty.");
                return false;
            }

            // Route Taken
            if (string.IsNullOrWhiteSpace(txtRouteTaken.Text))
            {
                MessageBox.Show("Route taken is required.");
                return false;
            }
            if (!Regex.IsMatch(txtRouteTaken.Text, @"^[A-Za-z0-9,\-\s]+$"))
            {
                MessageBox.Show("Route taken should contain only letters, numbers, commas, hyphens, and spaces.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }
        private void ClearFields()
        {
            txtPlateNumber.Clear();
            txtOperator.Clear();
            txtLicendsedNumber.Clear();
            txtDriverFullname.Clear();
            txtRouteTaken.Clear();
            cmbOrganization.SelectedIndex = -1;
        }


        private void cmbOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrganization.SelectedValue == null || cmbOrganization.SelectedValue is DataRowView)
                return;

            int organizationID = Convert.ToInt32(cmbOrganization.SelectedValue);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

              
                string getOrgNameQuery = "SELECT OrganizationName FROM organization WHERE OrganizationID = @OrgID LIMIT 1";
                string orgName = "";

                using (MySqlCommand getOrgNameCmd = new MySqlCommand(getOrgNameQuery, con))
                {
                    getOrgNameCmd.Parameters.AddWithValue("@OrgID", organizationID);
                    object result = getOrgNameCmd.ExecuteScalar();
                    if (result != null)
                        orgName = result.ToString();
                }

              
                string infoQuery = @"
            SELECT 
                o.OperatorName,
                d.LicensedNumber,
                CONCAT(d.FirstName, ' ', d.LastName) AS DriverFullName
            FROM operator o
            LEFT JOIN driver d ON d.OperatorID = o.OperatorID
            WHERE o.OrganizationID = @OrgID
            LIMIT 1;";

                using (MySqlCommand cmd = new MySqlCommand(infoQuery, con))
                {
                    cmd.Parameters.AddWithValue("@OrgID", organizationID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtOperator.Text = reader["OperatorName"]?.ToString();
                            txtLicendsedNumber.Text = reader["LicensedNumber"]?.ToString();
                            txtDriverFullname.Text = reader["DriverFullName"]?.ToString();
                        }
                        else
                        {
                            txtOperator.Clear();
                            txtLicendsedNumber.Clear();
                            txtDriverFullname.Clear();
                        }
                    }
                }

                // 🔹 Get Route Info (same org)
                string routeQuery = @"SELECT CONCAT(RouteFrom, ' - ', RouteTo) AS RouteTaken 
                              FROM route 
                              WHERE OrganizationID = @OrgID 
                              LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(routeQuery, con))
                {
                    cmd.Parameters.AddWithValue("@OrgID", organizationID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtRouteTaken.Text = reader["RouteTaken"].ToString();
                        }
                        else
                        {
                            txtRouteTaken.Clear();
                        }
                    }
                }
            }
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"INSERT INTO jeepney 
                         (PlateNumber, OrganizationID, OperatorName, DriverLicensedNo, DriverFullName, RouteTaken)
                         VALUES (@PlateNumber, @OrgID, @OperatorName, @LicensedNo, @DriverName, @RouteTaken)";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PlateNumber", txtPlateNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@OrgID", cmbOrganization.SelectedValue);
                    cmd.Parameters.AddWithValue("@OperatorName", txtOperator.Text.Trim());
                    cmd.Parameters.AddWithValue("@LicensedNo", txtLicendsedNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@DriverName", txtDriverFullname.Text.Trim());
                    cmd.Parameters.AddWithValue("@RouteTaken", txtRouteTaken.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Add", "Jeepney",
             $"Added Jeepney '{txtPlateNumber}' operated by '{txtOperator}' driven by '{txtDriverFullname}' under '{cmbOrganization}'");
                MessageBox.Show("Jeepney added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                ClearFields();
                this.Close();
            }
        }
    }
}

        
