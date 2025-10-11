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
    public partial class DIscountControl : UserControl
    {
        public DIscountControl()
        {
            InitializeComponent();
        }

        private void DIscountControl_Load(object sender, EventArgs e)
        {
            dgv_discount.Rows.Add("BICUTAN-PATEROS", "28");
        }

        private void dgv_discount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= 0 && dgv_discount.Columns[e.ColumnIndex].Name == "btn_edit")
            {
                bool isEdit = true;
                using (var form = new DIscountForm(isEdit))
                {
                    form.ShowDialog();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new DIscountForm())
            {
                form.ShowDialog();
            }
        }
    }
}
