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
    public partial class BaranggayControl : UserControl
    {
        public BaranggayControl()
        {
            InitializeComponent();
        }

        private void BaranggayControl_Load(object sender, EventArgs e)
        {
            dgv_baranggay.Rows.Add("Sta.Ana");
            dgv_baranggay.Rows.Add("Maharlika");
        }

        private void dgv_baranggay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_baranggay.Columns[e.ColumnIndex].Name == "btn_edit")
            {
                bool isEdit = true;
                using (var form = new BaranggayForm(isEdit))
                {
                    form.ShowDialog();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new BaranggayForm())
            {
                form.ShowDialog();
            }
        }
    }
}
