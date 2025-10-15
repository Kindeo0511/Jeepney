using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class BaranggayForm : Form
    {
        private Guna2ShadowForm shadowForm;
        bool isEdit = false;
        public BaranggayForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
        }
        public BaranggayForm(bool isEdit)
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
            this.isEdit = isEdit;
            btn_add.Visible = false;
            btn_edit.Visible = true;
            lbl_title.Text = "EDIT BARANGAY";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
