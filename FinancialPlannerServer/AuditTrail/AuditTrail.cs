using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer.AuditTrail
{
    public partial class AuditTrail : Form
    {
        private const string AUDITLOGCONTROLLER ="Activities";
        DataTable _dtAuditTrail;
        public AuditTrail()
        {
            InitializeComponent();
        }

        private void AuditTrail_Load(object sender, EventArgs e)
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl +"/"+ AUDITLOGCONTROLLER;

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiurl);
            request.Method = "GET";
            String auditTrailJson = String.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);
                auditTrailJson = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }
            var auditTrailCollection = jsonSerialization.DeserializeFromString<Result<List<Activities>>>(auditTrailJson);

            if (auditTrailCollection.Value != null)
            {
                _dtAuditTrail = ListtoDataTable.ToDataTable(auditTrailCollection.Value);
                dtGridAuditTrail.DataSource = _dtAuditTrail;
                gridDisplaySetting();
            }
        }

        private void gridDisplaySetting()
        {
            dtGridAuditTrail.Columns["ID"].Visible = false;          
        }

    }
}
