using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class UserForm : Form
    {
        private Guna2ShadowForm shadowForm;
        private bool isEdit = false;
        public UserForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
        }

        public UserForm(bool isEdit)
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
            this.isEdit = isEdit;
            lbl_title.Text = " EDIT USER";
            btn_add.Visible = false;
            btn_edit.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
