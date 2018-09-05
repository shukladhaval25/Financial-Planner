using FinancialPlanner.Common;
using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerClient.RiskProfile
{
    public partial class frmRiskProfiledReturnList : Form
    {
        private const string RISKPROFILE_GETALL = "RiskProfileReturn/GetAll";
        DataTable _dtRiskProfile;
        public frmRiskProfiledReturnList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRiskProfileReturn frmriskProfileReturn = new frmRiskProfileReturn();
            frmriskProfileReturn.TopLevel = false;
            splitContainer.Panel2.Controls.Add(frmriskProfileReturn);
            frmriskProfileReturn.Dock = DockStyle.Fill;
            frmriskProfileReturn.Show();
        }

        private void frmRiskProfiledReturnList_Load(object sender, EventArgs e)
        {
            loadRiskProfileData();
        }

        private void loadRiskProfileData()
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl +"/"+ RISKPROFILE_GETALL;

            RestAPIExecutor restApiExecutor = new RestAPIExecutor();

            var restResult = restApiExecutor.Execute<List<RiskProfiledReturnMaster>>(apiurl, null, "GET");

            if (jsonSerialization.IsValidJson(restResult.ToString()))
            {
                var riskProfileColleection = jsonSerialization.DeserializeFromString<List<RiskProfiledReturnMaster>>(restResult.ToString());
                _dtRiskProfile = ListtoDataTable.ToDataTable(riskProfileColleection);
                fillTreeviewData(_dtRiskProfile);
            }
            else
                MessageBox.Show(restResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fillTreeviewData(DataTable dtRiskPorifles)
        {
            trvList.Nodes.Clear();
            trvList.Nodes.Add("0", "Risk Profile", 5);
            foreach (DataRow dr in dtRiskPorifles.Rows)
            {
                TreeNode node = new TreeNode();
                node.Tag = dr.Field<string>("ID");
                node.Text = dr.Field<string>("Name");
                node.ImageIndex = 9;
                node.ToolTipText = dr.Field<string>("Name");
                trvList.Nodes[0].Nodes.Add(node);
            }
            trvList.ExpandAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (trvList.SelectedNode != null)
            {
                RiskProfiledReturnMaster riskProfileMaster = convertSelectedRowDataToRiskProfileMastser();
                frmRiskProfileReturn frmriskProfileReturn = new frmRiskProfileReturn(riskProfileMaster);
                frmriskProfileReturn.TopLevel = false;
                splitContainer.Panel2.Controls.Add(frmriskProfileReturn);
                frmriskProfileReturn.Dock = DockStyle.Fill;
                frmriskProfileReturn.Show();             
            }
        }

        private RiskProfiledReturnMaster convertSelectedRowDataToRiskProfileMastser()
        {
            RiskProfiledReturnMaster riskProfileMaster = new RiskProfiledReturnMaster();
            if (trvList.SelectedNode.Tag != null)
            {
                DataRow dr = getSelectedDataRow(int.Parse(trvList.SelectedNode.Tag.ToString()));
                if (dr != null)
                {
                    riskProfileMaster.Id = int.Parse(dr.Field<string>("ID"));
                    riskProfileMaster.Name = dr.Field<string>("Name");
                    riskProfileMaster.Description  = dr.Field<string>("Description");
                    riskProfileMaster.UpdatedByUserName = Program.CurrentUser.UserName;
                }
            }
            return riskProfileMaster;
        }

        private DataRow getSelectedDataRow(int id)
        {
            DataRow[] rows = _dtRiskProfile.Select("Id = " + id);
            foreach (DataRow dr in rows)
            {
                return dr;
            }
            return null;
        }
    }
}
