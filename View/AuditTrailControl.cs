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
    }
}
