using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class RouteControl : UserControl
    {
        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
        private int actionColumnIndex = 6;
        public RouteControl()
        {
            InitializeComponent();
        }

        private void RouteControl_Load(object sender, EventArgs e)
        {
            LoadRoutes();
        }
        private void LoadRoutes()
        {
            dgv_route.Rows.Clear();

            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                                r.RouteID,
                                o.OrganizationName,
                                r.RouteFrom,
                                r.RouteTo,
                                r.TimeStart,
                                r.TimeEnd
                             FROM route r
                             JOIN organization o 
                             ON r.OrganizationID = o.OrganizationID";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgv_route.Rows.Add(
                                reader["RouteID"],
                                 reader["RouteFrom"].ToString(),
                                   reader["RouteTo"].ToString(),
                                reader["OrganizationName"].ToString(),
                               
                              
                              ((TimeSpan)reader["TimeStart"]).ToString(@"hh\:mm\:ss"),
                              ((TimeSpan)reader["TimeEnd"]).ToString(@"hh\:mm\:ss"),

                                null
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading routes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new RouteForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadRoutes();
                }
            }
        }

    
        private void dgv_route_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                int iconSize = 20;
                int padding = 5;

                // Use your icon resources
                var editIcon = Properties.Resources.edit_icon;
                var deleteIcon = Properties.Resources.delete_icon;

                // Draw icons
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

        private void dgv_route_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int routeID = Convert.ToInt32(dgv_route.Rows[e.RowIndex].Cells["RouteID"].Value);
                int clickX = e.Location.X;

                // Determine which icon was clicked
                if (clickX < 25) // edit icon
                {
                    using (var form = new RouteForm(routeID, true))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            LoadRoutes();
                        }
                    }
                }
                else if (clickX > 35 && clickX < 70) 
                {
                    if (MessageBox.Show("Are you sure you want to delete this route?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Delete", "RoutesForm",
                            $"Deleted route '{routeID} - {routeID}'");
                        DeleteRoute(routeID);
                        LoadRoutes();
                    }
                }
            }
        }
        private void DeleteRoute(int routeID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                MySqlCommand delStops = new MySqlCommand("DELETE FROM stopover WHERE RouteID=@RouteID", con);
                delStops.Parameters.AddWithValue("@RouteID", routeID);
                delStops.ExecuteNonQuery();

                MySqlCommand delRoute = new MySqlCommand("DELETE FROM route WHERE RouteID=@RouteID", con);
                delRoute.Parameters.AddWithValue("@RouteID", routeID);
                delRoute.ExecuteNonQuery();
            }
        }

        private void dgv_route_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
