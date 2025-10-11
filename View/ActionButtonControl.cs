using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class ActionButtonControl : UserControl
    {
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;
        public ActionButtonControl()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, e);
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, e);
        }
    }
}
