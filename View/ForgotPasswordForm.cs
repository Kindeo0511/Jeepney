using System;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btn_send_otp_Click(object sender, EventArgs e)
        {
            bool iSForgotPassword = true;
            var form = new VerifyOTPForm(iSForgotPassword);
            form.Show();
            this.Close();
        }
    }
}
