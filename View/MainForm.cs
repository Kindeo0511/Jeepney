using System;
using System.Drawing;
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
        public void LoadDiscount()
        {

            dgv_container.Controls.Clear();


            var discount = new DIscountControl();
            discount.Dock = DockStyle.Fill;


            dgv_container.Controls.Add(discount);


        }

        public void LoadComplaintAndFeedBack()
        {

            dgv_container.Controls.Clear();


            var complaint = new ComplaintAndFeedBackControl();
            complaint.Dock = DockStyle.Fill;


            dgv_container.Controls.Add(complaint);


        }

        public void LoadAuditTrail()
        {

            dgv_container.Controls.Clear();


            var auditTrail = new AuditTrailControl();
            auditTrail.Dock = DockStyle.Fill;


            dgv_container.Controls.Add(auditTrail);


        }



        private void btn_users_Click(object sender, EventArgs e)
        {
            LoadUsers();
            SetCheckedButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btn_brgy_Click(object sender, EventArgs e)
        {
            LoadBrgy();
            SetCheckedButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btn_organization_Click(object sender, EventArgs e)
        {
            LoadOrganization();
            SetCheckedButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btn_operator_Click(object sender, EventArgs e)
        {
            LoadOperator();
            SetCheckedButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btn_driver_Click(object sender, EventArgs e)
        {
            LoadDriver();
            SetCheckedButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btn_route_Click(object sender, EventArgs e)
        {
            LoadRoute();
            SetCheckedButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btn_jeepney_Click(object sender, EventArgs e)
        {
            LoadJeepney();
            SetCheckedButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            LoadFarePayment();
            SetCheckedButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            LoadDiscount();
            SetCheckedButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btn_complain_and_feedback_Click(object sender, EventArgs e)
        {
            LoadComplaintAndFeedBack();
            SetCheckedButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btn_audit_trail_Click(object sender, EventArgs e)
        {
            LoadAuditTrail();
            SetCheckedButton((Guna.UI2.WinForms.Guna2Button)sender);
        }
        private void SetCheckedButton(Guna.UI2.WinForms.Guna2Button clickedButton)
        {
            // Loop through all controls on the form (or a panel if your buttons are inside one)
            foreach (Control ctrl in side_bar_panel.Controls) // replace sidebarPanel with your container name
            {
                if (ctrl is Guna.UI2.WinForms.Guna2Button btn)
                {
                    btn.Checked = false;
                }
            }

            // Set the clicked one to true
            clickedButton.Checked = true;
        }

        private void btn_dropdown_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(guna2HtmlLabel1, new Point(-40, guna2HtmlLabel1.Height));
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var form = new LoginForm();
            form.Show();
            this.Close();

        }
    }
}
