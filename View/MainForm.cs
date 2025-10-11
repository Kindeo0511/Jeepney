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
           
        }
        public void LoadUsers() 
        {
           
            dgv_container.Controls.Clear();

   
            var userControl = new UsersControl();
            userControl.Dock = DockStyle.Fill; 

          
            dgv_container.Controls.Add(userControl);


        }
        public void LoadBrgy()
        {

            dgv_container.Controls.Clear();


            var brgyControl = new BaranggayControl();
            brgyControl.Dock = DockStyle.Fill;


            dgv_container.Controls.Add(brgyControl);


        }
        public void LoadOrganization()
        {

            dgv_container.Controls.Clear();


            var organization = new OrganizationControl();
            organization.Dock = DockStyle.Fill;


            dgv_container.Controls.Add(organization);


        }
        public void LoadOperator()
        {

            dgv_container.Controls.Clear();


            var operators = new OperatorsControl();
            operators.Dock = DockStyle.Fill;


            dgv_container.Controls.Add(operators);


        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btn_brgy_Click(object sender, EventArgs e)
        {
            LoadBrgy();
        }

        private void btn_organization_Click(object sender, EventArgs e)
        {
            LoadOrganization();
        }

        private void btn_operator_Click(object sender, EventArgs e)
        {
            LoadOperator();
        }
    }
}
