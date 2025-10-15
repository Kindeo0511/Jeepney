using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class DIscountControl : UserControl
    {
        private int actionColumnIndex = -1;
        public DIscountControl()
        {
            InitializeComponent();
        }

        private void DIscountControl_Load(object sender, EventArgs e)
        {
            dgv_discount.Rows.Add("BICUTAN-PATEROS", "28");
            actionColumnIndex = dgv_discount.Columns["action_column"].Index;
        }

     

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new DIscountForm())
            {
                form.ShowDialog();
            }
        }

        private void dgv_discount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int clickX = e.Location.X;

                if (clickX < 20)
                {

                    using (var form = new DIscountForm(true))
                    {
                        form.ShowDialog();
                    }
                }
                else if (clickX > 30 && clickX < 50)
                {

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this discount?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dgv_discount.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void dgv_discount_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                int iconSize = 24;
                int padding = 8;

                var editIcon = Properties.Resources.edit_icon;
                var deleteIcon = Properties.Resources.delete_icon;


                var editRect = new Rectangle(
                    e.CellBounds.Left + padding - 10,
                    e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize);

                var deleteRect = new Rectangle(
                    e.CellBounds.Left + padding + iconSize,
                    e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize);


                //var editRect = new Rectangle(e.CellBounds.Left + padding, e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2, iconSize, iconSize);
                //var deleteRect = new Rectangle(e.CellBounds.Left + padding + iconSize + 10, e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2, iconSize, iconSize);

                e.Graphics.DrawImage(editIcon, editRect);
                e.Graphics.DrawImage(deleteIcon, deleteRect);

                e.Handled = true;
            }
        }
    }
}
