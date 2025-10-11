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
    public partial class FarePaymentControl : UserControl
    {
        
        public FarePaymentControl()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new FarePaymentForm()) 
            {
                form.ShowDialog();
            }
        }

        private void FarePaymentControl_Load(object sender, EventArgs e)
        {
            dgv_fare_payment.Rows.Add("BICUTAN-PATEROS", "28");
        }

        private void dgv_fare_payment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= 0 && dgv_fare_payment.Columns[e.ColumnIndex].Name == "btn_edit")
            {
                bool isEdit = true;
                using (var form = new FarePaymentForm(isEdit))
                {
                    form.ShowDialog();
                }
            }
        }
    }
}
