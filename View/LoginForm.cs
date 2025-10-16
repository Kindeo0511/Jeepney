using Jeep.CustomerView;
using System;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ForgotPasswordForm();
            form.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "customer")
            {
                var form = new SearchForm();
                form.Show();
                this.Close();
            }
            else 
            {
                var form = new MainForm();
                form.Show();
                this.Close();
            }
              
        }
    }
}
