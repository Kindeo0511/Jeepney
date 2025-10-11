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
    public partial class RouteControl : UserControl
    {
        public RouteControl()
        {
            InitializeComponent();
        }

        private void RouteControl_Load(object sender, EventArgs e)
        {
            dgv_route.Rows.Add("FTI", "PASAY", "GATE 3", "5:00 AM", "10:00 PM", "BOSSING");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new RouteForm()) 
            {
                form.ShowDialog();
            }
        }

        private void dgv_route_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= 0 && dgv_route.Columns[e.ColumnIndex].Name == "btn_edit") 
            {
                bool isEdit = true;
                using (var form = new RouteForm(isEdit))
                {
                    form.ShowDialog();
                }
            }
        }
    }
}
