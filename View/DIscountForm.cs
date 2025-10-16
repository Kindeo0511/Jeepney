using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class DIscountForm : Form
    {
        private Guna2ShadowForm shadowForm;
        private bool isEdit = false;
        public DIscountForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
        }
        public DIscountForm(bool isEdit)
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
            this.isEdit = isEdit;

            if (isEdit)
            {
                btn_add.Visible = false;
                btn_edit.Visible = true;
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
