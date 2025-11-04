using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

using System.Data;

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
            LoadUsersFromDatabase();
            actionColumnIndex = dgv_users.Columns["action_column"].Index;

        }

        private void LoadUsersFromDatabase()
        {
            dgv_users.Rows.Clear();

            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT UserID, UserName, Password, EmailAddress, PhoneNumber, Address, Role FROM user";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgv_users.Rows.Add(
                                reader["UserID"],         
                                reader["UserName"],
                                reader["Password"],
                                reader["EmailAddress"],
                                reader["PhoneNumber"],
                                reader["Address"],
                                reader["Role"],
                                null                      
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_add_user_Click(object sender, EventArgs e)
        {
            using (var form = new UserForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadUsersFromDatabase(); // ✅ this refreshes automatically
                }
            }
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

        private void DeleteUserFromDatabase(int userID)
        {
            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM user WHERE UserID = @UserID";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Deleting a user
                AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Delete", "UserForm",
                    $"Deleted user '{userID}'");
                MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_users_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int clickX = e.Location.X;

                if (clickX < 32)
                {
                    // Get selected row data
                    DataGridViewRow row = dgv_users.Rows[e.RowIndex];

                    int userID = 0;
                    if (row.Cells["UserID"].Value != null && int.TryParse(row.Cells["UserID"].Value.ToString(), out int parsedID))
                    {
                        userID = parsedID;
                    }
                    else
                    {
                        MessageBox.Show("Invalid or missing UserID in this row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string username = row.Cells["Username"].Value.ToString();
                    string password = row.Cells["Password"].Value.ToString();
                    string email = row.Cells["EmailAddress"].Value.ToString();
                    string phone = row.Cells["Phonenumber"].Value.ToString();
                    string address = row.Cells["Address"].Value.ToString();
                    string position = row.Cells["Role"].Value.ToString();


                    using (var form = new UserForm(true))
                    {
                        // ✅ pass userID along with the rest
                        form.LoadUserData(userID, username, password, email, phone, address, position);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            LoadUsersFromDatabase(); // refresh list after editing
                        }
                    }
                }


                else if (clickX > 60 && clickX < 72)
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this user?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgv_users.Rows[e.RowIndex];
                        if (row.Cells["UserID"].Value != null && int.TryParse(row.Cells["UserID"].Value.ToString(), out int userID))
                        {
                            DeleteUserFromDatabase(userID);
                            LoadUsersFromDatabase();
                        }
                        else
                        {
                            MessageBox.Show("Invalid UserID for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }
        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
