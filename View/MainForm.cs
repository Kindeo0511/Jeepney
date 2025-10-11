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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add("Louis Jay", "SanSan123", "louisjaycastillo7@gmail.com", "09203101161", "Sta. Ana", "Admin");
            guna2DataGridView1.Rows.Add("Mohaifa", "Nissan", "malikmohaifa@gmail.com", "09472632013", "Maharlika", "Staff");
        }
    }
}
