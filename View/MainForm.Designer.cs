namespace Jeep.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_header = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_dropdown = new Guna.UI2.WinForms.Guna2Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.side_bar_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_audit_trail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_discount = new Guna.UI2.WinForms.Guna2Button();
            this.btn_payment = new Guna.UI2.WinForms.Guna2Button();
            this.btn_jeepney = new Guna.UI2.WinForms.Guna2Button();
            this.btn_route = new Guna.UI2.WinForms.Guna2Button();
            this.btn_driver = new Guna.UI2.WinForms.Guna2Button();
            this.btn_operator = new Guna.UI2.WinForms.Guna2Button();
            this.btn_organization = new Guna.UI2.WinForms.Guna2Button();
            this.btn_brgy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_users = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgv_container = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_header.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.side_bar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.White;
            this.panel_header.Controls.Add(this.btn_dropdown);
            this.panel_header.Controls.Add(this.guna2HtmlLabel1);
            this.panel_header.Controls.Add(this.guna2CirclePictureBox1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_header.Name = "panel_header";
            this.panel_header.ShadowDecoration.Parent = this.panel_header;
            this.panel_header.Size = new System.Drawing.Size(1942, 76);
            this.panel_header.TabIndex = 0;
            // 
            // btn_dropdown
            // 
            this.btn_dropdown.BackColor = System.Drawing.Color.DimGray;
            this.btn_dropdown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dropdown.BackgroundImage")));
            this.btn_dropdown.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_dropdown.CheckedState.Parent = this.btn_dropdown;
            this.btn_dropdown.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_dropdown.CustomImages.Parent = this.btn_dropdown;
            this.btn_dropdown.FillColor = System.Drawing.Color.White;
            this.btn_dropdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dropdown.ForeColor = System.Drawing.Color.White;
            this.btn_dropdown.HoverState.Parent = this.btn_dropdown;
            this.btn_dropdown.Image = ((System.Drawing.Image)(resources.GetObject("btn_dropdown.Image")));
            this.btn_dropdown.Location = new System.Drawing.Point(366, 31);
            this.btn_dropdown.Name = "btn_dropdown";
            this.btn_dropdown.ShadowDecoration.Parent = this.btn_dropdown;
            this.btn_dropdown.Size = new System.Drawing.Size(37, 29);
            this.btn_dropdown.TabIndex = 6;
            this.btn_dropdown.Click += new System.EventHandler(this.btn_dropdown_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AutoSize = false;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_logout});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 57);
            // 
            // btn_logout
            // 
            this.btn_logout.AutoSize = false;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(200, 24);
            this.btn_logout.Text = "Logout";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(185, 33);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(192, 30);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Admin Users";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(39, 15);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(88, 48);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel_header;
            // 
            // side_bar_panel
            // 
            this.side_bar_panel.BackColor = System.Drawing.Color.White;
            this.side_bar_panel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.side_bar_panel.Controls.Add(this.btn_audit_trail);
            this.side_bar_panel.Controls.Add(this.btn_discount);
            this.side_bar_panel.Controls.Add(this.btn_payment);
            this.side_bar_panel.Controls.Add(this.btn_jeepney);
            this.side_bar_panel.Controls.Add(this.btn_route);
            this.side_bar_panel.Controls.Add(this.btn_driver);
            this.side_bar_panel.Controls.Add(this.btn_operator);
            this.side_bar_panel.Controls.Add(this.btn_organization);
            this.side_bar_panel.Controls.Add(this.btn_brgy);
            this.side_bar_panel.Controls.Add(this.btn_users);
            this.side_bar_panel.Location = new System.Drawing.Point(39, 105);
            this.side_bar_panel.Margin = new System.Windows.Forms.Padding(0);
            this.side_bar_panel.Name = "side_bar_panel";
            this.side_bar_panel.ShadowDecoration.Parent = this.side_bar_panel;
            this.side_bar_panel.Size = new System.Drawing.Size(364, 658);
            this.side_bar_panel.TabIndex = 1;
            // 
            // btn_audit_trail
            // 
            this.btn_audit_trail.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_audit_trail.CheckedState.Parent = this.btn_audit_trail;
            this.btn_audit_trail.CustomImages.Parent = this.btn_audit_trail;
            this.btn_audit_trail.FillColor = System.Drawing.Color.White;
            this.btn_audit_trail.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_audit_trail.ForeColor = System.Drawing.Color.Black;
            this.btn_audit_trail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_audit_trail.HoverState.Parent = this.btn_audit_trail;
            this.btn_audit_trail.Image = ((System.Drawing.Image)(resources.GetObject("btn_audit_trail.Image")));
            this.btn_audit_trail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_audit_trail.ImageOffset = new System.Drawing.Point(40, 0);
            this.btn_audit_trail.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_audit_trail.Location = new System.Drawing.Point(0, 595);
            this.btn_audit_trail.Margin = new System.Windows.Forms.Padding(4);
            this.btn_audit_trail.Name = "btn_audit_trail";
            this.btn_audit_trail.ShadowDecoration.Parent = this.btn_audit_trail;
            this.btn_audit_trail.Size = new System.Drawing.Size(364, 55);
            this.btn_audit_trail.TabIndex = 12;
            this.btn_audit_trail.Text = "Audit Trail";
            this.btn_audit_trail.Click += new System.EventHandler(this.btn_audit_trail_Click);
            // 
            // btn_discount
            // 
            this.btn_discount.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_discount.CheckedState.Parent = this.btn_discount;
            this.btn_discount.CustomImages.Parent = this.btn_discount;
            this.btn_discount.FillColor = System.Drawing.Color.White;
            this.btn_discount.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_discount.ForeColor = System.Drawing.Color.Black;
            this.btn_discount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_discount.HoverState.Parent = this.btn_discount;
            this.btn_discount.Image = ((System.Drawing.Image)(resources.GetObject("btn_discount.Image")));
            this.btn_discount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_discount.ImageOffset = new System.Drawing.Point(40, 0);
            this.btn_discount.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_discount.Location = new System.Drawing.Point(0, 532);
            this.btn_discount.Margin = new System.Windows.Forms.Padding(4);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.ShadowDecoration.Parent = this.btn_discount;
            this.btn_discount.Size = new System.Drawing.Size(364, 55);
            this.btn_discount.TabIndex = 10;
            this.btn_discount.Text = "DIscount";
            this.btn_discount.Click += new System.EventHandler(this.btn_discount_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_payment.CheckedState.Parent = this.btn_payment;
            this.btn_payment.CustomImages.Parent = this.btn_payment;
            this.btn_payment.FillColor = System.Drawing.Color.White;
            this.btn_payment.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_payment.ForeColor = System.Drawing.Color.Black;
            this.btn_payment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_payment.HoverState.Parent = this.btn_payment;
            this.btn_payment.Image = ((System.Drawing.Image)(resources.GetObject("btn_payment.Image")));
            this.btn_payment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_payment.ImageOffset = new System.Drawing.Point(40, 0);
            this.btn_payment.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_payment.Location = new System.Drawing.Point(0, 469);
            this.btn_payment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.ShadowDecoration.Parent = this.btn_payment;
            this.btn_payment.Size = new System.Drawing.Size(364, 55);
            this.btn_payment.TabIndex = 9;
            this.btn_payment.Text = "Fare/Payment";
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_jeepney
            // 
            this.btn_jeepney.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_jeepney.CheckedState.Parent = this.btn_jeepney;
            this.btn_jeepney.CustomImages.Parent = this.btn_jeepney;
            this.btn_jeepney.FillColor = System.Drawing.Color.White;
            this.btn_jeepney.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_jeepney.ForeColor = System.Drawing.Color.Black;
            this.btn_jeepney.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_jeepney.HoverState.Parent = this.btn_jeepney;
            this.btn_jeepney.Image = ((System.Drawing.Image)(resources.GetObject("btn_jeepney.Image")));
            this.btn_jeepney.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_jeepney.ImageOffset = new System.Drawing.Point(40, 0);
            this.btn_jeepney.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_jeepney.Location = new System.Drawing.Point(0, 406);
            this.btn_jeepney.Margin = new System.Windows.Forms.Padding(4);
            this.btn_jeepney.Name = "btn_jeepney";
            this.btn_jeepney.ShadowDecoration.Parent = this.btn_jeepney;
            this.btn_jeepney.Size = new System.Drawing.Size(364, 55);
            this.btn_jeepney.TabIndex = 8;
            this.btn_jeepney.Text = "Jeepney";
            this.btn_jeepney.Click += new System.EventHandler(this.btn_jeepney_Click);
            // 
            // btn_route
            // 
            this.btn_route.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_route.CheckedState.Parent = this.btn_route;
            this.btn_route.CustomImages.Parent = this.btn_route;
            this.btn_route.FillColor = System.Drawing.Color.White;
            this.btn_route.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_route.ForeColor = System.Drawing.Color.Black;
            this.btn_route.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_route.HoverState.Parent = this.btn_route;
            this.btn_route.Image = ((System.Drawing.Image)(resources.GetObject("btn_route.Image")));
            this.btn_route.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_route.ImageOffset = new System.Drawing.Point(40, 0);
            this.btn_route.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_route.Location = new System.Drawing.Point(0, 343);
            this.btn_route.Margin = new System.Windows.Forms.Padding(4);
            this.btn_route.Name = "btn_route";
            this.btn_route.ShadowDecoration.Parent = this.btn_route;
            this.btn_route.Size = new System.Drawing.Size(364, 55);
            this.btn_route.TabIndex = 7;
            this.btn_route.Text = "Routes";
            this.btn_route.Click += new System.EventHandler(this.btn_route_Click);
            // 
            // btn_driver
            // 
            this.btn_driver.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_driver.CheckedState.Parent = this.btn_driver;
            this.btn_driver.CustomImages.Parent = this.btn_driver;
            this.btn_driver.FillColor = System.Drawing.Color.White;
            this.btn_driver.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_driver.ForeColor = System.Drawing.Color.Black;
            this.btn_driver.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_driver.HoverState.Parent = this.btn_driver;
            this.btn_driver.Image = ((System.Drawing.Image)(resources.GetObject("btn_driver.Image")));
            this.btn_driver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_driver.ImageOffset = new System.Drawing.Point(40, 0);
            this.btn_driver.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_driver.Location = new System.Drawing.Point(0, 281);
            this.btn_driver.Margin = new System.Windows.Forms.Padding(4);
            this.btn_driver.Name = "btn_driver";
            this.btn_driver.ShadowDecoration.Parent = this.btn_driver;
            this.btn_driver.Size = new System.Drawing.Size(364, 55);
            this.btn_driver.TabIndex = 6;
            this.btn_driver.Text = "Drivers";
            this.btn_driver.Click += new System.EventHandler(this.btn_driver_Click);
            // 
            // btn_operator
            // 
            this.btn_operator.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_operator.CheckedState.Parent = this.btn_operator;
            this.btn_operator.CustomImages.Parent = this.btn_operator;
            this.btn_operator.FillColor = System.Drawing.Color.White;
            this.btn_operator.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_operator.ForeColor = System.Drawing.Color.Black;
            this.btn_operator.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_operator.HoverState.Parent = this.btn_operator;
            this.btn_operator.Image = ((System.Drawing.Image)(resources.GetObject("btn_operator.Image")));
            this.btn_operator.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_operator.ImageOffset = new System.Drawing.Point(40, 0);
            this.btn_operator.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_operator.Location = new System.Drawing.Point(0, 218);
            this.btn_operator.Margin = new System.Windows.Forms.Padding(4);
            this.btn_operator.Name = "btn_operator";
            this.btn_operator.ShadowDecoration.Parent = this.btn_operator;
            this.btn_operator.Size = new System.Drawing.Size(364, 55);
            this.btn_operator.TabIndex = 5;
            this.btn_operator.Text = "Operators";
            this.btn_operator.Click += new System.EventHandler(this.btn_operator_Click);
            // 
            // btn_organization
            // 
            this.btn_organization.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_organization.CheckedState.Parent = this.btn_organization;
            this.btn_organization.CustomImages.Parent = this.btn_organization;
            this.btn_organization.FillColor = System.Drawing.Color.White;
            this.btn_organization.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_organization.ForeColor = System.Drawing.Color.Black;
            this.btn_organization.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_organization.HoverState.Parent = this.btn_organization;
            this.btn_organization.Image = ((System.Drawing.Image)(resources.GetObject("btn_organization.Image")));
            this.btn_organization.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_organization.ImageOffset = new System.Drawing.Point(40, 0);
            this.btn_organization.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_organization.Location = new System.Drawing.Point(0, 155);
            this.btn_organization.Margin = new System.Windows.Forms.Padding(4);
            this.btn_organization.Name = "btn_organization";
            this.btn_organization.ShadowDecoration.Parent = this.btn_organization;
            this.btn_organization.Size = new System.Drawing.Size(364, 55);
            this.btn_organization.TabIndex = 4;
            this.btn_organization.Text = "Organizations";
            this.btn_organization.Click += new System.EventHandler(this.btn_organization_Click);
            // 
            // btn_brgy
            // 
            this.btn_brgy.BackColor = System.Drawing.Color.Transparent;
            this.btn_brgy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_brgy.CheckedState.Parent = this.btn_brgy;
            this.btn_brgy.CustomImages.Parent = this.btn_brgy;
            this.btn_brgy.FillColor = System.Drawing.Color.White;
            this.btn_brgy.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_brgy.ForeColor = System.Drawing.Color.Black;
            this.btn_brgy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_brgy.HoverState.Parent = this.btn_brgy;
            this.btn_brgy.Image = ((System.Drawing.Image)(resources.GetObject("btn_brgy.Image")));
            this.btn_brgy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_brgy.ImageOffset = new System.Drawing.Point(40, 0);
            this.btn_brgy.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_brgy.Location = new System.Drawing.Point(0, 91);
            this.btn_brgy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_brgy.Name = "btn_brgy";
            this.btn_brgy.ShadowDecoration.Parent = this.btn_brgy;
            this.btn_brgy.Size = new System.Drawing.Size(364, 55);
            this.btn_brgy.TabIndex = 3;
            this.btn_brgy.Text = "Barangay";
            this.btn_brgy.UseTransparentBackground = true;
            this.btn_brgy.Click += new System.EventHandler(this.btn_brgy_Click);
            // 
            // btn_users
            // 
            this.btn_users.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_users.CheckedState.Parent = this.btn_users;
            this.btn_users.CustomImages.Parent = this.btn_users;
            this.btn_users.FillColor = System.Drawing.Color.White;
            this.btn_users.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.Color.Black;
            this.btn_users.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.btn_users.HoverState.Parent = this.btn_users;
            this.btn_users.Image = ((System.Drawing.Image)(resources.GetObject("btn_users.Image")));
            this.btn_users.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_users.ImageOffset = new System.Drawing.Point(40, 0);
            this.btn_users.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_users.Location = new System.Drawing.Point(0, 28);
            this.btn_users.Margin = new System.Windows.Forms.Padding(4);
            this.btn_users.Name = "btn_users";
            this.btn_users.ShadowDecoration.Parent = this.btn_users;
            this.btn_users.Size = new System.Drawing.Size(364, 55);
            this.btn_users.TabIndex = 2;
            this.btn_users.Text = "Users";
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.side_bar_panel;
            // 
            // dgv_container
            // 
            this.dgv_container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_container.BackColor = System.Drawing.Color.White;
            this.dgv_container.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.dgv_container.Location = new System.Drawing.Point(437, 105);
            this.dgv_container.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_container.Name = "dgv_container";
            this.dgv_container.ShadowDecoration.Parent = this.dgv_container;
            this.dgv_container.Size = new System.Drawing.Size(1451, 542);
            this.dgv_container.TabIndex = 2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.dgv_container;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1892, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 883);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 935);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1892, 50);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 833);
            this.panel4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 26);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1942, 985);
            this.ControlBox = false;
            this.Controls.Add(this.side_bar_panel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgv_container);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_header);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_header.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.side_bar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_header;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel side_bar_panel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btn_users;
        private Guna.UI2.WinForms.Guna2Button btn_discount;
        private Guna.UI2.WinForms.Guna2Button btn_payment;
        private Guna.UI2.WinForms.Guna2Button btn_jeepney;
        private Guna.UI2.WinForms.Guna2Button btn_route;
        private Guna.UI2.WinForms.Guna2Button btn_driver;
        private Guna.UI2.WinForms.Guna2Button btn_operator;
        private Guna.UI2.WinForms.Guna2Button btn_organization;
        private Guna.UI2.WinForms.Guna2Button btn_brgy;
        private Guna.UI2.WinForms.Guna2Panel dgv_container;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Button btn_audit_trail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button btn_dropdown;
        private System.Windows.Forms.ToolStripMenuItem btn_logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
    }
}