using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Jeep.View
{
    public partial class BaranggayControl : UserControl
    {
        private int actionColumnIndex = -1;
        public BaranggayControl()
        {
            InitializeComponent();
        }

        private void BaranggayControl_Load(object sender, EventArgs e)
        {
            LoadBarangaysFromDatabase();
            actionColumnIndex = dgv_baranggay.Columns["action_column"].Index;
        }

        private void LoadBarangaysFromDatabase()
        {
            dgv_baranggay.Rows.Clear();

            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT BarangayID, BarangayName FROM barangay";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgv_baranggay.Rows.Add(
                                reader["BarangayID"],
                                reader["BarangayName"],
                                null // action column (icons)
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading barangays: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new BaranggayForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadBarangaysFromDatabase(); // ✅ Auto refresh after adding
                }
            }
            }

        private void dgv_baranggay_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

                e.Graphics.DrawImage(editIcon, editRect);
                e.Graphics.DrawImage(deleteIcon, deleteRect);

                e.Handled = true;
            }
        }

        private void dgv_baranggay_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int clickX = e.Location.X;

                // 🟩 Edit icon
                if (clickX < 32)
                {
                    DataGridViewRow row = dgv_baranggay.Rows[e.RowIndex];
                    int barangayID = Convert.ToInt32(row.Cells["BarangayID"].Value);
                    string barangayName = row.Cells["BarangayName"].Value.ToString();

                    using (var form = new BaranggayForm(true))
                    {
                        form.LoadBarangayData(barangayID, barangayName);
                        if (form.ShowDialog() == DialogResult.OK)
                            LoadBarangaysFromDatabase();
                    }
                }
                // 🟥 Delete icon
                else if (clickX > 60 && clickX < 100)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this barangay?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgv_baranggay.Rows[e.RowIndex];
                        if (row.Cells["BarangayID"].Value != null && int.TryParse(row.Cells["BarangayID"].Value.ToString(), out int barangayID))
                        {
                            DeleteBarangayFromDatabase(barangayID);
                            LoadBarangaysFromDatabase();
                        }
                    }
                        }
            }
        }
        private void DeleteBarangayFromDatabase(int barangayID)
        {
            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM barangay WHERE BarangayID = @BarangayID";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BarangayID", barangayID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Barangay deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Delete", "BarangayForm",
                    $"Deleted barangay '{barangayID}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting barangay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_baranggay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
