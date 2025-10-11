using Guna.UI2.WinForms;
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
    public partial class OperatorForm : Form
    {
        private Guna2ShadowForm shadowForm;
        private bool isEdit = false;
        public OperatorForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
        }
        public OperatorForm(bool isEdit)
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
            this.isEdit = isEdit;

            if (isEdit == true) 
            {
                lbl_title.Text = "EDIT OPERATOR";
                btn_add.Visible = false;
                btn_edit.Visible = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
