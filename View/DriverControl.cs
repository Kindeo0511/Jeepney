using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            LoadDriversFromDatabase(); 
            actionColumnIndex = dgv_driver.Columns["action_column"].Index;
        }

        private void LoadDriversFromDatabase()
        {
            dgv_driver.Rows.Clear();

            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                                        d.DriverID,
                                        d.OperatorID,
                                        o.OperatorName,
                                        org.OrganizationName,
                                        d.FirstName,
                                        d.MiddleName,
                                        d.LastName,
                                        d.ContactNumber,
                                        d.LicensedNumber
                                     FROM driver d
                                     LEFT JOIN operator o ON d.OperatorID = o.OperatorID
                                     LEFT JOIN organization org ON o.OrganizationID = org.OrganizationID";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgv_driver.Rows.Add(
                                reader["DriverID"],
                                reader["FirstName"] ,
                                reader["MiddleName"] ,
                                reader["LastName"],
                                reader["OperatorName"],
                                reader["OrganizationName"],
                                reader["ContactNumber"],
                                reader["LicensedNumber"],
                                null // action column icons
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading drivers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new DriverForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadDriversFromDatabase();
                }
            }

        }

        private void dgv_driver_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                int iconSize = 22;
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
                DataGridViewRow row = dgv_driver.Rows[e.RowIndex];
                int driverID = Convert.ToInt32(row.Cells["DriverID"].Value);

                // 🟩 EDIT BUTTON
                if (clickX < 40)
                {
                    using (var form = new DriverForm(true, driverID))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            LoadDriversFromDatabase();
                        }
                    }
                }
                // 🟥 DELETE BUTTON
                else if (clickX > 40)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this driver?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DeleteDriver(driverID);
                        LoadDriversFromDatabase();
                    }
                }
            }
        }

        private void DeleteDriver(int driverID)
        {
            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM driver WHERE DriverID = @DriverID";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DriverID", driverID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Driver deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Delete", "DriversForm",
    $"Deleted driver '{driverID}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting driver: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_driver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
