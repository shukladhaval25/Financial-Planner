using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.Model;
using FinancialPlannerClient.PlannerInfo;
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
    public partial class ClientInfo : Form
    {
        private int _plannerId = 0;
        private Client _client;
        private DataTable _dtFamilymember;
        public int PlannerId
        {
            get { return _plannerId; }
        }
        public ClientInfo()
        {
            InitializeComponent();
        }
        public ClientInfo(int plannerId, Client client)
        {
            InitializeComponent();
            _plannerId = plannerId;
            _client = client;
        }

        private void tabPlannerDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabPlannerDetails.SelectedTab.Name)
            {
                case "Assumption":
                    fillupAssumptionInfo();
                    break;
                case "PersonalInfo":
                    fillupPersonalDetails();
                    break;
                case "FamilyInfo":
                    fillupFamilyMemberInfo();
                    break;
                case "Goal":
                    break;
                default:
                    break;
            }

        }

        private void fillupFamilyMemberInfo()
        {
            if (_dtFamilymember == null)
                _dtFamilymember = new DataTable();
            else
                _dtFamilymember.Clear();

            FamilyMemberInfo familyMemberInfo = new FamilyMemberInfo();
            List<FamilyMember> lstFamilyMember =(List<FamilyMember>) familyMemberInfo.Get(_client.ID);
            _dtFamilymember = ListtoDataTable.ToDataTable(lstFamilyMember);
            dtGridFamilyMember.DataSource = _dtFamilymember;
            setFamilyMemberGridSetting();
        }

        private void setFamilyMemberGridSetting()
        {
            FamilyMemberInfo familyMemberInfo = new FamilyMemberInfo();
            familyMemberInfo.setFamilyMemberGridSetting(dtGridFamilyMember);
        }

        private void fillupAssumptionInfo()
        {
        }

        private void tbPersonalInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbPersonalInfo.SelectedTab.Name)
            {
                case "PersonalDetails":
                    fillupPersonalDetails();
                    break;
                case "ContactDetails":
                    fillupContactDetails();
                    break;
                case "EmployerDetails":
                    fillupEmploymentDetails();
                    break;
                default:
                    break;
            }
        }

        private void fillupEmploymentDetails()
        {
            EmploymentInfo employmentInfo = new EmploymentInfo();
            var employment = employmentInfo.Get(_client.ID);
            fillupEmploymentInfo(employment);
        }

        private void fillupEmploymentInfo(Employment employment)
        {
            if (employment != null)
            {
                fillupClientEmploymentInfo(employment.ClientEmployment);
                fillupSpouseEmploymentInfo(employment.SpouseEmployment);
            }
        }

        private void fillupSpouseEmploymentInfo(SpouseEmployment spouseEmployment)
        {
            if (spouseEmployment != null)
            {
                txtSpouseDesigation.Text = spouseEmployment.Designation;
                txtSpouseEmployer.Text = spouseEmployment.EmployerName;
                txtSpouseEmployerAdd.Text = spouseEmployment.Address;
                txtSpouseEmployerCity.Text = spouseEmployment.City;
                txtSpouseEmployerStreet.Text = spouseEmployment.Street;
                txtSpouseEmployerPin.Text = spouseEmployment.Pin;
                txtSpouseIncome.Text = spouseEmployment.Income;
            }
        }

        private void fillupClientEmploymentInfo(ClientEmployment clientEmployment)
        {
            if (clientEmployment != null)
            {
                txtClientDesignation.Text = clientEmployment.Designation;
                txtClientEmployer.Text = clientEmployment.EmployerName;
                txtClientEmployerAdd.Text = clientEmployment.Address;
                txtClientEmployerCity.Text = clientEmployment.City;
                txtClientEmployerStreet.Text = clientEmployment.Street;
                txtClientEmployerPin.Text = clientEmployment.Pin;
                txtClientIncome.Text = clientEmployment.Income;
            }
        }

        private void fillupContactDetails()
        {
            ClientContactInfo clientContactInfo = new ClientContactInfo();
            var contactInfo = clientContactInfo.Get(_client.ID);
            fillupContactInfo(contactInfo);
        }

        private void fillupContactInfo(ClientContact contactInfo)
        {
            if (contactInfo != null)
            {
                txtHouseNo.Text = contactInfo.Add1;
                txtStreet.Text = contactInfo.Street;
                txtCity.Text = contactInfo.City;
                txtState.Text = contactInfo.State;
                txtPin.Text = contactInfo.Pin;
                txtClientEmailId.Text = contactInfo.Email;
                txtSpouseEmailId.Text = contactInfo.SpouseEmail;
                txtClientMobile.Text = contactInfo.Mobile;
                txtSpouseMobile.Text = contactInfo.Spousemobile;
                if (txtClientEmailId.Text.Equals(contactInfo.PrimaryEmail))
                    chkPrimaryEmail.Checked = true;
                if (txtSpouseEmailId.Text.Equals(contactInfo.PrimaryEmail))
                    chkSpousePrimaryEmail.Checked = true;
                if (txtClientMobile.Text.Equals(contactInfo.PrimaryMobile))
                    chkMobileNo.Checked = true;
                if (txtSpouseMobile.Text.Equals(contactInfo.PrimaryMobile))
                    chkSpouseMobileNo.Checked = true;

            }
        }

        private void fillupPersonalDetails()
        {
            ClientPersonalInfo clientPersonalInfo = new ClientPersonalInfo();
            var personalInfo =  clientPersonalInfo.Get(_client.ID);
            fillClientPersonalDetails(personalInfo.Client);
            fillSpousePersonalDetails(personalInfo.Spouse);
        }

        private void fillSpousePersonalDetails(ClientSpouse spouse)
        {
            if (spouse != null)
            {
                txtSpouseName.Text = spouse.Name;
                if (spouse.DOB != DateTime.MinValue)
                    dtSpouseDOB.Value = spouse.DOB;
                dtSpouseMarriageAnniversary.Checked = spouse.IsMarried;
                txtSpouseFatherName.Text = spouse.FatherName;
                txtSpouseMotherName.Text = spouse.MotherName;
                txtSpousePAN.Text = spouse.PAN;
                txtSpouseAadhar.Text = spouse.Aadhar;
                txtSpousePlaceOfBirth.Text = spouse.PlaceOfBirth;
                txtSpouseOccupation.Text = spouse.Occupation;
                rdoSpouseGenderMale.Checked = (spouse.Gender == "Male") ? true : false;
            }
        }

        private void fillClientPersonalDetails(Client client)
        {
            if (client != null)
            {
                txtClientName.Text = client.Name;
                dtClientDOB.Value = client.DOB;
                dtClientMarriageAnniversary.Checked = client.IsMarried;
                txtClientFatherName.Text = client.FatherName;
                txtClientMotherName.Text = client.MotherName;
                txtClientPAN.Text = client.PAN;
                txtClientAadhar.Text = client.Aadhar;
                txtClientPlaceOfBirth.Text = client.PlaceOfBirth;
                txtClientOccupation.Text = client.Occupation;
                rdoClientGenderMale.Checked = (client.Gender == "Male") ? true : false;
            }
        }

        private void tbPersonalInfo_TabIndexChanged(object sender, EventArgs e)
        {
            switch (tbPersonalInfo.SelectedTab.Name)
            {
                case "PersonalDetails":
                    fillupPersonalDetails();
                    break;
                case "ContactDetails":
                    fillupFamilyMemberInfo();
                    break;
                case "EmployerDetails":
                    break;
                default:
                    break;
            }
        }

        private void btnPersonalDetailSave_Click(object sender, EventArgs e)
        {
            PersonalInformation personalInfo = new PersonalInformation();
            personalInfo.Client = getClientData();
            personalInfo.Spouse = getClientSpouseData();
            ClientPersonalInfo clientPersonalInfo = new ClientPersonalInfo();
            clientPersonalInfo.Update(personalInfo);
        }

        private ClientSpouse getClientSpouseData()
        {
            ClientSpouse spouse = new ClientSpouse();
            spouse.Name = txtSpouseName.Text;
            spouse.ClientId = _client.ID;
            spouse.DOB = dtSpouseDOB.Value;
            spouse.IsMarried = dtSpouseMarriageAnniversary.Checked;
            spouse.FatherName = txtSpouseFatherName.Text;
            spouse.MotherName = txtSpouseMotherName.Text;
            spouse.PAN = txtSpousePAN.Text;
            spouse.Aadhar = txtSpouseAadhar.Text;
            spouse.PlaceOfBirth = txtSpousePlaceOfBirth.Text;
            spouse.Occupation = txtSpouseOccupation.Text;
            spouse.Gender = rdoSpouseGenderMale.Checked ? "Male" : "Female";
            spouse.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            spouse.UpdatedBy = Program.CurrentUser.Id;
            spouse.UpdatedByUserName = Program.CurrentUser.UserName;
            spouse.MachineName = System.Environment.MachineName;
            return spouse;
        }

        private Client getClientData()
        {
            Client client = new Client();
            client.ID = _client.ID;
            client.Name = txtClientName.Text;
            client.DOB = dtClientDOB.Value;
            client.IsMarried = dtClientMarriageAnniversary.Checked;
            client.FatherName = txtClientFatherName.Text;
            client.MotherName = txtClientMotherName.Text;
            client.PAN = txtClientPAN.Text;
            client.Aadhar = txtClientAadhar.Text;
            client.PlaceOfBirth = txtClientPlaceOfBirth.Text;
            client.Occupation = txtClientOccupation.Text;
            client.Gender = (rdoClientGenderMale.Checked) ? "Male" : "Female";
            client.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            client.UpdatedBy = Program.CurrentUser.Id;
            client.UpdatedByUserName = Program.CurrentUser.UserName;
            client.MachineName = System.Environment.MachineName;
            return client;
        }

        private void chkPrimaryEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrimaryEmail.Checked)
                chkSpousePrimaryEmail.Checked = false;
        }

        private void chkSpousePrimaryEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpousePrimaryEmail.Checked)
                chkPrimaryEmail.Checked = false;
        }

        private void chkMobileNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMobileNo.Checked)
                chkSpouseMobileNo.Checked = false;
        }

        private void chkSpouseMobileNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpouseMobileNo.Checked)
                chkMobileNo.Checked = false;
        }

        private void btnContactInfoSave_Click(object sender, EventArgs e)
        {
            ClientContactInfo clientContactInfo = new ClientContactInfo();
            ClientContact clientContact = new ClientContact();
            clientContact = getClientContactData();
            if (clientContactInfo.Update(clientContact))
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private ClientContact getClientContactData()
        {
            ClientContact contactInfo = new ClientContact();
            contactInfo.Cid = _client.ID;
            contactInfo.Add1 = txtHouseNo.Text;
            contactInfo.Street = txtStreet.Text;
            contactInfo.City = txtCity.Text;
            contactInfo.State = txtState.Text;
            contactInfo.Pin = txtPin.Text;
            contactInfo.Email = txtClientEmailId.Text;
            contactInfo.SpouseEmail = txtSpouseEmailId.Text;
            contactInfo.Mobile = txtClientMobile.Text;
            contactInfo.Spousemobile = txtSpouseMobile.Text;
            if (chkPrimaryEmail.Checked)
                contactInfo.PrimaryEmail = txtClientEmailId.Text;
            if (chkSpousePrimaryEmail.Checked)
                contactInfo.SpouseEmail = txtSpouseEmailId.Text;
            if (chkMobileNo.Checked)
                contactInfo.PrimaryMobile = txtClientMobile.Text;
            if (chkSpouseMobileNo.Checked)
                contactInfo.PrimaryMobile = txtSpouseMobile.Text;
            contactInfo.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            contactInfo.UpdatedBy = Program.CurrentUser.Id;
            contactInfo.UpdatedByUserName = Program.CurrentUser.UserName;
            contactInfo.MachineName = System.Environment.MachineName;
            return contactInfo;
        }

        private void btnSaveEmployment_Click(object sender, EventArgs e)
        {
            EmploymentInfo employmentInfo = new EmploymentInfo();
            Employment empoloyment = new Employment();
            empoloyment = getEmploymentDetails();
            if (employmentInfo.Update(empoloyment))
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Employment getEmploymentDetails()
        {
            Employment employment = new Employment();
            employment.ClientEmployment = getClientEmploymentInfo();
            employment.SpouseEmployment = getSpouseEmploymentInfo();
            return employment;
        }

        private SpouseEmployment getSpouseEmploymentInfo()
        {
            SpouseEmployment spouseEmployment = new SpouseEmployment();
            spouseEmployment.Cid = _client.ID;
            spouseEmployment.Designation = txtSpouseDesigation.Text;
            spouseEmployment.EmployerName = txtSpouseEmployer.Text;
            spouseEmployment.Address = txtSpouseEmployerAdd.Text;
            spouseEmployment.City = txtSpouseEmployerCity.Text;
            spouseEmployment.Street = txtSpouseEmployerStreet.Text;
            spouseEmployment.Pin = txtSpouseEmployerPin.Text;
            spouseEmployment.Income = txtSpouseIncome.Text;
            spouseEmployment.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            spouseEmployment.UpdatedBy = Program.CurrentUser.Id;
            spouseEmployment.UpdatedByUserName = Program.CurrentUser.UserName;
            spouseEmployment.MachineName = System.Environment.MachineName;
            return spouseEmployment;
        }

        private ClientEmployment getClientEmploymentInfo()
        {
            ClientEmployment clientEmployment = new ClientEmployment();
            clientEmployment.Cid = _client.ID;
            clientEmployment.Designation = txtClientDesignation.Text;
            clientEmployment.EmployerName = txtClientEmployer.Text;
            clientEmployment.Address = txtClientEmployerAdd.Text;
            clientEmployment.City = txtClientEmployerCity.Text;
            clientEmployment.Street = txtClientEmployerStreet.Text;
            clientEmployment.Pin = txtClientEmployerPin.Text;
            clientEmployment.Income = txtClientIncome.Text;
            clientEmployment.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            clientEmployment.UpdatedBy = Program.CurrentUser.Id;
            clientEmployment.UpdatedByUserName = Program.CurrentUser.UserName;
            clientEmployment.MachineName = System.Environment.MachineName;
            return clientEmployment;
        }

        private void btnAddFamilyMember_Click(object sender, EventArgs e)
        {
            grpFamilyMemberDetail.Enabled = true;            
            setDefaultFamilyMemberData();
            txtFamilyMemberName.Tag = 0;
        }

        private void btnFamilyMemberCancel_Click(object sender, EventArgs e)
        {
            btnEditFamilyMember_Click(sender, e);
            grpFamilyMemberDetail.Enabled = false;
        }

        private void btnFamilyMemberSave_Click(object sender, EventArgs e)
        {
            FamilyMemberInfo familyMemberInfo = new FamilyMemberInfo();
            FamilyMember familyMember = getFamilyMemberData();
            bool isSaved = false;

            if (familyMember != null && familyMember.Id == 0)
                isSaved = familyMemberInfo.Add(familyMember);
            else
                isSaved = familyMemberInfo.Update(familyMember);

            if (isSaved)
            {
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillupFamilyMemberInfo();
                grpFamilyMemberDetail.Enabled = false;
            }
            else
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private FamilyMember getFamilyMemberData()
        {
            FamilyMember familymember = new FamilyMember();
            familymember.Id = int.Parse(txtFamilyMemberName.Tag.ToString());
            familymember.Cid = _client.ID;
            familymember.Name = txtFamilyMemberName.Text;
            familymember.Relationship = cmbFamilyRelationship.Text;
            familymember.DOB = dtFamilyMemberDOB.Value;
            familymember.IsDependent = rdoFamilyMemberDependentYes.Checked;
            familymember.ChildrenClass = txtChildrenClass.Text;
            familymember.Description = txtFamilyMemberDesc.Text;
            familymember.CreatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            familymember.CreatedBy = Program.CurrentUser.Id;
            familymember.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            familymember.UpdatedBy = Program.CurrentUser.Id;
            familymember.MachineName = Environment.MachineName;
            return familymember;
        }

        private void btnEditFamilyMember_Click(object sender, EventArgs e)
        {
            FamilyMember familymember = convertSelectedRowDataToFamilyMember();
            displayFamilyMemberData(familymember);
            grpFamilyMemberDetail.Enabled = true;
        }

        private void displayFamilyMemberData(FamilyMember familymember)
        {
            if (familymember != null)
            {
                txtFamilyMemberName.Tag = familymember.Id;
                txtFamilyMemberName.Text = familymember.Name;
                cmbFamilyRelationship.Text = familymember.Relationship;
                dtFamilyMemberDOB.Value = familymember.DOB;
                rdoFamilyMemberDependentYes.Checked = familymember.IsDependent;
                txtChildrenClass.Text = familymember.ChildrenClass;
                txtFamilyMemberDesc.Text = familymember.Description;
            }
            else
            {
                setDefaultFamilyMemberData();
            }
        }

        private void setDefaultFamilyMemberData()
        {
            txtFamilyMemberName.Tag = "";
            txtFamilyMemberName.Text = "";
            cmbFamilyRelationship.Text = "";
            dtFamilyMemberDOB.Text = "";
            rdoFamilyMemberDependentYes.Checked = false;
            txtChildrenClass.Text = "";
            txtFamilyMemberDesc.Text = "";
        }

        private FamilyMember convertSelectedRowDataToFamilyMember()
        {

            if (dtGridFamilyMember.SelectedRows.Count > 0)
            {
                FamilyMember fm = new FamilyMember();
                DataRow dr = getSelectedDataRow();
                fm.Id = int.Parse(dr.Field<string>("ID"));
                fm.Cid = int.Parse(dr.Field<string>("Cid"));
                fm.Name = dr.Field<string>("Name");
                fm.Relationship = dr.Field<string>("Relationship");
                fm.DOB = DateTime.Parse(dr.Field<string>("DOB"));
                fm.IsDependent = bool.Parse(dr["IsDependent"].ToString());
                fm.ChildrenClass = dr.Field<string>("ChildrenClass");
                fm.Description = dr.Field<string>("Description");
                return fm;
            }
            return null;
        }

        private DataRow getSelectedDataRow()
        {
            int selectedRowIndex = dtGridFamilyMember.SelectedRows[0].Index;
            int selectedUserId = int.Parse(dtGridFamilyMember.SelectedRows[0].Cells["ID"].Value.ToString());
            DataRow[] rows = _dtFamilymember.Select("Id = " + selectedUserId);
            foreach (DataRow dr in rows)
            {
                return dr;
            }
            return null;
        }

        private void dtGridFamilyMember_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtGridFamilyMember.Columns[e.ColumnIndex].Name == "IsDependent")
            {
                if (dtGridFamilyMember.Rows[e.RowIndex].Cells["IsDependent"].Value != null)
                    e.Value = (dtGridFamilyMember.Rows[e.RowIndex].Cells["IsDependent"].Value.ToString().Equals("True")) ? "Yes" : "No";
            }
        }

        private void btnDeleteFamilyMember_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FamilyMember familymember = convertSelectedRowDataToFamilyMember();
                FamilyMemberInfo familyMemberInfo = new FamilyMemberInfo();
                familyMemberInfo.Delete(familymember.Id);
                fillupFamilyMemberInfo();
            }            
        }        
    }
}
