using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Jeep.View
{
    public partial class JeepneyControl : UserControl
    {
        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
        private int actionColumnIndex = 7;
        public JeepneyControl()
        {
            InitializeComponent();
        }

        private void JeepneyControl_Load(object sender, EventArgs e)
        {

            LoadJeepneys();
        }
        private void LoadJeepneys()
        {
            dgv_jeepney.Rows.Clear();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT 
                                    j.JeepneyID,
                                    j.PlateNumber,
                                    o.OrganizationName,
                                    j.OperatorName,
                                    j.DriverLicensedNo,
                                    j.DriverFullName,
                                    j.RouteTaken
                                 FROM jeepney j
                                 JOIN organization o ON j.OrganizationID = o.OrganizationID";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgv_jeepney.Rows.Add(
                         reader["JeepneyID"],
                         reader["PlateNumber"],
                         reader["OrganizationName"],
                         reader["OperatorName"],
                         reader["DriverLicensedNo"],
                         reader["DriverFullName"],
                         reader["RouteTaken"],
                         null
 
 


                        );
                    }
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new JeepneyForm())
           
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadJeepneys(); 
                }
            }

        }


        private void dgv_jeepney_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                int iconSize = 20;
                int padding = 5;

                var editIcon = Properties.Resources.edit_icon;
                var deleteIcon = Properties.Resources.delete_icon;

                var editRect = new Rectangle(
                    e.CellBounds.Left + padding,
                    e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize);

                var deleteRect = new Rectangle(
                    e.CellBounds.Left + iconSize + padding * 3,
                    e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize);

                e.Graphics.DrawImage(editIcon, editRect);
                e.Graphics.DrawImage(deleteIcon, deleteRect);

                e.Handled = true;
            }
        }

        private void dgv_jeepney_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int jeepneyID = Convert.ToInt32(dgv_jeepney.Rows[e.RowIndex].Cells["JeepneyID"].Value);
                int clickX = e.Location.X;

                if (clickX < 25) // Edit
                {
                    using (var form = new JeepneyForm(jeepneyID, true))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            LoadJeepneys();
                        }
                    }
                }
                else if (clickX > 35 && clickX < 70) // Delete
                {
                    if (MessageBox.Show("Are you sure you want to delete this jeepney?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Delete", "JeepneyForm",
                            $"Deleted jeepney '{jeepneyID}'");
                        DeleteJeepney(jeepneyID);
                        LoadJeepneys();
                    }
                }
            }
        }

        private void DeleteJeepney(int jeepneyID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM jeepney WHERE JeepneyID=@id", con);
                cmd.Parameters.AddWithValue("@id", jeepneyID);
                cmd.ExecuteNonQuery();
            }
        }

        private void dgv_jeepney_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
