using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Jeep.View
{
    public partial class OperatorsControl : UserControl
    {
        private int actionColumnIndex = -1;
        public OperatorsControl()
        {
            InitializeComponent();
        }

       

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new OperatorForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadOperatorsFromDatabase(); 
                }
            }
            }

        private void OperatorsControl_Load(object sender, EventArgs e)
        {
            LoadOperatorsFromDatabase();
            actionColumnIndex = dgv_operator.Columns["action_column"].Index;
        }
        private void LoadOperatorsFromDatabase()
        {
            dgv_operator.Rows.Clear();

            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                    o.OperatorID,
                    o.OrganizationID,
                    org.OrganizationName,
                    o.OperatorName,
                    o.NoOfVehicle,
                    o.FranchiseNo,
                    o.ContactNumber,
                    o.Address
                 FROM operator o
                 LEFT JOIN organization org ON o.OrganizationID = org.OrganizationID";


                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgv_operator.Rows.Add(
                                reader["OperatorID"],
                                reader["OperatorName"],
                                reader["OrganizationName"],
                                reader["NoOfVehicle"],
                                reader["FranchiseNo"],
                                reader["ContactNumber"],
                                reader["Address"],
                                null // Action column
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading operators: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_operator_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                int iconSize = 24;
                int padding = 8;

                var editIcon = Properties.Resources.edit_icon;
                var deleteIcon = Properties.Resources.delete_icon;

                // Edit icon
                var editRect = new Rectangle(
                    e.CellBounds.Left + padding,
                    e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize);

                // Delete icon
                var deleteRect = new Rectangle(
                    e.CellBounds.Right - iconSize - padding,
                    e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize);

                e.Graphics.DrawImage(editIcon, editRect);
                e.Graphics.DrawImage(deleteIcon, deleteRect);

                e.Handled = true;
            }
        }

        private void dgv_operator_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int clickX = e.Location.X;
                DataGridViewRow row = dgv_operator.Rows[e.RowIndex];
                int operatorID = Convert.ToInt32(row.Cells["OperatorID"].Value);

                // Get cell bounds for more precise icon click detection
                Rectangle cellBounds = dgv_operator.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                int iconSize = 24;
                int padding = 8;

                Rectangle editRect = new Rectangle(
                    cellBounds.Left + padding,
                    cellBounds.Top + (cellBounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize);

                Rectangle deleteRect = new Rectangle(
                    cellBounds.Right - iconSize - padding,
                    cellBounds.Top + (cellBounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize);

                // Check if click is on EDIT
                if (editRect.Contains(e.Location))
                {
                    int organizationID = 0;
                    string orgName = row.Cells["OrganizationName"].Value?.ToString() ?? "";

                    // Get OrganizationID from DB (since DataGridView only shows name)
                    using (var con = new MySqlConnection("server=localhost;user id=root;password=;database=jeepney;"))
                    {
                        con.Open();
                        string getOrgIDQuery = "SELECT OrganizationID FROM organization WHERE OrganizationName = @OrganizationName LIMIT 1";
                        using (var cmd = new MySqlCommand(getOrgIDQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@OrganizationName", orgName);
                            object result = cmd.ExecuteScalar();
                            if (result != null) organizationID = Convert.ToInt32(result);
                        }
                    }

                    string operatorName = row.Cells["OperatorName"].Value.ToString();
                    string noOfVehicle = row.Cells["NoOfVehicle"].Value.ToString();
                    string franchiseNo = row.Cells["FranchiseNo"].Value.ToString();
                    string contact = row.Cells["ContactNumber"].Value.ToString();
                    string address = row.Cells["Address"].Value.ToString();

                    using (var form = new OperatorForm(operatorID, organizationID, operatorName, noOfVehicle, franchiseNo, contact, address))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            LoadOperatorsFromDatabase();
                        }
                    }
                }
                // Check if click is on DELETE
                else if (deleteRect.Contains(e.Location))
                {
                    DialogResult confirm = MessageBox.Show(
                        "Are you sure you want to delete this operator?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        DeleteOperator(operatorID);
                        LoadOperatorsFromDatabase();
                    }
                }
            }
        }


        private void DeleteOperator(int operatorID)
        {
            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM operator WHERE OperatorID = @OperatorID";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@OperatorID", operatorID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Operator deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Delete", "OperatorsForm",
                    $"Deleted operator '{operatorID}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting operator: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
            private void guna2HtmlLabel2_Click(object sender, EventArgs e)
                    {

                    }

        private void dgv_operator_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
