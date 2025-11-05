using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class ChangePasswordForm : Form
    {
         
        private string email;

        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
        public ChangePasswordForm(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void btn_save_Click(object sender, System.EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter a new password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (newPassword.Contains(" "))
            {
                MessageBox.Show("Password should not contain spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (newPassword.Length < 8)
            {
                MessageBox.Show("Password should be at least 8 characters long.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            // Update password in database
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE user SET Password = @Password WHERE EmailAddress = @Email";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@Email", email);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to login form
                            var loginForm = new LoginForm();
                            loginForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangePasswordForm_Load(object sender, System.EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            var form = new LoginForm();
            form.Show();
            this.Close();
        }
    }
}
