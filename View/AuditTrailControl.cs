using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jeep.View
{
    public partial class AuditTrailControl : UserControl
    {
        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

        public AuditTrailControl()
        {
            InitializeComponent();
        }

        private void AuditTrailControl_Load(object sender, EventArgs e)
        {

            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Today;

          
            LoadAuditTrail();

          
            dtpFrom.ValueChanged += DtpDate_ValueChanged;
            dtpTo.ValueChanged += DtpDate_ValueChanged;
        }
        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAuditTrail();
        }

        private void LoadAuditTrail()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT Username, Role, ActionType, ModuleName, Description, ActionDate
                             FROM audit_trail
                             WHERE ActionDate BETWEEN @FromDate AND @ToDate
                             ORDER BY ActionDate DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                        cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date.AddDays(1).AddSeconds(-1));

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            dgv_audit_trail.Rows.Clear(); // Clear existing rows

                            while (reader.Read())
                            {
                                int rowIndex = dgv_audit_trail.Rows.Add();
                                DataGridViewRow row = dgv_audit_trail.Rows[rowIndex];

                                row.Cells["Username"].Value = reader["Username"].ToString();
                                row.Cells["Role"].Value = reader["Role"].ToString();
                                row.Cells["ActionType"].Value = reader["ActionType"].ToString();
                                row.Cells["ModuleName"].Value = reader["ModuleName"].ToString();
                                row.Cells["Description"].Value = reader["Description"].ToString();
                                row.Cells["ActionDate"].Value = Convert.ToDateTime(reader["ActionDate"]).ToString("yyyy-MM-dd HH:mm:ss");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading audit trail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_audit_trail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
