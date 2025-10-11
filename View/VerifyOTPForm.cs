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
    public partial class VerifyOTPForm : Form
    {
        bool isForgotPassword = false;
        public VerifyOTPForm()
        {
            InitializeComponent();
        }
        public VerifyOTPForm(bool forgotpassword)
        {
            InitializeComponent();
            this.isForgotPassword = forgotpassword;
        }

        private void btn_send_otp_Click(object sender, EventArgs e)
        {
            if (isForgotPassword == true)
            {
                var form = new LoginForm();
                form.Show();
                this.Close();
            }
            else 
            {
                var form = new LoginForm();
                form.Show();
                this.Close();
            }
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
