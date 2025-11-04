namespace Jeep.View
{
    partial class DriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverForm));
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.cmbOperator = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLicensedNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOrganization = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pictureBox_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.AutoRoundedCorners = true;
            this.btn_edit.BorderRadius = 20;
            this.btn_edit.CheckedState.Parent = this.btn_edit;
            this.btn_edit.CustomImages.Parent = this.btn_edit;
            this.btn_edit.FillColor = System.Drawing.Color.Red;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.HoverState.Parent = this.btn_edit;
            this.btn_edit.Location = new System.Drawing.Point(755, 427);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ShadowDecoration.Parent = this.btn_edit;
            this.btn_edit.Size = new System.Drawing.Size(133, 43);
            this.btn_edit.TabIndex = 44;
            this.btn_edit.Text = "Confirm";
            this.btn_edit.Visible = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoRoundedCorners = true;
            this.btn_cancel.BorderRadius = 20;
            this.btn_cancel.CheckedState.Parent = this.btn_cancel;
            this.btn_cancel.CustomImages.Parent = this.btn_cancel;
            this.btn_cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.HoverState.Parent = this.btn_cancel;
            this.btn_cancel.Location = new System.Drawing.Point(955, 427);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ShadowDecoration.Parent = this.btn_cancel;
            this.btn_cancel.Size = new System.Drawing.Size(133, 43);
            this.btn_cancel.TabIndex = 43;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.BorderRadius = 20;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.Color.Red;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Location = new System.Drawing.Point(755, 427);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(133, 43);
            this.btn_add.TabIndex = 42;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cmbOperator
            // 
            this.cmbOperator.AutoRoundedCorners = true;
            this.cmbOperator.BackColor = System.Drawing.Color.Transparent;
            this.cmbOperator.BorderColor = System.Drawing.Color.Black;
            this.cmbOperator.BorderRadius = 19;
            this.cmbOperator.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.FocusedColor = System.Drawing.Color.Red;
            this.cmbOperator.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.cmbOperator.FocusedState.Parent = this.cmbOperator;
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbOperator.ForeColor = System.Drawing.Color.Black;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.HoverState.BorderColor = System.Drawing.Color.Red;
            this.cmbOperator.HoverState.Parent = this.cmbOperator;
            this.cmbOperator.ItemHeight = 35;
            this.cmbOperator.ItemsAppearance.Parent = this.cmbOperator;
            this.cmbOperator.Location = new System.Drawing.Point(53, 336);
            this.cmbOperator.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.ShadowDecoration.Parent = this.cmbOperator;
            this.cmbOperator.Size = new System.Drawing.Size(265, 41);
            this.cmbOperator.StartIndex = 0;
            this.cmbOperator.TabIndex = 41;
            this.cmbOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLicensedNumber
            // 
            this.txtLicensedNumber.BorderColor = System.Drawing.Color.Black;
            this.txtLicensedNumber.BorderRadius = 15;
            this.txtLicensedNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicensedNumber.DefaultText = "";
            this.txtLicensedNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLicensedNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLicensedNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicensedNumber.DisabledState.Parent = this.txtLicensedNumber;
            this.txtLicensedNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicensedNumber.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtLicensedNumber.FocusedState.Parent = this.txtLicensedNumber;
            this.txtLicensedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtLicensedNumber.ForeColor = System.Drawing.Color.Black;
            this.txtLicensedNumber.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtLicensedNumber.HoverState.Parent = this.txtLicensedNumber;
            this.txtLicensedNumber.Location = new System.Drawing.Point(373, 224);
            this.txtLicensedNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLicensedNumber.Name = "txtLicensedNumber";
            this.txtLicensedNumber.PasswordChar = '\0';
            this.txtLicensedNumber.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtLicensedNumber.PlaceholderText = "";
            this.txtLicensedNumber.SelectedText = "";
            this.txtLicensedNumber.ShadowDecoration.Parent = this.txtLicensedNumber;
            this.txtLicensedNumber.Size = new System.Drawing.Size(267, 43);
            this.txtLicensedNumber.TabIndex = 40;
            this.txtLicensedNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(387, 196);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(135, 22);
            this.guna2HtmlLabel6.TabIndex = 39;
            this.guna2HtmlLabel6.Text = "Licensed Number";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderColor = System.Drawing.Color.Black;
            this.txtFirstName.BorderRadius = 15;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.Parent = this.txtFirstName;
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtFirstName.FocusedState.Parent = this.txtFirstName;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtFirstName.HoverState.Parent = this.txtFirstName;
            this.txtFirstName.Location = new System.Drawing.Point(53, 114);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.ShadowDecoration.Parent = this.txtFirstName;
            this.txtFirstName.Size = new System.Drawing.Size(267, 43);
            this.txtFirstName.TabIndex = 38;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstName.TextChanged += new System.EventHandler(this.guna2TextBox6_TextChanged);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(67, 86);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(86, 22);
            this.guna2HtmlLabel7.TabIndex = 37;
            this.guna2HtmlLabel7.Text = "First Name";
            // 
            // txtOrganization
            // 
            this.txtOrganization.BorderColor = System.Drawing.Color.Black;
            this.txtOrganization.BorderRadius = 15;
            this.txtOrganization.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrganization.DefaultText = "";
            this.txtOrganization.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrganization.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrganization.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrganization.DisabledState.Parent = this.txtOrganization;
            this.txtOrganization.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrganization.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtOrganization.FocusedState.Parent = this.txtOrganization;
            this.txtOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtOrganization.ForeColor = System.Drawing.Color.Black;
            this.txtOrganization.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtOrganization.HoverState.Parent = this.txtOrganization;
            this.txtOrganization.Location = new System.Drawing.Point(373, 343);
            this.txtOrganization.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOrganization.Name = "txtOrganization";
            this.txtOrganization.PasswordChar = '\0';
            this.txtOrganization.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtOrganization.PlaceholderText = "";
            this.txtOrganization.SelectedText = "";
            this.txtOrganization.ShadowDecoration.Parent = this.txtOrganization;
            this.txtOrganization.Size = new System.Drawing.Size(267, 43);
            this.txtOrganization.TabIndex = 36;
            this.txtOrganization.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(387, 315);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(147, 22);
            this.guna2HtmlLabel4.TabIndex = 35;
            this.guna2HtmlLabel4.Text = "Organization Name";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BackColor = System.Drawing.Color.White;
            this.txtContactNumber.BorderColor = System.Drawing.Color.Black;
            this.txtContactNumber.BorderRadius = 15;
            this.txtContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactNumber.DefaultText = "";
            this.txtContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactNumber.DisabledState.Parent = this.txtContactNumber;
            this.txtContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactNumber.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtContactNumber.FocusedState.Parent = this.txtContactNumber;
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtContactNumber.ForeColor = System.Drawing.Color.Black;
            this.txtContactNumber.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtContactNumber.HoverState.Parent = this.txtContactNumber;
            this.txtContactNumber.Location = new System.Drawing.Point(53, 224);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.PasswordChar = '\0';
            this.txtContactNumber.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtContactNumber.PlaceholderText = "";
            this.txtContactNumber.SelectedText = "";
            this.txtContactNumber.ShadowDecoration.Parent = this.txtContactNumber;
            this.txtContactNumber.Size = new System.Drawing.Size(267, 43);
            this.txtContactNumber.TabIndex = 34;
            this.txtContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(67, 196);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(125, 22);
            this.guna2HtmlLabel5.TabIndex = 33;
            this.guna2HtmlLabel5.Text = "Contact Number";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(67, 306);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(118, 22);
            this.guna2HtmlLabel2.TabIndex = 32;
            this.guna2HtmlLabel2.Text = "Operator Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BorderColor = System.Drawing.Color.Black;
            this.txtMiddleName.BorderRadius = 15;
            this.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiddleName.DefaultText = "";
            this.txtMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiddleName.DisabledState.Parent = this.txtMiddleName;
            this.txtMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiddleName.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtMiddleName.FocusedState.Parent = this.txtMiddleName;
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtMiddleName.ForeColor = System.Drawing.Color.Black;
            this.txtMiddleName.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtMiddleName.HoverState.Parent = this.txtMiddleName;
            this.txtMiddleName.Location = new System.Drawing.Point(373, 114);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.PasswordChar = '\0';
            this.txtMiddleName.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtMiddleName.PlaceholderText = "";
            this.txtMiddleName.SelectedText = "";
            this.txtMiddleName.ShadowDecoration.Parent = this.txtMiddleName;
            this.txtMiddleName.Size = new System.Drawing.Size(267, 43);
            this.txtMiddleName.TabIndex = 31;
            this.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(387, 86);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(101, 22);
            this.guna2HtmlLabel3.TabIndex = 30;
            this.guna2HtmlLabel3.Text = "Middle Name";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = false;
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(28, 23);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(233, 37);
            this.lbl_title.TabIndex = 29;
            this.lbl_title.Text = "Driver Registration";
            this.lbl_title.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderColor = System.Drawing.Color.Black;
            this.txtLastName.BorderRadius = 15;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.Parent = this.txtLastName;
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtLastName.FocusedState.Parent = this.txtLastName;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtLastName.HoverState.Parent = this.txtLastName;
            this.txtLastName.Location = new System.Drawing.Point(795, 114);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtLastName.PlaceholderText = "Enter last name";
            this.txtLastName.SelectedText = "";
            this.txtLastName.ShadowDecoration.Parent = this.txtLastName;
            this.txtLastName.Size = new System.Drawing.Size(267, 43);
            this.txtLastName.TabIndex = 46;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(808, 86);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(85, 22);
            this.guna2HtmlLabel1.TabIndex = 45;
            this.guna2HtmlLabel1.Text = "Last Name";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.AutoRoundedCorners = true;
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.BorderRadius = 54;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(7, 10);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(237, 110);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 47;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(854, 228);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(147, 22);
            this.guna2HtmlLabel8.TabIndex = 48;
            this.guna2HtmlLabel8.Text = "Driver Photo Image";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.lbl_title;
            // 
            // btnUpload
            // 
            this.btnUpload.AutoRoundedCorners = true;
            this.btnUpload.BorderRadius = 20;
            this.btnUpload.CheckedState.Parent = this.btnUpload;
            this.btnUpload.CustomImages.Parent = this.btnUpload;
            this.btnUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.Black;
            this.btnUpload.HoverState.Parent = this.btnUpload;
            this.btnUpload.Location = new System.Drawing.Point(870, 177);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.ShadowDecoration.Parent = this.btnUpload;
            this.btnUpload.Size = new System.Drawing.Size(133, 43);
            this.btnUpload.TabIndex = 49;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox_Panel
            // 
            this.pictureBox_Panel.BorderColor = System.Drawing.Color.Black;
            this.pictureBox_Panel.BorderRadius = 15;
            this.pictureBox_Panel.BorderThickness = 2;
            this.pictureBox_Panel.Controls.Add(this.guna2PictureBox1);
            this.pictureBox_Panel.Location = new System.Drawing.Point(818, 257);
            this.pictureBox_Panel.Name = "pictureBox_Panel";
            this.pictureBox_Panel.ShadowDecoration.Parent = this.pictureBox_Panel;
            this.pictureBox_Panel.Size = new System.Drawing.Size(261, 129);
            this.pictureBox_Panel.TabIndex = 50;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            this.guna2Elipse3.TargetControl = this.pictureBox_Panel;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 517);
            this.Controls.Add(this.pictureBox_Panel);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.txtLicensedNumber);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.txtOrganization);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverForm";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pictureBox_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOperator;
        private Guna.UI2.WinForms.Guna2TextBox txtLicensedNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtOrganization;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtContactNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtMiddleName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_title;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnUpload;
        private Guna.UI2.WinForms.Guna2Panel pictureBox_Panel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}