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
    public partial class OperatorsControl : UserControl
    {
        public OperatorsControl()
        {
            InitializeComponent();
        }

        private void dgv_operator_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_operator.Columns[e.ColumnIndex].Name == "btn_edit") 
            {
                bool isEdit = true;
                using (var form = new OperatorForm(isEdit)) 
                {
                    form.ShowDialog();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new OperatorForm())
            {
                form.ShowDialog();
            }
        }

        private void OperatorsControl_Load(object sender, EventArgs e)
        {
            dgv_operator.Rows.Add("Alex", "3", "123-456-000", "PISTON", "09203101161", "Maharlika");
            dgv_operator.Rows.Add("Mark", "4", "345-678-000", "MANIBELA", "09205167812", "Signal");
        }
    }
}
