using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jeep.View
{
    public partial class DriverForm : Form
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=jeepney");

        private Guna2ShadowForm shadowForm;
        private bool isEdit = false;
        private int selectedDriverID; // add this at class level
        public DriverForm()
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);
            LoadOperators();
            cmbOperator.SelectedIndexChanged += cmbOperator_SelectedIndexChanged;
        }
        public DriverForm(bool isEdit, int driverID = 0)
        {
            InitializeComponent();
            shadowForm = new Guna2ShadowForm();
            shadowForm.SetShadowForm(this);

            this.isEdit = isEdit;
            selectedDriverID = driverID;

            LoadOperators();
            cmbOperator.SelectedIndexChanged += cmbOperator_SelectedIndexChanged;

            if (isEdit)
            {
                lbl_title.Text = "Edit Driver";
                btn_add.Visible = false;
                btn_edit.Visible = true;
                LoadDriverData(driverID);
            }
        }
        private void LoadOperators()
        {
            con.Open();
            string query = @"SELECT 
                        o.OperatorID,
                        o.OperatorName,
                        o.OrganizationID,
                        org.OrganizationName
                     FROM operator o
                     LEFT JOIN organization org ON o.OrganizationID = org.OrganizationID";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            cmbOperator.DataSource = dt;
            cmbOperator.DisplayMember = "OperatorName";  
            cmbOperator.ValueMember = "OperatorID";

            cmbOperator.SelectedIndex = -1;
            cmbOperator.Text = "Select Organization";
        }


        private void LoadDriverData(int driverID)
        {
            con.Open();
            string query = "SELECT * FROM driver WHERE DriverID=@DriverID";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@DriverID", driverID);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cmbOperator.SelectedValue = reader["OperatorID"];
                txtOrganization.Text = reader["OrganizationName"].ToString();
                txtFirstName.Text = reader["FirstName"].ToString();
                txtMiddleName.Text = reader["MiddleName"].ToString();
                txtLastName.Text = reader["LastName"].ToString();
                txtContactNumber.Text = reader["ContactNumber"].ToString();
                txtLicensedNumber.Text = reader["LicensedNumber"].ToString();

                if (!reader.IsDBNull(reader.GetOrdinal("DriverPhoto")))
                {
                    byte[] imgBytes = (byte[])reader["DriverPhoto"];
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        guna2PictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            reader.Close();
            con.Close();
        }

        private int selectedOrganizationID = 0;
        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperator.SelectedItem is DataRowView drv)
            {
               
                selectedOrganizationID = Convert.ToInt32(drv["OrganizationID"]);

                
                txtOrganization.Text = drv["OrganizationName"].ToString();
            }
        }

    

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ✅ Safely convert image to byte array
        private byte[] GetImageBytes()
        {
            try
            {
                if (guna2PictureBox1.Image == null)
                    return null;

                using (MemoryStream ms = new MemoryStream())
                {
                    // Copy the image instead of saving directly to avoid GDI+ lock
                    using (Bitmap bmp = new Bitmap(guna2PictureBox1.Image))
                    {
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    return ms.ToArray();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error processing image. Please try uploading again.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // ✅ Upload Button (unchanged, safe)
        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select Driver Photo";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Load image safely
                    using (var imgTemp = Image.FromFile(ofd.FileName))
                    {
                        guna2PictureBox1.Image = new Bitmap(imgTemp);
                    }
                }
            }
        }
        private bool ValidateInputs()
        {
            // 🔹 First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text.Trim(), @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("First name should contain only letters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Middle Name
            if (!string.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtMiddleName.Text.Trim(), @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Middle name should contain only letters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (txtMiddleName.Text.Length > 20)
                {
                    MessageBox.Show("Middle name should not exceed 20 characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // 🔹 Last Name
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text.Trim(), @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Last name should contain only letters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Contact Number
            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                MessageBox.Show("Contact number is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtContactNumber.Text.Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("Contact number should contain only digits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 License Number
            if (string.IsNullOrWhiteSpace(txtLicensedNumber.Text))
            {
                MessageBox.Show("License number is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLicensedNumber.Text.Trim(), @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("License number should contain only letters and numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Operator Name
            if (cmbOperator.SelectedIndex == -1)
            {
                MessageBox.Show("Operator’s name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(cmbOperator.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Operator’s name should contain only letters and spaces.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Organization Name
            if (string.IsNullOrWhiteSpace(txtOrganization.Text))
            {
                MessageBox.Show("Organization name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtOrganization.Text.Trim(), @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Organization name should contain only letters, numbers, and spaces.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            byte[] driverPhoto = GetImageBytes();

            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=jeepney"))
            {
                con.Open();
                string query = @"INSERT INTO driver 
                        (OperatorID, OrganizationName, FirstName, MiddleName, LastName, ContactNumber, LicensedNumber, DriverPhoto)
                        VALUES (@OperatorID, @OrganizationName, @FirstName, @MiddleName, @LastName, @ContactNumber, @LicensedNumber, @DriverPhoto)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@OperatorID", cmbOperator.SelectedValue);
                cmd.Parameters.AddWithValue("@OrganizationName", txtOrganization.Text.Trim());
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim());
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@LicensedNumber", txtLicensedNumber.Text.Trim());
                cmd.Parameters.Add("@DriverPhoto", MySqlDbType.LongBlob).Value = (object)driverPhoto ?? DBNull.Value;

                try
                {
                    cmd.ExecuteNonQuery();
                    // ✅ Audit log for Add
                    AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Add", "Drivers",
                        $"Added driver '{txtFirstName} + {txtLastName}' under organization '{txtOrganization}'");
                    MessageBox.Show("Driver added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding driver: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            byte[] driverPhoto = GetImageBytes();

            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=jeepney"))
            {
                con.Open();
                string query = @"UPDATE driver SET 
                            OperatorID=@OperatorID,
                            OrganizationName=@OrganizationName,
                            FirstName=@FirstName,
                            MiddleName=@MiddleName,
                            LastName=@LastName,
                            ContactNumber=@ContactNumber,
                            LicensedNumber=@LicensedNumber,
                            DriverPhoto=@DriverPhoto
                        WHERE DriverID=@DriverID";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@OperatorID", cmbOperator.SelectedValue);
                cmd.Parameters.AddWithValue("@OrganizationName", txtOrganization.Text.Trim());
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim());
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@LicensedNumber", txtLicensedNumber.Text.Trim());
                cmd.Parameters.Add("@DriverPhoto", MySqlDbType.LongBlob).Value = (object)driverPhoto ?? DBNull.Value;
                cmd.Parameters.AddWithValue("@DriverID", selectedDriverID);

                try
                {
                    cmd.ExecuteNonQuery();
                    AuditHelper.Log(CurrentUser.Username, CurrentUser.Role, "Edit", "Drivers",
              $"Updated driver '{txtFirstName} + {txtLastName} ' under organization '{txtOrganization}'");

                    MessageBox.Show("Driver updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating driver: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }

        private void DriverForm_Load(object sender, EventArgs e)
        {

        }
    }
}
