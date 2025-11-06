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
    public partial class RoutesForm : Form
    {
        public RoutesForm()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

      

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new SearchForm();
            form.ShowDialog();
            this.Close();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            string selectedRoute = "Bagumbayan - Pasig";

            try
            {
                var mapForm = new RoutesMapForm(selectedRoute);
                mapForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open route map: " + ex.Message);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string selectedRoute = "FortBonifacio - Market-Market";

            try
            {
                var mapForm = new RoutesMapForm(selectedRoute);
                mapForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open route map: " + ex.Message);
            }

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoutesForm_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string selectedRoute = "Guadalupe - Taguig-Tipas";

            try
            {
                var mapForm = new RoutesMapForm(selectedRoute);
                mapForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open route map: " + ex.Message);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            string selectedRoute = "Pateros - Market-Market";

            try
            {
                var mapForm = new RoutesMapForm(selectedRoute);
                mapForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open route map: " + ex.Message);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string selectedRoute = "Guadalupe - FTI";

            try
            {
                var mapForm = new RoutesMapForm(selectedRoute);
                mapForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open route map: " + ex.Message);
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string selectedRoute = "Pasig - Taguig";

            try
            {
                var mapForm = new RoutesMapForm(selectedRoute);
                mapForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open route map: " + ex.Message);
            }
        }
    }
}
