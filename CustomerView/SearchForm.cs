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
        public SearchForm()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string query = txt_search.Text.Trim().ToLower();

                switch (query)
                {
                    case "bagumbayan - pasig":
                        new RoutesMapForm().Show();
                        this.Close();
                        break;
                    default:
                        MessageBox.Show("No matching form found.");
                        break;
                }

                e.SuppressKeyPress = true; // Prevents the ding sound
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var form = new RoutesForm();
            form.Show();
            this.Close();
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
