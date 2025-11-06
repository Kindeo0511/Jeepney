using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeep.CustomerView
{
    public partial class RoutesMapForm : Form
    {
        private string route;
        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

        public RoutesMapForm(string selectedRoute)
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(selectedRoute))
            {
                MessageBox.Show("No route selected!");
                this.Close();
                return;
            }

            route = selectedRoute.Trim();

            SetupDataGridView();
        }


        private void RoutesMapForm_Load(object sender, EventArgs e)
        {
          //  MessageBox.Show("Form Loaded for: " + route);
            try
            {
                label1.Text = route;
                LoadRouteInfo(route);
                LoadRouteMapImage(route);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load route info: " + ex.Message);
            }
        }

        private void SetupDataGridView()
        {
            dgvRouteMap.ReadOnly = true;
            dgvRouteMap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRouteMap.AllowUserToAddRows = false;
            dgvRouteMap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRouteMap.RowTemplate.Height = 35;
            dgvRouteMap.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvRouteMap.RowHeadersVisible = false;
            dgvRouteMap.AutoGenerateColumns = true;
        }


        private void LoadRouteInfo(string routeName)
        {
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    s.StopName AS 'Stop Name',
                    IFNULL(fs.StopFare, 0) AS 'Stop Fare',
                    IFNULL(fs.DiscountFare, 0) AS 'Discount Fare',
                    IFNULL(f.BaseFare, 0) AS 'Base Fare',
                    IFNULL(f.DiscountFare, 0) AS 'Base Discount'
                FROM route ro
                INNER JOIN fare f 
                    ON f.RouteID = ro.RouteID
                LEFT JOIN fare_stopover fs 
                    ON fs.FareID = f.FareID
                LEFT JOIN stopover s 
                    ON s.StopoverID = fs.StopoverID 
                    AND s.RouteID = ro.RouteID
                WHERE CONCAT(ro.RouteFrom, ' - ', ro.RouteTo) = @RouteName
                ORDER BY fs.StopFare ASC;
            ";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RouteName", routeName);
                        DataTable dt = new DataTable();
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        if (dt.Rows.Count > 0)
                        {
                            dgvRouteMap.DataSource = dt;
                            dgvRouteMap.Refresh();

                            // Optional: format DataGridView
                            dgvRouteMap.Columns["Stop Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvRouteMap.Columns["Stop Fare"].DefaultCellStyle.Format = "₱0.00";
                            dgvRouteMap.Columns["Discount Fare"].DefaultCellStyle.Format = "₱0.00";
                            dgvRouteMap.Columns["Base Fare"].DefaultCellStyle.Format = "₱0.00";
                            dgvRouteMap.Columns["Base Discount"].DefaultCellStyle.Format = "₱0.00";
                        }
                        else
                        {
                            dgvRouteMap.DataSource = null;
                            MessageBox.Show("No stopovers found for the selected route.",
                                "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading route info:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var form = new RoutesForm();
            form.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new SearchForm();
            form.ShowDialog();
            this.Close();
        }

        private void LoadRouteMapImage(string routeName)
        {
            try
            {
                // Normalize
                string cleanRoute = routeName.Trim().Replace("–", "-").ToLower();

                string basePath = @"C:\Users\dell latitude\source\repos\Jeepney\Resources";
                string imageFile = "default_map.jfif";

                switch (cleanRoute)
                {
                    case "bagumbayan - pasig":
                        imageFile = "Bagumbayan-Pasig.jfif";
                        break;
                    case "fortbonifacio - market-market":
                        imageFile = "Fortbonifacio-MarketMarket.jfif";
                        break;
                    case "guadalupe - taguig-tipas":
                        imageFile = "Guadalupet-TaguigViaTipas.jfif";
                        break;
                    case "pateros - market-market":
                        imageFile = "Pateros-MarketMarket.jfif";
                        break;
                    case "guadalupe - fti":
                        imageFile = "Guada-Fti.jfif";
                        break;
                    case "pasig - taguig":
                        imageFile = "Pasig-BagongKalsada.jfif";
                        break;
                }

                string imagePath = System.IO.Path.Combine(basePath, imageFile);

                if (System.IO.File.Exists(imagePath))
                {
                    picRouteMap.Image = Image.FromFile(imagePath);
                    picRouteMap.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show($"Map image not found at:\n{imagePath}", "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading map image: " + ex.Message);
            }
        }


        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
