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
    public partial class SearchForm : Form
    {
        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
        public SearchForm()
        {
            InitializeComponent();

            lstSuggestions.Visible = false;

            txt_search.TextChanged += txt_search_TextChanged;
            lstSuggestions.Click += lstSuggestions_Click;
            txt_search.KeyDown += txt_search_KeyDown;
        }
        // Search routes by input
        private DataTable SearchRoutes(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"
                        SELECT CONCAT(RouteFrom, ' - ', RouteTo) AS RouteName
                        FROM route
                        WHERE RouteFrom LIKE @q OR RouteTo LIKE @q OR CONCAT(RouteFrom,' - ',RouteTo) LIKE @q
                    ";

                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@q", "%" + query + "%");

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching routes: " + ex.Message);
            }

            return dt;
        }

        // Show suggestions as user types
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                lstSuggestions.Visible = false;
                return;
            }

            DataTable dt = SearchRoutes(search);

            lstSuggestions.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                lstSuggestions.Items.Add(row["RouteName"].ToString());
            }

            lstSuggestions.Visible = lstSuggestions.Items.Count > 0;

            if (lstSuggestions.Visible)
            {
                lstSuggestions.Width = txt_search.Width;
                int itemHeight = lstSuggestions.ItemHeight;
                int maxVisibleItems = 8;
                int visibleItems = Math.Min(lstSuggestions.Items.Count, maxVisibleItems);
                lstSuggestions.Height = itemHeight * visibleItems + 2;
            }
        }

        // User clicks a suggestion
        private void lstSuggestions_Click(object sender, EventArgs e)
        {
            if (lstSuggestions.SelectedItem == null) return;

            string selectedRoute = lstSuggestions.SelectedItem.ToString().Trim();

            if (string.IsNullOrEmpty(selectedRoute))
            {
                MessageBox.Show("Selected route is empty.");
                return;
            }

            txt_search.Text = selectedRoute;
            lstSuggestions.Visible = false;

            OpenRouteMap(selectedRoute);
        }

        // Enter key pressed
        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            string selectedRoute = txt_search.Text.Trim();

            if (string.IsNullOrEmpty(selectedRoute))
            {
                MessageBox.Show("Please select a route.");
                return;
            }

            OpenRouteMap(selectedRoute);
            e.SuppressKeyPress = true;
        }

        // Opens the RoutesMapForm safely
        private void OpenRouteMap(string selectedRoute)
        {
            try
            {
                var mapForm = new RoutesMapForm(selectedRoute);
                mapForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open route map: " + ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var form = new RoutesForm();
            form.Show();
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        
        }
    }

