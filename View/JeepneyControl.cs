using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class JeepneyControl : UserControl
    {
        private int actionColumnIndex = -1;
        public JeepneyControl()
        {
            InitializeComponent();
        }

        private void JeepneyControl_Load(object sender, EventArgs e)
        {
            dgv_jeepney.Rows.Add("N02B500", "BOSSING", "SAHUD", "123456", "NAJIAH", "FTI-PASAY");
            actionColumnIndex = dgv_jeepney.Columns["action_column"].Index;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new JeepneyForm())
            {
                form.ShowDialog();
            }
        }

     
        private void dgv_jeepney_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgv_jeepney_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int clickX = e.Location.X;

                if (clickX < 20)
                {

                    using (var form = new JeepneyForm(true))
                    {
                        form.ShowDialog();
                    }
                }
                else if (clickX > 30 && clickX < 50)
                {

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this jeepney?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dgv_jeepney.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
    }
}
