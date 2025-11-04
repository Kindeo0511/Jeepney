using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class FarePaymentControl : UserControl
    {
        private string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
        private int actionColumnIndex = 4;

        public FarePaymentControl()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new FarePaymentForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadFares();
                }
            }
        }

        private void FarePaymentControl_Load(object sender, EventArgs e)
        {
            LoadFares();
        }

        private void LoadFares()
        {
            dgv_fare_payment.Rows.Clear();

            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT 
                                    f.FareID,
                                    CONCAT(r.RouteFrom, ' - ', r.RouteTo) AS RouteName,
                                    f.BaseFare,
                                    f.DiscountFare
                                 FROM fare f
                                 JOIN route r ON f.RouteID = r.RouteID";

                using (var cmd = new MySqlCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgv_fare_payment.Rows.Add(
                            reader["FareID"],
                            reader["RouteName"],
                            reader["BaseFare"],
                            reader["DiscountFare"],

                            null
                        );
                    }
                }
            }
        }

        private void dgv_fare_payment_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgv_fare_payment_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int fareID = Convert.ToInt32(dgv_fare_payment.Rows[e.RowIndex].Cells["FareID"].Value);
                int clickX = e.Location.X;
                if (clickX < 25) // Edit
                {
                    using (var form = new FarePaymentForm(true))
                    {
                        form.LoadFareForEdit(fareID);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            LoadFares();
                        }
                    }
                }
                else if (clickX > 35 && clickX < 70) // Delete
                {
                    if (MessageBox.Show("Are you sure you want to delete this fare?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        DeleteFare(fareID);
                        LoadFares();
                    }
                }
            }
        }

        private void DeleteFare(int fareID)
        {
            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();

                // Delete child records first
                var cmd1 = new MySqlCommand("DELETE FROM fare_stopover WHERE FareID = @id", con);
                cmd1.Parameters.AddWithValue("@id", fareID);
                cmd1.ExecuteNonQuery();

                // Delete main fare
                var cmd2 = new MySqlCommand("DELETE FROM fare WHERE FareID = @id", con);
                cmd2.Parameters.AddWithValue("@id", fareID);
                cmd2.ExecuteNonQuery();
            }
        }

        private void dgv_fare_payment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
