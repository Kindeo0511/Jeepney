using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class BaranggayControl : UserControl
    {
        private int actionColumnIndex = -1;
        public BaranggayControl()
        {
            InitializeComponent();
        }

        private void BaranggayControl_Load(object sender, EventArgs e)
        {
            dgv_baranggay.Rows.Add("Sta.Ana");
            dgv_baranggay.Rows.Add("Maharlika");
            actionColumnIndex = dgv_baranggay.Columns["action_column"].Index;
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new BaranggayForm())
            {
                form.ShowDialog();
            }
        }

        private void dgv_baranggay_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                int iconSize = 24;
                int padding = 8;

                var editIcon = Properties.Resources.edit_icon;
                var deleteIcon = Properties.Resources.delete_icon;


                var editRect = new Rectangle(
                    e.CellBounds.Left + padding,
                    e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize);

                var deleteRect = new Rectangle(
                    e.CellBounds.Left + padding + iconSize + 12,
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

        private void dgv_baranggay_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int clickX = e.Location.X;

                if (clickX < 32)
                {

                    using (var form = new BaranggayForm(true))
                    {
                        form.ShowDialog();
                    }
                }
                else if (clickX > 40 && clickX < 70)
                {

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this barangay?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dgv_baranggay.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
    }
}
