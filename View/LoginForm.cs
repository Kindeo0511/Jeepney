using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var form = new MainForm();
            form.Show();
            this.Close();
        }
    }
}
