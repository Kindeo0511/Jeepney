using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class UsersControl : UserControl
    {
        private int actionColumnIndex = -1;

        public UsersControl()
        {
            InitializeComponent();
        }

        private void UsersControl_Load(object sender, EventArgs e)
        {
            dgv_users.Rows.Add("Louis Jay", "SanSan123", "louisjaycastillo7@gmail.com", "09203101161", "Sta. Ana", "Admin");
            dgv_users.Rows.Add("Mohaifa", "Nissan", "malikmohaifa@gmail.com", "09472632013", "Maharlika", "Staff");
            actionColumnIndex = dgv_users.Columns["action_column"].Index;

        }

  

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            var form = new UserForm();
            form.ShowDialog();
        }

        private void dgv_users_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                    e.CellBounds.Left + padding + iconSize + 24,
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

        private void dgv_users_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int clickX = e.Location.X;

                if (clickX < 32)
                {
                 
                    using (var form = new UserForm(true)) 
                    {
                        form.ShowDialog();
                    }
                }
                else if (clickX > 60 && clickX < 72)
                {
                    
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dgv_users.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }

        }
    }
}
