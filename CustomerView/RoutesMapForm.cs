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
    public partial class RoutesMapForm : Form
    {
        public RoutesMapForm()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var form = new RoutesForm();
            form.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new SearchForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
