using Google.Protobuf.WellKnownTypes;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace Jeep.View
{
    public partial class RouteForm : Form
    {
        private Guna2ShadowForm shadowForm;
        private bool isEdit = false;
        private List<string> stopovers = new List<string>();
        private int routeID;
        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
        public RouteForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
            LoadOrganizations();
        }

        private void LoadOrganizations()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT OrganizationID, OrganizationName FROM organization";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                cmbOrganization.DataSource = dt;
                cmbOrganization.DisplayMember = "OrganizationName";
                cmbOrganization.ValueMember = "OrganizationID";
                cmbOrganization.SelectedIndex = -1;
            }
        }

        public RouteForm(int routeID, bool isEdit)
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
            this.isEdit = isEdit;
            this.routeID = routeID;
            LoadOrganizations();

            if (isEdit)
            {
                btn_add.Visible = false;
                btn_edit.Visible = true;
                LoadRouteData(routeID);
            }
        }
        private void LoadRouteData(int routeID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                // Load route info
                string routeQuery = "SELECT * FROM route WHERE RouteID = @RouteID";
                MySqlCommand cmd = new MySqlCommand(routeQuery, con);
                cmd.Parameters.AddWithValue("@RouteID", routeID);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cmbOrganization.SelectedValue = reader["OrganizationID"];
                        txtFrom.Text = reader["RouteFrom"].ToString();
                        txtTo.Text = reader["RouteTo"].ToString();
                        timeStart.Value = DateTime.Today.Add((TimeSpan)reader["TimeStart"]);
                        timeEnd.Value = DateTime.Today.Add((TimeSpan)reader["TimeEnd"]);
                    }
                }

                // Load stopovers
                string stopQuery = "SELECT StopName FROM stopover WHERE RouteID = @RouteID";
                MySqlCommand stopCmd = new MySqlCommand(stopQuery, con);
                stopCmd.Parameters.AddWithValue("@RouteID", routeID);
                using (var reader = stopCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string stop = reader["StopName"].ToString();
                        stopovers.Add(stop);
                        lstStopovers.Items.Add(stop);
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RouteForm_Load(object sender, EventArgs e)
        {

            timeStart.ShowUpDown = true;
            timeEnd.ShowUpDown = true;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string stop = txtStopOver.Text.Trim();
            if (string.IsNullOrEmpty(stop))
            {
                MessageBox.Show("Please enter a stopover name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            stopovers.Add(stop);
            lstStopovers.Items.Add(stop);
            txtStopOver.Clear();
        }

        private void btnRemoveStopover_Click(object sender, EventArgs e)
        {
            if (lstStopovers.SelectedItem != null)
            {
                stopovers.Remove(lstStopovers.SelectedItem.ToString());
                lstStopovers.Items.Remove(lstStopovers.SelectedItem);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string routeQuery = @"INSERT INTO route 
                    (OrganizationID, RouteFrom, RouteTo, TimeStart, TimeEnd)
                    VALUES (@OrgID, @From, @To, @Start, @End)";
                MySqlCommand cmd = new MySqlCommand(routeQuery, con);
                cmd.Parameters.AddWithValue("@OrgID", cmbOrganization.SelectedValue);
                cmd.Parameters.AddWithValue("@From", txtFrom.Text.Trim());
                cmd.Parameters.AddWithValue("@To", txtTo.Text.Trim());
                cmd.Parameters.AddWithValue("@Start", timeStart.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@End", timeEnd.Value.TimeOfDay);
                cmd.ExecuteNonQuery();

                int newRouteID = (int)cmd.LastInsertedId;

                foreach (string stop in stopovers)
                {
                    string stopQuery = "INSERT INTO stopover (RouteID, StopName) VALUES (@RouteID, @StopName)";
                    MySqlCommand stopCmd = new MySqlCommand(stopQuery, con);
                    stopCmd.Parameters.AddWithValue("@RouteID", newRouteID);
                    stopCmd.Parameters.AddWithValue("@StopName", stop);
                    stopCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Route added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string updateQuery = @"UPDATE route 
                    SET OrganizationID=@OrgID, RouteFrom=@From, RouteTo=@To, 
                        TimeStart=@Start, TimeEnd=@End
                    WHERE RouteID=@RouteID";
                MySqlCommand cmd = new MySqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@OrgID", cmbOrganization.SelectedValue);
                cmd.Parameters.AddWithValue("@From", txtFrom.Text.Trim());
                cmd.Parameters.AddWithValue("@To", txtTo.Text.Trim());
                cmd.Parameters.AddWithValue("@Start", timeStart.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@End", timeEnd.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@RouteID", routeID);
                cmd.ExecuteNonQuery();

               
                MySqlCommand delCmd = new MySqlCommand("DELETE FROM stopover WHERE RouteID=@RouteID", con);
                delCmd.Parameters.AddWithValue("@RouteID", routeID);
                delCmd.ExecuteNonQuery();

                foreach (string stop in stopovers)
                {
                    string stopQuery = "INSERT INTO stopover (RouteID, StopName) VALUES (@RouteID, @StopName)";
                    MySqlCommand stopCmd = new MySqlCommand(stopQuery, con);
                    stopCmd.Parameters.AddWithValue("@RouteID", routeID);
                    stopCmd.Parameters.AddWithValue("@StopName", stop);
                    stopCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Route updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidateInputs()
        {
         
            if (string.IsNullOrWhiteSpace(txtFrom.Text))
            {
                MessageBox.Show("Starting point is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtFrom.Text, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Starting point should contain only letters, numbers, and spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            if (string.IsNullOrWhiteSpace(txtTo.Text))
            {
                MessageBox.Show("Destination is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTo.Text, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Destination should contain only letters, numbers, and spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            if (lstStopovers.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one stopover before saving.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

    
            if (!string.IsNullOrWhiteSpace(txtStopOver.Text) && lstStopovers.Items.Count > 0)
            {
                MessageBox.Show("Please add or clear the stopover text before saving.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

         
            if (!string.IsNullOrWhiteSpace(txtStopOver.Text) &&
                !System.Text.RegularExpressions.Regex.IsMatch(txtStopOver.Text, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Stopover should contain only letters, numbers, and spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

         
            TimeSpan startTime = timeStart.Value.TimeOfDay;
            TimeSpan endTime = timeEnd.Value.TimeOfDay;

            if (startTime >= endTime)
            {
                MessageBox.Show("Start time must be earlier than end time.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

          
            if (cmbOrganization.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an organization.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(cmbOrganization.Text, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Organization name should contain only letters, numbers, and spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


    }
}

