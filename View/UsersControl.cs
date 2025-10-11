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
    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
        }

        private void UsersControl_Load(object sender, EventArgs e)
        {
            dgv_users.Rows.Add("Louis Jay", "SanSan123", "louisjaycastillo7@gmail.com", "09203101161", "Sta. Ana", "Admin");
            dgv_users.Rows.Add("Mohaifa", "Nissan", "malikmohaifa@gmail.com", "09472632013", "Maharlika", "Staff");
        }

        private void dgv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_users.Columns[e.ColumnIndex].Name == "btn_edit_user")
            {
                bool isEdit = true;
                using (var form = new UserForm(isEdit))
                {
                    form.ShowDialog();
                }
            }
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            var form = new UserForm();
            form.ShowDialog();
        }
    }
}
