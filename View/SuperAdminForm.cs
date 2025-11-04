using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class SuperAdminForm : Form
    {  
        
        // IP of phone running SMS Gateway
        private string phoneIP = "192.168.43.1"; // change to your actual phone IP
        private int port = 8080;

        public SuperAdminForm()
        {
            InitializeComponent();
        }

        private void btn_send_otp_Click(object sender, EventArgs e)
        {
            var form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}