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

namespace FinancialPlannerServer
{
    public partial class frmSystemSetting : Form
    {
        private const string GET_APPLICATIONCONFIG_API ="ApplicationConfiguration";

        private const string ADD_APPLICATIONCONFIG_API = "ApplicationConfiguration/AddConfig";
        private const string UPDATE_APPLICATIONCONFIG_API = "ApplicationConfiguration/UpdateConfig";

        private const string ADD_MULTIPAL_APPLICATIONCONFIG_API = "ApplicationConfiguration/AddConfigs";                
        private const string UPDATE_MULTIPAL_APPLICATIONCONFIG_API = "ApplicationConfiguration/UpdateConfigs";


        private DataTable _dtAppConfig;
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
            saveSMTPConfiguration();
        }

        private void saveSMTPConfiguration()
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = string.Empty;

                List<ApplicationConfiguration> appConfigs = getSMTPConfig();
               
                DataRow[] drCollection = _dtAppConfig.Select("Category = 'SMTP Setting'");
                if (drCollection.Count() == 0)
                {
                    apiurl = Program.WebServiceUrl + "/" + ADD_MULTIPAL_APPLICATIONCONFIG_API;
                }
                else
                {
                    apiurl = Program.WebServiceUrl + "/" + UPDATE_MULTIPAL_APPLICATIONCONFIG_API;
                }

                string DATA =  jsonSerialization.SerializeToString<List<ApplicationConfiguration>>(appConfigs);

                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiurl,"POST", DATA);

                if (json != null)
                {
                    var resultObject = jsonSerialization.DeserializeFromString<Result>(json);
                    if (resultObject.IsSuccess)
                    {
                        MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to save record." + resultObject.ExceptionInfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<ApplicationConfiguration> getSMTPConfig()
        {
            Email email = new Email();
            email.FromEmail = txtFromEmail.Text;
            email.SMTPPort = int.Parse(txtPort.Text);
            email.SMTPServerHost = txtHost.Text;
            email.UserName = txtUserName.Text;
            email.Password = FinancialPlanner.Common.DataEncrypterDecrypter.CryptoEngine.Encrypt(txtPassword.Text);
            email.IsSSL = chkIsSSL.Checked;

            List<KeyValuePair<string, string>> lstSMTPsetting = new List<KeyValuePair<string, string>>();
            lstSMTPsetting.Add(new KeyValuePair <string,string> ("FromEmail",email.FromEmail));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("SMTPPort", email.SMTPPort.ToString()));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("SMTPHost", email.SMTPServerHost));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("UserName", email.UserName));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("Password", email.Password));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("IsSSL", email.IsSSL.ToString()));
            
            List<ApplicationConfiguration> lstConfig = new List<ApplicationConfiguration>();

            foreach (KeyValuePair<string, string> val in lstSMTPsetting)
            {
                ApplicationConfiguration appConfig = new ApplicationConfiguration()
                {
                    Category ="SMTP Setting",
                    SettingName = val.Key,
                    SettingValue = val.Value.Replace("'","''"),
                    CreatedOn = DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    CreatedBy = Program.CurrentUser.Id,
                    UpdatedOn =  DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    UpdatedBy = Program.CurrentUser.Id,
                    UpdatedByUserName = Program.CurrentUser.UserName,
                    MachineName = System.Environment.MachineName
                };
                lstConfig.Add(appConfig);
            }           
            return lstConfig;
        }

        private void btnFindfolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDiallog.ShowDialog() == DialogResult.OK)
                txtAppPath.Text = folderBrowserDiallog.SelectedPath;
        }

        private void frmSystemSetting_Load(object sender, EventArgs e)
        {
            loadApplicationConfig();
            
            displayApplicationConfig();
        }

        private void displaySMTPConfig()
        {
            if (_dtAppConfig != null)
            {
                DataRow[] smtpSettingRows = _dtAppConfig.Select("CATEGORY = 'SMTP Setting'");
                foreach(DataRow dr in smtpSettingRows)
                {
                    if (dr.Field<string>("SettingName") == "FromEmail")
                    {
                        txtFromEmail.Text = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "SMTPPort")
                    {
                        txtPort.Text = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "SMTPHost")
                    {
                        txtHost.Text = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "UserName")
                    {
                        txtUserName.Text = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "Password")
                    {
                        txtPassword.Text = FinancialPlanner.Common.DataEncrypterDecrypter.CryptoEngine.Decrypt(dr.Field<string>("SettingValue"));
                    }
                    else if (dr.Field<string>("SettingName") == "IsSSL")
                    {
                        chkIsSSL.Checked = Boolean.Parse(dr.Field<string>("SettingValue"));
                    }
                }
            }
        }
        private void displayApplicationConfig()
        {
            displaySMTPConfig();
            displayApplicationPath();
        }

        private void displayApplicationPath()
        {
            if (_dtAppConfig != null)
            {
                DataRow[] appPathRows = _dtAppConfig.Select("SettingName= 'Application Path'");
                if (appPathRows.Count() > 0)
                    txtAppPath.Text = appPathRows[0].Field<string>("SettingValue");
                else
                    txtAppPath.Text = "";
            }
            else
                txtAppPath.Text = "";
        }

        private void loadApplicationConfig()
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ GET_APPLICATIONCONFIG_API;

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiurl);
                request.Method = "GET";
                String appConfigResultJson = String.Empty;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();

                    StreamReader reader = new StreamReader(dataStream);
                    appConfigResultJson = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                }
                var appConfigCollection = jsonSerialization.DeserializeFromString<Result<List<ApplicationConfiguration>>>(appConfigResultJson);

                if (appConfigCollection.Value != null)
                {
                    _dtAppConfig = ListtoDataTable.ToDataTable(appConfigCollection.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Fail to load application data. Error:{0}",ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAppPathSave_Click(object sender, EventArgs e)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = string.Empty;

                ApplicationConfiguration appConfig = new ApplicationConfiguration()
                {
                    Category ="Server Setting",
                    SettingName = "Application Path",
                    SettingValue = txtAppPath.Text.Replace("'","''"),
                    CreatedOn = DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    CreatedBy = Program.CurrentUser.Id,
                    UpdatedOn =  DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    UpdatedBy = Program.CurrentUser.Id,
                    UpdatedByUserName = Program.CurrentUser.UserName,
                    MachineName = System.Environment.MachineName
                };

                DataRow[] drCollection = _dtAppConfig.Select("SettingName = 'Application Path'");
                if (drCollection.Count() == 0)
                {
                    apiurl = Program.WebServiceUrl + "/" + ADD_APPLICATIONCONFIG_API;
                }
                else
                {
                    apiurl = Program.WebServiceUrl + "/" + UPDATE_APPLICATIONCONFIG_API;
                    appConfig.Id = int.Parse(drCollection[0][0].ToString());
                }

                string DATA =  jsonSerialization.SerializeToString<ApplicationConfiguration>(appConfig);

                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiurl,"POST", DATA);

                if (json != null)
                {
                    var resultObject = jsonSerialization.DeserializeFromString<Result>(json);
                    if (resultObject.IsSuccess)
                    {
                        MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to save record." + resultObject.ExceptionInfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
