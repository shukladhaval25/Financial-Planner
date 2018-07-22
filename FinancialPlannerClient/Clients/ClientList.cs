using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerClient.Clients
{
    public partial class ClientList : Form
    {
        public ClientList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Client frmClient = new Client();
            frmClient.TopLevel = false;
            splitContainer.Panel2.Controls.Add(frmClient);
            frmClient.Dock = DockStyle.Fill;
            frmClient.Show();
        }
    }
}
