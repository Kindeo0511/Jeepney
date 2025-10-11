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
    public partial class JeepneyControl : UserControl
    {
        public JeepneyControl()
        {
            InitializeComponent();
        }

        private void JeepneyControl_Load(object sender, EventArgs e)
        {
            dgv_jeepney.Rows.Add("N02B500", "BOSSING", "SAHUD", "123456", "NAJIAH", "FTI-PASAY");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new JeepneyForm()) 
            {
                form.ShowDialog();
            }
        }

        private void dgv_jeepney_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= 0 && dgv_jeepney.Columns[e.ColumnIndex].Name == "btn_edit")
            {
                bool isEdit = true;
                using (var form = new JeepneyForm(isEdit))
                {
                    form.ShowDialog();
                }
            }
        }
    }
}
