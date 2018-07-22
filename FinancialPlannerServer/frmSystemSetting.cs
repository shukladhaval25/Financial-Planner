using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer
{
    public partial class frmSystemSetting : Form
    {
       
        public frmSystemSetting()
        {
            InitializeComponent();
        }

        private void frmSystemSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnSaveSMTPSetting_Click(object sender, EventArgs e)
        {

        }
    }
}
