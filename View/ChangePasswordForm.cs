using System.Windows.Forms;

namespace Jeep.View
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, System.EventArgs e)
        {
            var form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
