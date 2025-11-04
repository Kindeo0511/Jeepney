using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class UserForm : Form
    {
        private Guna2ShadowForm shadowForm;
        private bool isEdit = false;
        private int selectedUserID;

        public UserForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
        }

        public UserForm(bool isEdit)
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
            this.isEdit = isEdit;
            lbl_title.Text = " EDIT USER";
            btn_add.Visible = false;
            btn_edit.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadUserData(int userID, string username, string password, string email, string phone, string address, string position)
        {
            selectedUserID = userID; // ✅ store for update
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtEmailaddress.Text = email;
            txtPhoneNumber.Text = phone;
            txtAddress.Text = address;
            cmbPosition.Text = position;
        }


        // 🔹 VALIDATION METHOD (used by both Add & Edit)
        private bool ValidateInputs()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string email = txtEmailaddress.Text.Trim();
            string address = txtAddress.Text.Trim();
            string position = cmbPosition.Text.Trim();

            // Username
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (username.Length < 4)
            {
                MessageBox.Show("Username should be at least 4 characters long.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Password
            if (password.Contains(" "))
            {
                MessageBox.Show("Password should not contain spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Password should be a minimum of 8 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Phone Number Validation
            if (phone.Contains(" "))
            {
                MessageBox.Show("Phone number should not contain spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Must start with '09' and have exactly 11 digits
            if (!Regex.IsMatch(phone, @"^09\d{9}$"))
            {
                MessageBox.Show("Phone number must start with '09' and contain exactly 11 digits.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            // Email Address
            if (email.Contains(" "))
            {
                MessageBox.Show("Email address should not contain spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email address should be in a valid format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Position
            if (string.IsNullOrWhiteSpace(position))
            {
                MessageBox.Show("Please select a position.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Address
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address should not contain only spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (address.Length < 5)
            {
                MessageBox.Show("Address should be descriptive and at least 5 characters long.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // ✅ Passed all validation
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmailaddress.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string position = cmbPosition.Text.Trim();

            try
            {
                string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"UPDATE user SET 
                        UserName = @UserName,
                        Password = @Password,
                        EmailAddress = @EmailAddress,
                        PhoneNumber = @PhoneNumber,
                        Address = @Address,
                        Role = @Role
                        WHERE UserID = @UserID";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@EmailAddress", email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Role", position);
                        cmd.Parameters.AddWithValue("@UserID", selectedUserID);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            // Editing a user
                            AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Edit", "UserForm",
                                $"Updated user '{txtUsername.Text}' with role '{cmbPosition.Text}'");

                            MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No user found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string email = txtEmailaddress.Text.Trim();
            string address = txtAddress.Text.Trim();
            string position = cmbPosition.Text.Trim();

            try
            {
                string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Check duplicate username
                    string checkQuery = "SELECT COUNT(*) FROM user WHERE UserName = @UserName";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@UserName", username);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose another one.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new user
                    string insertQuery = @"INSERT INTO user 
                        (UserName, Password, PhoneNumber, EmailAddress, Address, Role) 
                        VALUES (@UserName, @Password, @PhoneNumber, @EmailAddress, @Address, @Position)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                        cmd.Parameters.AddWithValue("@EmailAddress", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Role", position);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            // Adding a user
                            AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Add", "UserForm",
                                $"Added new user '{txtUsername.Text}' with role '{cmbPosition.Text}'");
                            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // ✅ Clear inputs
                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtPhoneNumber.Clear();
                            txtEmailaddress.Clear();
                            txtAddress.Clear();
                            cmbPosition.SelectedIndex = -1;

                            // ✅ Auto refresh parent DataGridView
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
