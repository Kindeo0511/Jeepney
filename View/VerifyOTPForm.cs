using System;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Jeep.View
{
    public partial class VerifyOTPForm : Form
    {
        private bool isForgotPassword;
        private string otp;
        private string email;
        public VerifyOTPForm()
        {
            InitializeComponent();
        }
        public VerifyOTPForm(bool isForgotPassword, string otp, string email)
        {
            InitializeComponent();
            this.isForgotPassword = isForgotPassword; 
            this.otp = otp;
            this.email = email;
        }


        private void btn_send_otp_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == otp)
            {
                if (isForgotPassword)
                {
                    var form = new ChangePasswordForm(email); 
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
            else
            {
                MessageBox.Show("Invalid OTP!");
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VerifyOTPForm_Load(object sender, EventArgs e)
        {

        }
    }
}
