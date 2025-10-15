using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class DriverControl : UserControl
    {
        private int actionColumnIndex = -1;
        public DriverControl()
        {
            InitializeComponent();
        }

        private void DriverControl_Load(object sender, EventArgs e)
        {
            dgv_driver.Rows.Add("NAJIAH", "JUMRANI", "BUA", "09876543212", "123456", "SAHUD", "BOSSING");
            actionColumnIndex = dgv_driver.Columns["action_column"].Index;
        }

      

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new DriverForm())
            {
                form.ShowDialog();
            }
        }

        private void dgv_driver_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgv_driver_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int clickX = e.Location.X;

                if (clickX < 20)
                {

                    using (var form = new DriverForm(true))
                    {
                        form.ShowDialog();
                    }
                }
                else if (clickX > 30 && clickX < 50)
                {

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this driver?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dgv_driver.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
    }
}
