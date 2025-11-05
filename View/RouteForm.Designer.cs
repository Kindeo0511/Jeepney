namespace Jeep.View
{
    partial class RouteForm
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
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.cmbOrganization = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStopOver = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lstStopovers = new System.Windows.Forms.ListBox();
            this.btnRemoveStopover = new Guna.UI2.WinForms.Guna2Button();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.lbl_title;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = false;
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(16, 15);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(233, 37);
            this.lbl_title.TabIndex = 49;
            this.lbl_title.Text = "Route Registration";
            this.lbl_title.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
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
            this.btn_edit.Location = new System.Drawing.Point(381, 369);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ShadowDecoration.Parent = this.btn_edit;
            this.btn_edit.Size = new System.Drawing.Size(133, 43);
            this.btn_edit.TabIndex = 64;
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
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.HoverState.Parent = this.btn_cancel;
            this.btn_cancel.Location = new System.Drawing.Point(645, 369);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ShadowDecoration.Parent = this.btn_cancel;
            this.btn_cancel.Size = new System.Drawing.Size(133, 43);
            this.btn_cancel.TabIndex = 63;
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
            this.btn_add.Location = new System.Drawing.Point(381, 369);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(133, 43);
            this.btn_add.TabIndex = 62;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.AutoRoundedCorners = true;
            this.cmbOrganization.BackColor = System.Drawing.Color.Transparent;
            this.cmbOrganization.BorderColor = System.Drawing.Color.Black;
            this.cmbOrganization.BorderRadius = 19;
            this.cmbOrganization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganization.FocusedColor = System.Drawing.Color.Red;
            this.cmbOrganization.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.cmbOrganization.FocusedState.Parent = this.cmbOrganization;
            this.cmbOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbOrganization.ForeColor = System.Drawing.Color.Black;
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.HoverState.BorderColor = System.Drawing.Color.Red;
            this.cmbOrganization.HoverState.Parent = this.cmbOrganization;
            this.cmbOrganization.ItemHeight = 35;
            this.cmbOrganization.Items.AddRange(new object[] {
            "BOSSING"});
            this.cmbOrganization.ItemsAppearance.Parent = this.cmbOrganization;
            this.cmbOrganization.Location = new System.Drawing.Point(764, 263);
            this.cmbOrganization.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.ShadowDecoration.Parent = this.cmbOrganization;
            this.cmbOrganization.Size = new System.Drawing.Size(265, 41);
            this.cmbOrganization.StartIndex = 0;
            this.cmbOrganization.TabIndex = 61;
            // 
            // txtFrom
            // 
            this.txtFrom.BorderColor = System.Drawing.Color.Black;
            this.txtFrom.BorderRadius = 15;
            this.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.DefaultText = "FTI";
            this.txtFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.DisabledState.Parent = this.txtFrom;
            this.txtFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtFrom.FocusedState.Parent = this.txtFrom;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtFrom.ForeColor = System.Drawing.Color.Black;
            this.txtFrom.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtFrom.HoverState.Parent = this.txtFrom;
            this.txtFrom.Location = new System.Drawing.Point(43, 149);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '\0';
            this.txtFrom.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtFrom.PlaceholderText = "";
            this.txtFrom.SelectedText = "";
            this.txtFrom.SelectionStart = 3;
            this.txtFrom.ShadowDecoration.Parent = this.txtFrom;
            this.txtFrom.Size = new System.Drawing.Size(267, 43);
            this.txtFrom.TabIndex = 58;
            // 
            // txtStopOver
            // 
            this.txtStopOver.BorderColor = System.Drawing.Color.Black;
            this.txtStopOver.BorderRadius = 15;
            this.txtStopOver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStopOver.DefaultText = "GATE 3";
            this.txtStopOver.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStopOver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStopOver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStopOver.DisabledState.Parent = this.txtStopOver;
            this.txtStopOver.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStopOver.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtStopOver.FocusedState.Parent = this.txtStopOver;
            this.txtStopOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtStopOver.ForeColor = System.Drawing.Color.Black;
            this.txtStopOver.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtStopOver.HoverState.Parent = this.txtStopOver;
            this.txtStopOver.Location = new System.Drawing.Point(764, 145);
            this.txtStopOver.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStopOver.Name = "txtStopOver";
            this.txtStopOver.PasswordChar = '\0';
            this.txtStopOver.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtStopOver.PlaceholderText = "Possible stop over";
            this.txtStopOver.SelectedText = "";
            this.txtStopOver.SelectionStart = 6;
            this.txtStopOver.ShadowDecoration.Parent = this.txtStopOver;
            this.txtStopOver.Size = new System.Drawing.Size(267, 43);
            this.txtStopOver.TabIndex = 54;
            // 
            // txtTo
            // 
            this.txtTo.BorderColor = System.Drawing.Color.Black;
            this.txtTo.BorderRadius = 15;
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.DefaultText = "PASAY";
            this.txtTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.DisabledState.Parent = this.txtTo;
            this.txtTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtTo.FocusedState.Parent = this.txtTo;
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtTo.ForeColor = System.Drawing.Color.Black;
            this.txtTo.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtTo.HoverState.Parent = this.txtTo;
            this.txtTo.Location = new System.Drawing.Point(395, 145);
            this.txtTo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtTo.PlaceholderText = "To";
            this.txtTo.SelectedText = "";
            this.txtTo.SelectionStart = 5;
            this.txtTo.ShadowDecoration.Parent = this.txtTo;
            this.txtTo.Size = new System.Drawing.Size(267, 43);
            this.txtTo.TabIndex = 51;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.RosyBrown;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(143, 369);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(133, 43);
            this.guna2Button1.TabIndex = 65;
            this.guna2Button1.Text = "Add_StopOver";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lstStopovers
            // 
            this.lstStopovers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStopovers.FormattingEnabled = true;
            this.lstStopovers.ItemHeight = 23;
            this.lstStopovers.Location = new System.Drawing.Point(838, 328);
            this.lstStopovers.Name = "lstStopovers";
            this.lstStopovers.Size = new System.Drawing.Size(191, 165);
            this.lstStopovers.TabIndex = 66;
            // 
            // btnRemoveStopover
            // 
            this.btnRemoveStopover.AutoRoundedCorners = true;
            this.btnRemoveStopover.BorderRadius = 20;
            this.btnRemoveStopover.CheckedState.Parent = this.btnRemoveStopover;
            this.btnRemoveStopover.CustomImages.Parent = this.btnRemoveStopover;
            this.btnRemoveStopover.FillColor = System.Drawing.Color.RosyBrown;
            this.btnRemoveStopover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStopover.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveStopover.HoverState.Parent = this.btnRemoveStopover;
            this.btnRemoveStopover.Location = new System.Drawing.Point(143, 449);
            this.btnRemoveStopover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveStopover.Name = "btnRemoveStopover";
            this.btnRemoveStopover.ShadowDecoration.Parent = this.btnRemoveStopover;
            this.btnRemoveStopover.Size = new System.Drawing.Size(133, 43);
            this.btnRemoveStopover.TabIndex = 67;
            this.btnRemoveStopover.Text = "Remove_StopOver";
            this.btnRemoveStopover.Click += new System.EventHandler(this.btnRemoveStopover_Click);
            // 
            // timeStart
            // 
            this.timeStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(49, 282);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(200, 32);
            this.timeStart.TabIndex = 70;
            // 
            // timeEnd
            // 
            this.timeEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(408, 282);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(200, 32);
            this.timeEnd.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(45, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(404, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(773, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Possible Stop Over (Barangay)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(45, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Time Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(413, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Time End";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(773, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Organization Name";
            // 
            // RouteForm
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
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.btnRemoveStopover);
            this.Controls.Add(this.lstStopovers);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmbOrganization);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtStopOver);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RouteForm";
            this.Load += new System.EventHandler(this.RouteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_title;
        public Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOrganization;
        private Guna.UI2.WinForms.Guna2TextBox txtFrom;
        private Guna.UI2.WinForms.Guna2TextBox txtStopOver;
        private Guna.UI2.WinForms.Guna2TextBox txtTo;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ListBox lstStopovers;
        private Guna.UI2.WinForms.Guna2Button btnRemoveStopover;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}