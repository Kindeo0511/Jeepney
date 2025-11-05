using Jeep.CustomerView;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;
namespace Jeep.View
{
    public partial class LoginForm : Form
    {
        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ForgotPasswordForm();
            form.Show();
            this.Hide(); 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
          
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email address should be in a valid format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

        
            if (password.Contains(" "))
            {
                MessageBox.Show("Password should not contain spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password should be a minimum of 8 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }


            using (var con = new MySqlConnection("server=localhost;user id=root;password=;database=jeepney;"))
            {
                con.Open();
                string query = "SELECT Username, Role, Password FROM user WHERE EmailAddress = @EmailAddress";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmailAddress", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string dbPassword = reader["Password"].ToString();
                            string username = reader["Username"].ToString();
                            string role = reader["Role"].ToString();

                            if (password == dbPassword)
                            {
                                // Successful login
                                AuditHelper.Log(username, role, "Login", "LoginForm", "User logged in successfully.");

                                // Save current user
                                CurrentUser.Username = username;
                                CurrentUser.Role = role;

                                // Open MainForm
                                MainForm main = new MainForm();
                                main.Show();

                                this.Hide(); // hide login form
                            }
                            else
                            {
                                // Failed login
                                AuditHelper.Log(email, "Unknown", "LoginFailed", "LoginForm", "Incorrect password attempt.");
                                MessageBox.Show("Incorrect password.");
                            }
                        }
                        else
                        {
                            // User not found
                            AuditHelper.Log(email, "Unknown", "LoginFailed", "LoginForm", "Email not found.");
                            MessageBox.Show("User not found.");
                        }
                    }
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                // Show actual password
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password (show dots)
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
  