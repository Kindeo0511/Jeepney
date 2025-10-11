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
