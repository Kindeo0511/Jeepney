using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Jeep.View
{
    public partial class OrganizationControl : UserControl
    {
        private int actionColumnIndex = -1;
        public OrganizationControl()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new OrganizationForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadOrganizations(); 
                }
            }
        }


        private void OrganizationControl_Load(object sender, EventArgs e)
        {
            LoadOrganizations();
            actionColumnIndex = dgv_organization.Columns["action_column"].Index;
        }
        private void LoadOrganizations()
        {
            dgv_organization.Rows.Clear();

            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT OrganizationID, OrganizationName, ContactNumber, Address FROM organization";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgv_organization.Rows.Add(
                                reader["OrganizationID"],
                                reader["OrganizationName"],
                                reader["ContactNumber"],
                                reader["Address"],
                                null // action icons
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading organizations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_organization_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                    e.CellBounds.Left + padding + iconSize + 12,
                    e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize);

                e.Graphics.DrawImage(editIcon, editRect);
                e.Graphics.DrawImage(deleteIcon, deleteRect);

                e.Handled = true;
            }
        }

        private void dgv_organization_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == actionColumnIndex && e.RowIndex >= 0)
            {
                int clickX = e.Location.X;

                // ✏️ Edit
                if (clickX < 32)
                {
                    DataGridViewRow row = dgv_organization.Rows[e.RowIndex];
                    int id = Convert.ToInt32(row.Cells["OrganizationID"].Value);
                    string name = row.Cells["OrganizationName"].Value.ToString();
                    string contact = row.Cells["ContactNumber"].Value.ToString();
                    string address = row.Cells["Address"].Value.ToString();

                    using (var form = new OrganizationForm(true))
                    {
                        form.LoadOrganizationData(id, name, contact, address);
                        if (form.ShowDialog() == DialogResult.OK)
                            LoadOrganizations();
                    }
                }
                // 🗑️ Delete
                else if (clickX > 40 && clickX < 80)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this organization?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgv_organization.Rows[e.RowIndex];
                        int id = Convert.ToInt32(row.Cells["OrganizationID"].Value);
                        DeleteOrganization(id);
                        LoadOrganizations();
                    }
                }
            }
        }
        private void DeleteOrganization(int organizationID)
        {
            string connectionString = "server=localhost;user id=root;password=;database=jeepney;";
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM organization WHERE OrganizationID = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", organizationID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Organization deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Delete", "OrganizationForm",
                    $"Deleted organization '{organizationID}'");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error deleting organization: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_organization_Click(object sender, EventArgs e)
        {
            var form = new OrganizationForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadOrganizations();
       

}


private void dgv_organization_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                }
            }
        }
