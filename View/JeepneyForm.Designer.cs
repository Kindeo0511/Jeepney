namespace Jeep.View
{
    partial class JeepneyForm
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
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.txtDriverFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPlateNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLicendsedNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOperator = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lbl_title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtRouteTaken = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbOrganization = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.AutoRoundedCorners = true;
            this.btn_edit.BorderRadius = 20;
            this.btn_edit.CheckedState.Parent = this.btn_edit;
            this.btn_edit.CustomImages.Parent = this.btn_edit;
            this.btn_edit.FillColor = System.Drawing.Color.Red;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.HoverState.Parent = this.btn_edit;
            this.btn_edit.Location = new System.Drawing.Point(265, 386);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ShadowDecoration.Parent = this.btn_edit;
            this.btn_edit.Size = new System.Drawing.Size(133, 43);
            this.btn_edit.TabIndex = 80;
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
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.HoverState.Parent = this.btn_cancel;
            this.btn_cancel.Location = new System.Drawing.Point(645, 386);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ShadowDecoration.Parent = this.btn_cancel;
            this.btn_cancel.Size = new System.Drawing.Size(133, 43);
            this.btn_cancel.TabIndex = 79;
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
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Location = new System.Drawing.Point(265, 386);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(133, 43);
            this.btn_add.TabIndex = 78;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtDriverFullname
            // 
            this.txtDriverFullname.BorderRadius = 15;
            this.txtDriverFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverFullname.DefaultText = "";
            this.txtDriverFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDriverFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDriverFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverFullname.DisabledState.Parent = this.txtDriverFullname;
            this.txtDriverFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverFullname.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtDriverFullname.FocusedState.Parent = this.txtDriverFullname;
            this.txtDriverFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtDriverFullname.ForeColor = System.Drawing.Color.Black;
            this.txtDriverFullname.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtDriverFullname.HoverState.Parent = this.txtDriverFullname;
            this.txtDriverFullname.Location = new System.Drawing.Point(395, 279);
            this.txtDriverFullname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDriverFullname.Name = "txtDriverFullname";
            this.txtDriverFullname.PasswordChar = '\0';
            this.txtDriverFullname.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtDriverFullname.PlaceholderText = "End time";
            this.txtDriverFullname.ReadOnly = true;
            this.txtDriverFullname.SelectedText = "";
            this.txtDriverFullname.ShadowDecoration.Parent = this.txtDriverFullname;
            this.txtDriverFullname.Size = new System.Drawing.Size(267, 43);
            this.txtDriverFullname.TabIndex = 76;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.BorderRadius = 15;
            this.txtPlateNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateNumber.DefaultText = "";
            this.txtPlateNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlateNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlateNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNumber.DisabledState.Parent = this.txtPlateNumber;
            this.txtPlateNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNumber.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtPlateNumber.FocusedState.Parent = this.txtPlateNumber;
            this.txtPlateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtPlateNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPlateNumber.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtPlateNumber.HoverState.Parent = this.txtPlateNumber;
            this.txtPlateNumber.Location = new System.Drawing.Point(29, 162);
            this.txtPlateNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.PasswordChar = '\0';
            this.txtPlateNumber.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtPlateNumber.PlaceholderText = "From";
            this.txtPlateNumber.SelectedText = "";
            this.txtPlateNumber.ShadowDecoration.Parent = this.txtPlateNumber;
            this.txtPlateNumber.Size = new System.Drawing.Size(267, 43);
            this.txtPlateNumber.TabIndex = 74;
            // 
            // txtLicendsedNumber
            // 
            this.txtLicendsedNumber.BorderRadius = 15;
            this.txtLicendsedNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicendsedNumber.DefaultText = "";
            this.txtLicendsedNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLicendsedNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLicendsedNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicendsedNumber.DisabledState.Parent = this.txtLicendsedNumber;
            this.txtLicendsedNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicendsedNumber.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtLicendsedNumber.FocusedState.Parent = this.txtLicendsedNumber;
            this.txtLicendsedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtLicendsedNumber.ForeColor = System.Drawing.Color.Black;
            this.txtLicendsedNumber.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtLicendsedNumber.HoverState.Parent = this.txtLicendsedNumber;
            this.txtLicendsedNumber.Location = new System.Drawing.Point(43, 279);
            this.txtLicendsedNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLicendsedNumber.Name = "txtLicendsedNumber";
            this.txtLicendsedNumber.PasswordChar = '\0';
            this.txtLicendsedNumber.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtLicendsedNumber.PlaceholderText = "Start time";
            this.txtLicendsedNumber.SelectedText = "";
            this.txtLicendsedNumber.ShadowDecoration.Parent = this.txtLicendsedNumber;
            this.txtLicendsedNumber.Size = new System.Drawing.Size(267, 43);
            this.txtLicendsedNumber.TabIndex = 72;
            // 
            // txtOperator
            // 
            this.txtOperator.BorderRadius = 15;
            this.txtOperator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOperator.DefaultText = "";
            this.txtOperator.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOperator.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOperator.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOperator.DisabledState.Parent = this.txtOperator;
            this.txtOperator.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOperator.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtOperator.FocusedState.Parent = this.txtOperator;
            this.txtOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtOperator.ForeColor = System.Drawing.Color.Black;
            this.txtOperator.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtOperator.HoverState.Parent = this.txtOperator;
            this.txtOperator.Location = new System.Drawing.Point(764, 162);
            this.txtOperator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.PasswordChar = '\0';
            this.txtOperator.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtOperator.PlaceholderText = "Possible stop over";
            this.txtOperator.SelectedText = "";
            this.txtOperator.ShadowDecoration.Parent = this.txtOperator;
            this.txtOperator.Size = new System.Drawing.Size(267, 43);
            this.txtOperator.TabIndex = 70;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = false;
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(16, 32);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(233, 37);
            this.lbl_title.TabIndex = 65;
            this.lbl_title.Text = "Jeepney Registration";
            this.lbl_title.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.lbl_title;
            // 
            // txtRouteTaken
            // 
            this.txtRouteTaken.BorderRadius = 15;
            this.txtRouteTaken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRouteTaken.DefaultText = "";
            this.txtRouteTaken.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRouteTaken.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRouteTaken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRouteTaken.DisabledState.Parent = this.txtRouteTaken;
            this.txtRouteTaken.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRouteTaken.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtRouteTaken.FocusedState.Parent = this.txtRouteTaken;
            this.txtRouteTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtRouteTaken.ForeColor = System.Drawing.Color.Black;
            this.txtRouteTaken.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtRouteTaken.HoverState.Parent = this.txtRouteTaken;
            this.txtRouteTaken.Location = new System.Drawing.Point(764, 279);
            this.txtRouteTaken.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRouteTaken.Name = "txtRouteTaken";
            this.txtRouteTaken.PasswordChar = '\0';
            this.txtRouteTaken.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtRouteTaken.PlaceholderText = "Possible stop over";
            this.txtRouteTaken.SelectedText = "";
            this.txtRouteTaken.ShadowDecoration.Parent = this.txtRouteTaken;
            this.txtRouteTaken.Size = new System.Drawing.Size(267, 43);
            this.txtRouteTaken.TabIndex = 81;
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.AutoRoundedCorners = true;
            this.cmbOrganization.BackColor = System.Drawing.Color.Transparent;
            this.cmbOrganization.BorderRadius = 17;
            this.cmbOrganization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganization.FocusedColor = System.Drawing.Color.Empty;
            this.cmbOrganization.FocusedState.Parent = this.cmbOrganization;
            this.cmbOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbOrganization.ForeColor = System.Drawing.Color.Black;
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.HoverState.Parent = this.cmbOrganization;
            this.cmbOrganization.ItemHeight = 30;
            this.cmbOrganization.ItemsAppearance.Parent = this.cmbOrganization;
            this.cmbOrganization.Location = new System.Drawing.Point(395, 164);
            this.cmbOrganization.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.ShadowDecoration.Parent = this.cmbOrganization;
            this.cmbOrganization.Size = new System.Drawing.Size(265, 36);
            this.cmbOrganization.TabIndex = 82;
            this.cmbOrganization.SelectedIndexChanged += new System.EventHandler(this.cmbOrganization_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(25, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Jeepney Plate Number\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(404, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Organization Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(773, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Operators Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(39, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Driver Licensed Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(404, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 87;
            this.label5.Text = "Driver Full Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(773, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 88;
            this.label6.Text = "Route Taken";
            // 
            // JeepneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOrganization);
            this.Controls.Add(this.txtRouteTaken);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtDriverFullname);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.txtLicendsedNumber);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JeepneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JeepneyForm";
            this.Load += new System.EventHandler(this.JeepneyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2TextBox txtDriverFullname;
        private Guna.UI2.WinForms.Guna2TextBox txtPlateNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtLicendsedNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtOperator;
        public Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_title;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox txtRouteTaken;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOrganization;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}