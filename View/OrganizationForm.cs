using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Jeep.View
{
    public partial class OrganizationForm : Form
    {
        private Guna2ShadowForm shadowForm;
        private bool isEdit = false;
        private int selectedID;
        public OrganizationForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
        }
        public OrganizationForm(bool isEdit)
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
            this.isEdit = isEdit;

            if (isEdit == true)
            {
                lbl_title.Text = "EDIT ORGANIZATIONS";
                btn_add.Visible = false;
                btn_edit.Visible = true;
            }

        }
        public void LoadOrganizationData(int id, string name, string contact, string address)
        {
            selectedID = id;
            txtOrganizartion.Text = name;
            txtContactNumber.Text = contact;
            txtAddress.Text = address;
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidateInputs()
        {
            string organizationName = txtOrganizartion.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            string address = txtAddress.Text.Trim();

            // 🔹 Validate Organization Name
            if (string.IsNullOrEmpty(organizationName))
            {
                MessageBox.Show("Organization name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(organizationName, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Organization name should contain only letters, numbers, and spaces.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Validate Contact Number
            if (string.IsNullOrEmpty(contactNumber))
            {
                MessageBox.Show("Contact number is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(contactNumber, @"^09\d{9}$"))
            {
                MessageBox.Show("Contact number should contain only digits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Validate Address
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (address.Length < 5)
            {
                MessageBox.Show("Address should be at least 5 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
                try
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "UPDATE organization SET OrganizationName=@name, ContactNumber=@contact, Address=@address WHERE OrganizationID=@id";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@name", txtOrganizartion.Text);
                            cmd.Parameters.AddWithValue("@contact", txtContactNumber.Text);
                            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                            cmd.Parameters.AddWithValue("@id", selectedID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    // ✅ Audit Trail
                    AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Edit", "Organization",
                        $"Updated organization '{txtOrganizartion.Text}' with contact '{txtContactNumber.Text}'");
                    MessageBox.Show("Organization updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating organization: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
                try
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "INSERT INTO organization (OrganizationName, ContactNumber, Address) VALUES (@name, @contact, @address)";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@name", txtOrganizartion.Text);
                            cmd.Parameters.AddWithValue("@contact", txtContactNumber.Text);
                            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    // ✅ Audit Trail
                    AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Add", "Organization",
                        $"Added organization '{txtOrganizartion.Text}' with contact '{txtContactNumber.Text}'");

                    MessageBox.Show("Organization added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding organization: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OrganizationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
