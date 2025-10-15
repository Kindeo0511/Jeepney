using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class OperatorsControl : UserControl
    {
        private int actionColumnIndex = -1;
        public OperatorsControl()
        {
            InitializeComponent();
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
            actionColumnIndex = dgv_operator.Columns["action_column"].Index;
        }

        private void dgv_operator_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgv_operator_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int clickX = e.Location.X;

                if (clickX < 20)
                {

                    using (var form = new OperatorForm(true))
                    {
                        form.ShowDialog();
                    }
                }
                else if (clickX > 30 && clickX < 50)
                {

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this operator?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dgv_operator.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
    }
}
