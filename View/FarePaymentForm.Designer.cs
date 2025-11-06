namespace Jeep.View
{
    partial class FarePaymentForm
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
            this.cmbRouteTaken = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.txtBaseFare = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvStopovers = new System.Windows.Forms.DataGridView();
            this.StopoverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiscountFare = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStopovers)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRouteTaken
            // 
            this.cmbRouteTaken.AutoRoundedCorners = true;
            this.cmbRouteTaken.BackColor = System.Drawing.Color.Transparent;
            this.cmbRouteTaken.BorderColor = System.Drawing.Color.Black;
            this.cmbRouteTaken.BorderRadius = 17;
            this.cmbRouteTaken.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRouteTaken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRouteTaken.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRouteTaken.FocusedState.Parent = this.cmbRouteTaken;
            this.cmbRouteTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbRouteTaken.ForeColor = System.Drawing.Color.Black;
            this.cmbRouteTaken.FormattingEnabled = true;
            this.cmbRouteTaken.HoverState.Parent = this.cmbRouteTaken;
            this.cmbRouteTaken.ItemHeight = 30;
            this.cmbRouteTaken.ItemsAppearance.Parent = this.cmbRouteTaken;
            this.cmbRouteTaken.Location = new System.Drawing.Point(122, 155);
            this.cmbRouteTaken.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRouteTaken.Name = "cmbRouteTaken";
            this.cmbRouteTaken.ShadowDecoration.Parent = this.cmbRouteTaken;
            this.cmbRouteTaken.Size = new System.Drawing.Size(265, 36);
            this.cmbRouteTaken.TabIndex = 98;
            this.cmbRouteTaken.SelectedIndexChanged += new System.EventHandler(this.cmbRouteTaken_SelectedIndexChanged);
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
            this.lbl_title.Location = new System.Drawing.Point(51, 23);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(265, 37);
            this.lbl_title.TabIndex = 83;
            this.lbl_title.Text = "Fare Registration";
            this.lbl_title.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
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
            this.btn_edit.Location = new System.Drawing.Point(452, 268);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ShadowDecoration.Parent = this.btn_edit;
            this.btn_edit.Size = new System.Drawing.Size(133, 43);
            this.btn_edit.TabIndex = 96;
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
            this.btn_cancel.Location = new System.Drawing.Point(666, 268);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ShadowDecoration.Parent = this.btn_cancel;
            this.btn_cancel.Size = new System.Drawing.Size(133, 43);
            this.btn_cancel.TabIndex = 95;
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
            this.btn_add.Location = new System.Drawing.Point(452, 268);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(133, 43);
            this.btn_add.TabIndex = 94;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtBaseFare
            // 
            this.txtBaseFare.BorderColor = System.Drawing.Color.Black;
            this.txtBaseFare.BorderRadius = 15;
            this.txtBaseFare.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBaseFare.DefaultText = "";
            this.txtBaseFare.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBaseFare.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBaseFare.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBaseFare.DisabledState.Parent = this.txtBaseFare;
            this.txtBaseFare.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBaseFare.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtBaseFare.FocusedState.Parent = this.txtBaseFare;
            this.txtBaseFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtBaseFare.ForeColor = System.Drawing.Color.Black;
            this.txtBaseFare.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtBaseFare.HoverState.Parent = this.txtBaseFare;
            this.txtBaseFare.Location = new System.Drawing.Point(474, 155);
            this.txtBaseFare.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBaseFare.Name = "txtBaseFare";
            this.txtBaseFare.PasswordChar = '\0';
            this.txtBaseFare.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtBaseFare.PlaceholderText = "";
            this.txtBaseFare.SelectedText = "";
            this.txtBaseFare.ShadowDecoration.Parent = this.txtBaseFare;
            this.txtBaseFare.Size = new System.Drawing.Size(267, 43);
            this.txtBaseFare.TabIndex = 91;
            this.txtBaseFare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBaseFare.TextChanged += new System.EventHandler(this.txtBaseFare_TextChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(812, 242);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel4.TabIndex = 88;
            this.guna2HtmlLabel4.Text = null;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(812, 126);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel5.TabIndex = 86;
            this.guna2HtmlLabel5.Text = null;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(77, 234);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 85;
            this.guna2HtmlLabel2.Text = null;
            // 
            // dgvStopovers
            // 
            this.dgvStopovers.AllowUserToResizeColumns = false;
            this.dgvStopovers.AllowUserToResizeRows = false;
            this.dgvStopovers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStopovers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StopoverID,
            this.StopName,
            this.StopFare,
            this.DiscountFare});
            this.dgvStopovers.Location = new System.Drawing.Point(77, 347);
            this.dgvStopovers.Name = "dgvStopovers";
            this.dgvStopovers.RowHeadersWidth = 51;
            this.dgvStopovers.RowTemplate.Height = 24;
            this.dgvStopovers.Size = new System.Drawing.Size(1030, 243);
            this.dgvStopovers.TabIndex = 99;
            this.dgvStopovers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStopovers_CellEndEdit);
            // 
            // StopoverID
            // 
            this.StopoverID.HeaderText = "StopoverID";
            this.StopoverID.MinimumWidth = 6;
            this.StopoverID.Name = "StopoverID";
            this.StopoverID.Visible = false;
            this.StopoverID.Width = 125;
            // 
            // StopName
            // 
            this.StopName.HeaderText = "StopName";
            this.StopName.MinimumWidth = 6;
            this.StopName.Name = "StopName";
            this.StopName.ReadOnly = true;
            this.StopName.Width = 125;
            // 
            // StopFare
            // 
            this.StopFare.HeaderText = "StopFare";
            this.StopFare.MinimumWidth = 6;
            this.StopFare.Name = "StopFare";
            this.StopFare.Width = 125;
            // 
            // DiscountFare
            // 
            this.DiscountFare.HeaderText = "DiscountFare";
            this.DiscountFare.MinimumWidth = 6;
            this.DiscountFare.Name = "DiscountFare";
            this.DiscountFare.ReadOnly = true;
            this.DiscountFare.Width = 125;
            // 
            // txtDiscountFare
            // 
            this.txtDiscountFare.BorderColor = System.Drawing.Color.Black;
            this.txtDiscountFare.BorderRadius = 15;
            this.txtDiscountFare.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountFare.DefaultText = "";
            this.txtDiscountFare.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscountFare.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscountFare.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscountFare.DisabledState.Parent = this.txtDiscountFare;
            this.txtDiscountFare.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscountFare.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtDiscountFare.FocusedState.Parent = this.txtDiscountFare;
            this.txtDiscountFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtDiscountFare.ForeColor = System.Drawing.Color.Black;
            this.txtDiscountFare.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtDiscountFare.HoverState.Parent = this.txtDiscountFare;
            this.txtDiscountFare.Location = new System.Drawing.Point(791, 155);
            this.txtDiscountFare.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDiscountFare.Name = "txtDiscountFare";
            this.txtDiscountFare.PasswordChar = '\0';
            this.txtDiscountFare.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtDiscountFare.PlaceholderText = "";
            this.txtDiscountFare.ReadOnly = true;
            this.txtDiscountFare.SelectedText = "";
            this.txtDiscountFare.ShadowDecoration.Parent = this.txtDiscountFare;
            this.txtDiscountFare.Size = new System.Drawing.Size(267, 43);
            this.txtDiscountFare.TabIndex = 100;
            this.txtDiscountFare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(118, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 102;
            this.label1.Text = "Route Taken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(483, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 103;
            this.label2.Text = "BaseFare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(808, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "DiscountFare";
            // 
            // FarePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 654);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiscountFare);
            this.Controls.Add(this.dgvStopovers);
            this.Controls.Add(this.cmbRouteTaken);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtBaseFare);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FarePaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FarePaymentForm";
            this.Load += new System.EventHandler(this.FarePaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStopovers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbRouteTaken;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_title;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2TextBox txtBaseFare;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DataGridView dgvStopovers;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscountFare;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopoverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopFare;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountFare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}