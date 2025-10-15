using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class OrganizationControl : UserControl
    {
        private int actionColumnIndex = -1;
        public OrganizationControl()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new OrganizationForm())
            {
                form.ShowDialog();
            }
        }


        private void OrganizationControl_Load(object sender, EventArgs e)
        {
            dgv_organization.Rows.Add("PISTON", "09203101161", "Maharlika");
            dgv_organization.Rows.Add("MANIBELA", "09203101161", "Sta.Ana");
            actionColumnIndex = dgv_organization.Columns["action_column"].Index;
        }

        private void dgv_organization_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgv_organization_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int clickX = e.Location.X;

                if (clickX < 20)
                {

                    using (var form = new OrganizationForm(true))
                    {
                        form.ShowDialog();
                    }
                }
                else if (clickX > 30 && clickX < 50)
                {

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this organization?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dgv_organization.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
    }
}
