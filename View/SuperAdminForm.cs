using System;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class SuperAdminForm : Form
    {
        public SuperAdminForm()
        {
            InitializeComponent();
        }

        private void btn_send_otp_Click(object sender, EventArgs e)
        {

            var form = new VerifyOTPForm();
            form.Show();
            this.Close();


        }
    }
}
