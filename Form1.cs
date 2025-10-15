using Jeep.View;
using System;
using System.Windows.Forms;

namespace Jeep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }




        private void btn_ok_Click(object sender, EventArgs e)
        {
            using (var form = new MainForm())
            {
                form.ShowDialog();
                this.Hide();
            }


        }
    }
}
