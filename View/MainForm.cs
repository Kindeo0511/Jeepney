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
        public void LoadDriver()
        {

            dgv_container.Controls.Clear();


            var drivers = new DriverControl();
            drivers.Dock = DockStyle.Fill;


            dgv_container.Controls.Add(drivers);


        }

        public void LoadRoute()
        {

            dgv_container.Controls.Clear();


            var route = new RouteControl();
            route.Dock = DockStyle.Fill;


            dgv_container.Controls.Add(route);


        }
        public void LoadJeepney()
        {

            dgv_container.Controls.Clear();


            var jeepney = new JeepneyControl();
            jeepney.Dock = DockStyle.Fill;


            dgv_container.Controls.Add(jeepney);


        }

        public void LoadFarePayment()
        {

            dgv_container.Controls.Clear();


            var farePayment = new FarePaymentControl();
            farePayment.Dock = DockStyle.Fill;


            dgv_container.Controls.Add(farePayment);


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

        private void btn_driver_Click(object sender, EventArgs e)
        {
            LoadDriver();
        }

        private void btn_route_Click(object sender, EventArgs e)
        {
            LoadRoute();
        }

        private void btn_jeepney_Click(object sender, EventArgs e)
        {
            LoadJeepney();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            LoadFarePayment();
        }
    }
}
