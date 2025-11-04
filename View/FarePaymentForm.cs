using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Jeep.View
{
    public partial class FarePaymentForm : Form
    {
        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
        private Guna2ShadowForm shadowForm;
        private bool isEdit = false;
        private int editingFareID = -1;

        public FarePaymentForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
            InitializeForm();

        }
        private void LoadRoutes()
        {
            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT RouteID, CONCAT(RouteFrom, ' - ', RouteTo) AS RouteName FROM route";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbRouteTaken.DataSource = dt;
                cmbRouteTaken.DisplayMember = "RouteName";
                cmbRouteTaken.ValueMember = "RouteID";
                cmbRouteTaken.SelectedIndex = -1;
            }
        }
        public FarePaymentForm(bool isEdit) : this() 
        {
            this.isEdit = isEdit;
            btn_add.Visible = !isEdit;
            btn_edit.Visible = isEdit;
        }
        private void InitializeForm()
        {
            LoadRoutes();
            InitializeStopoverGrid();
            StyleDataGridView(dgvStopovers);
            dgvStopovers.CellEndEdit += dgvStopovers_CellEndEdit;
        }
        private void InitializeStopoverGrid()
        {
            dgvStopovers.Columns.Clear();

            dgvStopovers.Columns.Add("StopoverID", "Stopover ID");
            dgvStopovers.Columns["StopoverID"].Visible = false;

            dgvStopovers.Columns.Add("StopName", "Stop Name");

            var stopFareCol = new DataGridViewTextBoxColumn
            {
                Name = "StopFare",
                HeaderText = "Stop Fare"
            };
            dgvStopovers.Columns.Add(stopFareCol);

            var discountFareCol = new DataGridViewTextBoxColumn
            {
                Name = "DiscountFare",
                HeaderText = "Discount Fare (20%)",
                ReadOnly = true
            };
            dgvStopovers.Columns.Add(discountFareCol);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            // General appearance
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.GridColor = Color.LightGray;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // Header style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 35;

            // Row style
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dgv.RowsDefaultCellStyle.Padding = new Padding(5);
            dgv.RowTemplate.Height = 30;
            // Center align content horizontally and vertically in all cells
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Selection style
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Disable adding rows by user
            dgv.AllowUserToAddRows = false;

            // Disable row headers
            dgv.RowHeadersVisible = false;

            // Columns fill evenly across available width (ok lang ito kahit vertical scroll lang)
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Scrollbars → Vertical only
            dgv.ScrollBars = ScrollBars.Vertical;

            // Pantay ang columns at minimum width
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.MinimumWidth = 100;
                col.FillWeight = 1;
            }
        }
        private void FarePaymentForm_Load(object sender, EventArgs e)
        {
        

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadStopovers(int routeID)
        {
            dgvStopovers.Rows.Clear();

            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT StopoverID, StopName FROM stopover WHERE RouteID = @RouteID";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RouteID", routeID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvStopovers.Rows.Add(reader["StopoverID"], reader["StopName"], "0.00", "0.00");
                        }
                    }
                }
            }
        }


        private void cmbRouteTaken_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRouteTaken.SelectedValue == null || cmbRouteTaken.SelectedValue is DataRowView)
                return;

            if (!isEdit) 
            {
                int routeID = Convert.ToInt32(cmbRouteTaken.SelectedValue);
                LoadStopovers(routeID);
            }
        }
        private long cmdLastInsertedID(MySqlConnection con, MySqlTransaction transaction)
        {
            using (var cmd = new MySqlCommand("SELECT LAST_INSERT_ID();", con, transaction))
            {
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
        }
    

        private void txtBaseFare_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBaseFare.Text, out decimal baseFare))
            {
                decimal discountFare = baseFare * 0.8m; // 20% discount
                txtDiscountFare.Text = discountFare.ToString("0.00");
            }
            else
            {
                txtDiscountFare.Text = "0.00";
            }
        }

        private void dgvStopovers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvStopovers.Columns["StopFare"].Index)
            {
                DataGridViewRow row = dgvStopovers.Rows[e.RowIndex];
                if (decimal.TryParse(row.Cells["StopFare"].Value?.ToString(), out decimal stopFare))
                {
                    row.Cells["DiscountFare"].Value = (stopFare * 0.8m).ToString("0.00");
                }
                else
                {
                    row.Cells["DiscountFare"].Value = "0.00";
                }
            }
        }
      

        public void LoadFareForEdit(int fareID)
        {
            editingFareID = fareID;
            isEdit = true;
            btn_add.Visible = false;
            btn_edit.Visible = true;

            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();

                string fareQuery = @"SELECT f.RouteID, f.BaseFare, f.DiscountFare
                             FROM fare f
                             WHERE f.FareID = @FareID";

                using (var cmd = new MySqlCommand(fareQuery, con))
                {
                    cmd.Parameters.AddWithValue("@FareID", fareID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int routeID = Convert.ToInt32(reader["RouteID"]);

                            this.BeginInvoke((Action)(() =>
                            {
                                cmbRouteTaken.SelectedValue = routeID;
                            }));

                            txtBaseFare.Text = reader["BaseFare"].ToString();
                            txtDiscountFare.Text = reader["DiscountFare"].ToString();
                        }
                    }
                }

           
                dgvStopovers.Rows.Clear();
                string stopQuery = @"SELECT fs.StopoverID, s.StopName, fs.StopFare, fs.DiscountFare
                             FROM fare_stopover fs
                             JOIN stopover s ON fs.StopoverID = s.StopoverID
                             WHERE fs.FareID = @FareID";

                using (var cmd = new MySqlCommand(stopQuery, con))
                {
                    cmd.Parameters.AddWithValue("@FareID", fareID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvStopovers.Rows.Add(
                                reader["StopoverID"],
                                reader["StopName"],
                                reader["StopFare"],
                                reader["DiscountFare"]
                            );
                        }
                    }
                }
            }
        }
        private bool ValidateFareForm(out int routeID, out decimal baseFare, out string barangayName)
        {
            routeID = -1;
            baseFare = 0;
            barangayName = cmbRouteTaken.Text.Trim();

            // 1. Route validation
            if (cmbRouteTaken.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a route.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(cmbRouteTaken.SelectedValue is int))
            {
                MessageBox.Show("Selected route is invalid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            routeID = Convert.ToInt32(cmbRouteTaken.SelectedValue);

            // 2. Base fare validation
            if (string.IsNullOrWhiteSpace(txtBaseFare.Text))
            {
                MessageBox.Show("Fare price is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtBaseFare.Text, out baseFare))
            {
                MessageBox.Show("Fare price should contain only numbers or decimals.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 3. Barangay name validation
            if (string.IsNullOrWhiteSpace(barangayName))
            {
                MessageBox.Show("Barangay name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(barangayName, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Barangay name should contain only letters and spaces.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // All validations passed
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateFareForm(out int routeID, out decimal baseFare, out string barangayName))
                return;

         

            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();

                try
                {

                    string insertFare = "INSERT INTO fare (RouteID, BaseFare, DiscountFare) VALUES (@RouteID, @BaseFare, @DiscountFare)";

                    using (var cmd = new MySqlCommand(insertFare, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@RouteID", routeID);
                        cmd.Parameters.AddWithValue("@BaseFare", baseFare);
                        decimal discountFare = baseFare * 0.8m; // Example: 20% discount (you can adjust later)
                        cmd.Parameters.AddWithValue("@DiscountFare", discountFare);

                        cmd.ExecuteNonQuery();
                    }


                    long fareID = cmdLastInsertedID(con, transaction);


                    foreach (DataGridViewRow row in dgvStopovers.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int stopoverID = Convert.ToInt32(row.Cells["StopoverID"].Value);
                        decimal stopFare = Convert.ToDecimal(row.Cells["StopFare"].Value);

                        string insertStop = @"INSERT INTO fare_stopover (FareID, StopoverID, StopFare, DiscountFare)
                      VALUES (@FareID, @StopoverID, @StopFare, @DiscountFare)";
                        using (var cmd2 = new MySqlCommand(insertStop, con, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@FareID", fareID);
                            cmd2.Parameters.AddWithValue("@StopoverID", stopoverID);
                            cmd2.Parameters.AddWithValue("@StopFare", stopFare);

                            decimal discountFare = stopFare * 0.8m;
                            cmd2.Parameters.AddWithValue("@DiscountFare", discountFare);

                            cmd2.ExecuteNonQuery();
                        }

                    }

                    transaction.Commit();
                    MessageBox.Show("Fare registration saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // When adding a new fare
                    AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Add", "FarePaymentForm",
                        $"Added new fare for route {cmbRouteTaken.Text} with base fare {txtBaseFare.Text}");

                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving fare: " + ex.Message);
                }

            }
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateFareForm(out int routeID, out decimal baseFare, out string barangayName))
                return;

            if (editingFareID == -1)
            {
                MessageBox.Show("No fare selected to edit.");
                return;
            }

            if (cmbRouteTaken.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtBaseFare.Text))
            {
                MessageBox.Show("Please select a route and enter a base fare.");
                return;
            }

          

            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Update fare
                    string updateFare = @"UPDATE fare 
                                  SET RouteID = @RouteID, 
                                      BaseFare = @BaseFare, 
                                      DiscountFare = @DiscountFare
                                  WHERE FareID = @FareID";

                    using (var cmd = new MySqlCommand(updateFare, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@RouteID", routeID);
                        cmd.Parameters.AddWithValue("@BaseFare", baseFare);
                        cmd.Parameters.AddWithValue("@DiscountFare", baseFare * 0.8m);
                        cmd.Parameters.AddWithValue("@FareID", editingFareID);
                        cmd.ExecuteNonQuery();
                    }

                    // Delete old stopovers (to replace)
                    using (var cmd = new MySqlCommand("DELETE FROM fare_stopover WHERE FareID = @FareID", con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FareID", editingFareID);
                        cmd.ExecuteNonQuery();
                    }

                    // Insert updated stopovers
                    foreach (DataGridViewRow row in dgvStopovers.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int stopoverID = Convert.ToInt32(row.Cells["StopoverID"].Value);
                        decimal stopFare = Convert.ToDecimal(row.Cells["StopFare"].Value);
                        decimal discountFare = stopFare * 0.8m;

                        string insertStop = @"INSERT INTO fare_stopover (FareID, StopoverID, StopFare, DiscountFare)
                                      VALUES (@FareID, @StopoverID, @StopFare, @DiscountFare)";
                        using (var cmd2 = new MySqlCommand(insertStop, con, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@FareID", editingFareID);
                            cmd2.Parameters.AddWithValue("@StopoverID", stopoverID);
                            cmd2.Parameters.AddWithValue("@StopFare", stopFare);
                            cmd2.Parameters.AddWithValue("@DiscountFare", discountFare);
                            cmd2.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    // When editing
                    AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Edit", "FarePaymentForm",
                        $"Updated fare for route {cmbRouteTaken.Text} with new base fare {txtBaseFare.Text}");
                    MessageBox.Show("Fare updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error updating fare: " + ex.Message);
                }
            }
        }
    }
}
