using System;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class AuditTrailControl : UserControl
    {
        public AuditTrailControl()
        {
            InitializeComponent();
        }

        private void AuditTrailControl_Load(object sender, EventArgs e)
        {
            dgv_audit_trail.Rows.Add("NAJIAH", "ADMIN", "iNSERT", "CATEGORY", "iNSERT: CATEGORY NAME", "09/10/2025");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
