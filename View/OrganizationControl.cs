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
    public partial class OrganizationControl : UserControl
    {
        public OrganizationControl()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new OrganizationForm()) 
            {
                form.ShowDialog();
            }
        }

        private void dgv_organization_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_organization.Columns[e.ColumnIndex].Name == "btn_edit") 
            {
                bool isEdit = true;
                using (var form = new OrganizationForm(isEdit)) 
                {
                    form.ShowDialog();
                }
            }
        }

        private void OrganizationControl_Load(object sender, EventArgs e)
        {
            dgv_organization.Rows.Add("PISTON", "09203101161", "Maharlika");
            dgv_organization.Rows.Add("MANIBELA", "09203101161", "Sta.Ana");
        }
    }
}
