namespace Jeep.View
{
    partial class OperatorsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorsControl));
            this.dgv_operator = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Action = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_operator)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_operator
            // 
            this.dgv_operator.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_operator.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_operator.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_operator.BackgroundColor = System.Drawing.Color.White;
            this.dgv_operator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_operator.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_operator.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_operator.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_operator.ColumnHeadersHeight = 40;
            this.dgv_operator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.btn_edit,
            this.Action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_operator.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_operator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_operator.EnableHeadersVisualStyles = false;
            this.dgv_operator.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_operator.Location = new System.Drawing.Point(0, 68);
            this.dgv_operator.Name = "dgv_operator";
            this.dgv_operator.RowHeadersVisible = false;
            this.dgv_operator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_operator.Size = new System.Drawing.Size(837, 292);
            this.dgv_operator.TabIndex = 7;
            this.dgv_operator.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_operator.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_operator.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_operator.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_operator.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_operator.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_operator.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_operator.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_operator.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.dgv_operator.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_operator.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_operator.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_operator.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_operator.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_operator.ThemeStyle.ReadOnly = false;
            this.dgv_operator.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_operator.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_operator.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_operator.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_operator.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_operator.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_operator.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_operator.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_operator_CellClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderThickness = 20;
            this.guna2Panel1.Controls.Add(this.btn_add);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(-1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(837, 68);
            this.guna2Panel1.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_add.BorderColor = System.Drawing.Color.Red;
            this.btn_add.BorderRadius = 15;
            this.btn_add.BorderThickness = 2;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_add.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.Color.Transparent;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Red;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(646, 14);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(130, 45);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add Operator";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(18, 32);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(95, 27);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Operator";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Operator\'s Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "No. of Vehicle Possessed";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "LTFRB Franchise No.";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Organization’s Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Contact Number";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            // 
            // btn_edit
            // 
            this.btn_edit.HeaderText = "Action";
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Image = ((System.Drawing.Image)(resources.GetObject("Action.Image")));
            this.Action.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Action.Name = "Action";
            // 
            // OperatorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_operator);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "OperatorsControl";
            this.Size = new System.Drawing.Size(837, 360);
            this.Load += new System.EventHandler(this.OperatorsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_operator)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_operator;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn btn_edit;
        private System.Windows.Forms.DataGridViewImageColumn Action;
    }
}
