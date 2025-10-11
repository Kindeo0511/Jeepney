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
