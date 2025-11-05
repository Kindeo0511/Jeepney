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

            if (dgvRouteMap == null)
            {
                MessageBox.Show("dgvRouteMap is not initialized!");
                this.Close();
                return;
            }

            SetupDataGridView();

            try
            {
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
            dgvRouteMap.AutoGenerateColumns = true; // Important for DataBinding
        }

        private void LoadRouteInfo(string routeName)
        {
            try
            {
                DataTable dt = new DataTable();

                using (var con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
              SELECT 
    IFNULL(s.StopName,'-') AS StopName,
    IFNULL(fs.StopFare,0) AS StopFare,
    IFNULL(fs.DiscountFare,0) AS StopDiscount,
    IFNULL(f.BaseFare,0) AS BaseFare,
    IFNULL(f.DiscountFare,0) AS DiscountFare
FROM route ro
INNER JOIN fare f ON f.RouteID = ro.RouteID
LEFT JOIN fare_stopover fs ON fs.FareID = f.FareID
LEFT JOIN stopover s ON s.StopoverID = fs.StopoverID
WHERE ro.RouteID = (
    SELECT RouteID FROM route WHERE CONCAT(RouteFrom,' - ',RouteTo) = @RouteName LIMIT 1
)
ORDER BY fs.StopFare ASC

            ";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RouteName", routeName);

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No stops found for the selected route.");
                    dgvRouteMap.DataSource = null;
                    return;
                }

                // Bind directly to DGV
                dgvRouteMap.DataSource = dt;

                // Format DataGridView
                dgvRouteMap.ReadOnly = true;
                dgvRouteMap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRouteMap.AllowUserToAddRows = false;
                dgvRouteMap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRouteMap.RowTemplate.Height = 35;
                dgvRouteMap.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dgvRouteMap.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading route info: " + ex.Message);
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
               
                string basePath = Application.StartupPath + @"\Resources\Maps\";

                string imagePath = "";

             
                switch (routeName.Trim())
                {
                    case "FTI - Pasay":
                        imagePath = basePath + "FTI_Pasay_Map.png";
                        break;

                    case "Bagumbayan - Pasig":
                        imagePath = basePath + "Bagumbayan_Pasig_Map.png";
                        break;

                    case "FTI - Market Market":
                        imagePath = basePath + "FTI_MarketMarket_Map.png";
                        break;

                    default:
                        imagePath = basePath + "default_map.png";
                        break;
                }

                if (System.IO.File.Exists(imagePath))
                {
                    picRouteMap.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Map image not found for " + routeName);
                    picRouteMap.Image = null;
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

        private void RoutesMapForm_Load(object sender, EventArgs e)
        {
            LoadRouteMapImage(route);

        }
    }
}
