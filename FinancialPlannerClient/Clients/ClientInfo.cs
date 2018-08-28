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
        private DataTable _dtNonFinancialAsset;
        private DataTable _dtLoan;
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
                case "Loan":
                    fillupLoanInfo();
                    break;
                case "NonFinancialAssets":
                    fillupNonFinancialAssetInfo();
                    break;
                case "Income":
                    break;
                case "Goal":
                    break;
                default:
                    break;
            }

        }

        private void fillupLoanInfo()
        {
            LoanInfo loanInfo = new LoanInfo();
            List<Loan> lstNonFinancialAsset =(List<Loan>) loanInfo.GetAll(PlannerId);
            _dtLoan = ListtoDataTable.ToDataTable(lstNonFinancialAsset);
            dtGridLoan.DataSource = _dtLoan;
            loanInfo.FillGrid(dtGridLoan);
        }

        private void fillupNonFinancialAssetInfo()
        {
            FamilyMemberInfo familyMemInfo =  new FamilyMemberInfo();
            familyMemInfo.FillFamilyMemberInCombo(_client.ID, cmbOtherHolder);
            cmbPrimaryHolder.Text = _client.Name;
            cmbSecondaryHolder.Text = getSpouseName();

            if (_dtNonFinancialAsset == null)
                _dtNonFinancialAsset = new DataTable();
            else
                _dtNonFinancialAsset.Clear();

            NonFinancialAssetInfo nonFinancialAssetInfo = new NonFinancialAssetInfo();
            List<NonFinancialAsset> lstNonFinancialAsset =(List<NonFinancialAsset>) nonFinancialAssetInfo.GetAlll(PlannerId);
            _dtNonFinancialAsset = ListtoDataTable.ToDataTable(lstNonFinancialAsset);
            dtGridNonFinancialAssets.DataSource = _dtNonFinancialAsset;
            nonFinancialAssetInfo.FillGrid(dtGridNonFinancialAssets);
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
                familyMemberInfo.Delete(familymember);
                fillupFamilyMemberInfo();
            }
        }

        private void btnAddNFA_Click(object sender, EventArgs e)
        {
            grpNonFinancialAsset.Enabled = true;
            setDefaultNonFinancialAssetValue();
            txtAssetName.Tag = "0";
        }

        private void setDefaultNonFinancialAssetValue()
        {
            txtAssetName.Text = "";
            txtAssetCurrentCost.Text = "0";
            txtPrimaryHolderShare.Text = "100";
            txtSecondaryHolderShare.Text = "0";
            cmbOtherHolder.Text = "";
            txtOtherShare.Text = "0";
            cmbMappingGoal.Text = "";
            txtGoalMappingShare.Text = "0";
            txtAssetRealisationYear.Text = DateTime.Now.Year.ToString();
            txtNonFinancialDesc.Text = "";
        }

        private void btnNonFinancialSave_Click(object sender, EventArgs e)
        {
            if (!validateTotalShareRation())
                return;

            NonFinancialAssetInfo nonFinancialAssetInfo = new NonFinancialAssetInfo();
            NonFinancialAsset nonFinancialAsset = getNonFinancialAsset();
            bool isSaved = false;

            if (nonFinancialAsset != null && nonFinancialAsset.Id == 0)
                isSaved = nonFinancialAssetInfo.Add(nonFinancialAsset);
            else
                isSaved = nonFinancialAssetInfo.Update(nonFinancialAsset);

            if (isSaved)
            {
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillupNonFinancialAssetInfo();
                grpNonFinancialAsset.Enabled = false;
            }
            else
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool validateTotalShareRation()
        {
            if ((int.Parse(txtPrimaryHolderShare.Text) +
                int.Parse(txtSecondaryHolderShare.Text) +
                int.Parse(txtOtherShare.Text)) > 100)
            {
                MessageBox.Show("Asset sharing ration must not be more then 100%.", "Sharing Ration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private NonFinancialAsset getNonFinancialAsset()
        {
            NonFinancialAsset nonFinancialAsset = new NonFinancialAsset();
            nonFinancialAsset.Id = int.Parse(txtAssetName.Tag.ToString());
            nonFinancialAsset.Pid = PlannerId;
            nonFinancialAsset.Name = txtAssetName.Text;
            nonFinancialAsset.CurrentValue = double.Parse(txtAssetCurrentCost.Text);
            nonFinancialAsset.PrimaryholderShare = int.Parse(txtPrimaryHolderShare.Text);
            nonFinancialAsset.SecondaryHolderShare = int.Parse(txtSecondaryHolderShare.Text);
            nonFinancialAsset.OtherHolderName = cmbOtherHolder.Text;
            nonFinancialAsset.OtherHolderShare = int.Parse(txtOtherShare.Text);
            if (cmbMappingGoal.Tag != null)
                nonFinancialAsset.MappedGoalId = int.Parse(cmbMappingGoal.Tag.ToString());
            else
                nonFinancialAsset.MappedGoalId = 0;
            nonFinancialAsset.AssetMappingShare = int.Parse(txtGoalMappingShare.Text);
            nonFinancialAsset.Description = txtNonFinancialDesc.Text;
            nonFinancialAsset.CreatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            nonFinancialAsset.CreatedBy = Program.CurrentUser.Id;
            nonFinancialAsset.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            nonFinancialAsset.UpdatedBy = Program.CurrentUser.Id;
            nonFinancialAsset.MachineName = Environment.MachineName;
            return nonFinancialAsset;
        }

        private void btnEditNFA_Click(object sender, EventArgs e)
        {
            NonFinancialAsset nonFinancialAsset = convertSelectedRowDataToNonFinancialAsset();
            displayNonFinancialAsset(nonFinancialAsset);
            grpNonFinancialAsset.Enabled = true;
        }

        private void displayNonFinancialAsset(NonFinancialAsset nonFinancialAsset)
        {
            if (nonFinancialAsset != null)
            {
                txtAssetName.Tag = nonFinancialAsset.Id;
                txtAssetName.Text = nonFinancialAsset.Name;
                txtAssetCurrentCost.Text = nonFinancialAsset.CurrentValue.ToString("#,000.00");
                cmbPrimaryHolder.Text = _client.Name;
                cmbSecondaryHolder.Text = getSpouseName();
                txtPrimaryHolderShare.Text = nonFinancialAsset.PrimaryholderShare.ToString();
                txtSecondaryHolderShare.Text = nonFinancialAsset.SecondaryHolderShare.ToString();
                cmbOtherHolder.Text = nonFinancialAsset.OtherHolderName;
                txtOtherShare.Text = nonFinancialAsset.OtherHolderShare.ToString();
                cmbMappingGoal.Tag = nonFinancialAsset.MappedGoalId.ToString();
                txtGoalMappingShare.Text = nonFinancialAsset.AssetMappingShare.ToString();
                txtAssetRealisationYear.Text = nonFinancialAsset.AssetRealisationYear;
                txtNonFinancialDesc.Text = nonFinancialAsset.Description;
            }
        }

        private NonFinancialAsset convertSelectedRowDataToNonFinancialAsset()
        {

            if (dtGridNonFinancialAssets.SelectedRows.Count > 0)
            {
                NonFinancialAsset nonFinancialAsset = new NonFinancialAsset();
                DataRow dr = getSelectedDataRowForNonFinancialAsset();
                nonFinancialAsset.Id = int.Parse(dr.Field<string>("ID"));
                nonFinancialAsset.Pid = int.Parse(dr.Field<string>("PID"));
                nonFinancialAsset.Name = dr.Field<string>("NAME");
                nonFinancialAsset.CurrentValue = double.Parse(dr.Field<string>("CurrentValue"));
                nonFinancialAsset.PrimaryholderShare = int.Parse(dr.Field<string>("Primaryholdershare"));
                nonFinancialAsset.SecondaryHolderShare = int.Parse(dr.Field<string>("SecondaryHoldershare"));
                nonFinancialAsset.OtherHolderName = dr.Field<string>("OtherHolderName");
                nonFinancialAsset.OtherHolderShare = int.Parse(dr.Field<string>("OtherHolderShare"));
                nonFinancialAsset.MappedGoalId = int.Parse(dr.Field<string>("MappedGoalId"));
                nonFinancialAsset.AssetMappingShare = int.Parse(dr.Field<string>("AssetMappingShare"));
                nonFinancialAsset.AssetRealisationYear = dr.Field<string>("AssetRealisationYear");
                nonFinancialAsset.Description = dr.Field<string>("Description");
                return nonFinancialAsset;
            }
            return null;
        }
        private DataRow getSelectedDataRowForNonFinancialAsset()
        {
            int selectedRowIndex = dtGridNonFinancialAssets.SelectedRows[0].Index;
            int selectedUserId = int.Parse(dtGridNonFinancialAssets.SelectedRows[0].Cells["ID"].Value.ToString());
            DataRow[] rows = _dtNonFinancialAsset.Select("Id = " + selectedUserId);
            foreach (DataRow dr in rows)
            {
                return dr;
            }
            return null;
        }

        private DataRow getSelectedDataRowForLoan()
        {
            if (dtGridLoan.SelectedRows.Count >= 1)
            {
                int selectedRowIndex = dtGridLoan.SelectedRows[0].Index;
                int selectedUserId = int.Parse(dtGridLoan.SelectedRows[0].Cells["ID"].Value.ToString());
                DataRow[] rows = _dtLoan.Select("Id = " + selectedUserId);
                foreach (DataRow dr in rows)
                {
                    return dr;
                }
            }
            return null;
        }

        private void btnDeleteNFA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NonFinancialAsset nonFinancialAsset = convertSelectedRowDataToNonFinancialAsset();
                NonFinancialAssetInfo nonFinancialAssetInfo = new NonFinancialAssetInfo();
                nonFinancialAssetInfo.Delete(nonFinancialAsset);
                fillupNonFinancialAssetInfo();
            }
        }

        private void dtGridNonFinancialAssets_SelectionChanged(object sender, EventArgs e)
        {
            NonFinancialAsset nonFinancialAsset = convertSelectedRowDataToNonFinancialAsset();
            displayNonFinancialAsset(nonFinancialAsset);
        }

        private void btnNonFinancialCanel_Click(object sender, EventArgs e)
        {
            grpNonFinancialAsset.Enabled = false;
            NonFinancialAsset nonFinancialAsset = convertSelectedRowDataToNonFinancialAsset();
            displayNonFinancialAsset(nonFinancialAsset);
        }
        private void txtPrimaryHolderShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSecondaryHolderShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOtherShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGoalMappingShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGoalMappingShare_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtGoalMappingShare.Text) > 100)
            {
                MessageBox.Show("More then 100% is not allow to map with asset value.");
                txtGoalMappingShare.Focus();
            }
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            grpLoanDetails.Enabled = true;
            setDefaultLoanValue();
        }

        private void setDefaultLoanValue()
        {
            txtTypeOfLoan.Tag = "0";
            txtTypeOfLoan.Text = "";
            txtOutStadningLoan.Text = "0";
            txtLoanInterestRate.Text = "0";
            txtEmis.Text = "0";
            txtLoanTermLeft_Months.Text = "0";
            txtNoOfEmiPayableForCY.Text = "0";
            txtLoanDescription.Text = "";
        }

        private void btnSaveLoan_Click(object sender, EventArgs e)
        {

            LoanInfo loanInfo = new LoanInfo();
            Loan loan = getLaonData();
            bool isSaved = false;

            if (loan != null && loan.Id == 0)
                isSaved = loanInfo.Add(loan);
            else
                isSaved = loanInfo.Update(loan);

            if (isSaved)
            {
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillupLoanInfo();
                grpLoanDetails.Enabled = false;
            }
            else
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Loan getLaonData()
        {
            Loan loan = new Loan();
            loan.Id = int.Parse(txtTypeOfLoan.Tag.ToString());
            loan.Pid = PlannerId;
            loan.TypeOfLoan = txtTypeOfLoan.Text;
            loan.OutstandingAmt = int.Parse(txtOutStadningLoan.Text);
            loan.InterestRate = decimal.Parse(txtLoanInterestRate.Text);
            loan.Emis = int.Parse(txtEmis.Text);
            loan.TermLeftInMonths = int.Parse(txtLoanTermLeft_Months.Text);
            loan.NoEmisPayableUntilYear = int.Parse(txtNoOfEmiPayableForCY.Text);
            loan.Description = txtLoanDescription.Text;
            loan.CreatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            loan.CreatedBy = Program.CurrentUser.Id;
            loan.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            loan.UpdatedBy = Program.CurrentUser.Id;
            loan.MachineName = Environment.MachineName;

            return loan;
        }

        private void btnUpdateLoan_Click(object sender, EventArgs e)
        {
            Loan loan = convertSelectedRowDataToLoan();
            displayLoanData(loan);
            grpLoanDetails.Enabled = true;
        }

        private void displayLoanData(Loan loan)
        {
            if (loan != null)
            {
                txtTypeOfLoan.Tag = loan.Id;
                txtTypeOfLoan.Text = loan.TypeOfLoan;
                txtOutStadningLoan.Text = loan.OutstandingAmt.ToString("#,000.00");
                txtLoanInterestRate.Text = loan.InterestRate.ToString();
                txtEmis.Text = loan.Emis.ToString();
                txtLoanTermLeft_Months.Text = loan.TermLeftInMonths.ToString();
                txtNoOfEmiPayableForCY.Text = loan.NoEmisPayableUntilYear.ToString();
                txtLoanDescription.Text = loan.Description;
            }
        }

        private Loan convertSelectedRowDataToLoan()
        {
            if (dtGridLoan.SelectedRows.Count >= 1)
            {
                Loan loan = new Loan();
                DataRow dr = getSelectedDataRowForLoan();
                loan.Id = int.Parse(dr.Field<string>("ID"));
                loan.Pid = int.Parse(dr.Field<string>("PID"));
                loan.TypeOfLoan = dr.Field<string>("TypeOfLoan");
                loan.OutstandingAmt = double.Parse(dr.Field<string>("OutstandingAmt"));
                loan.Emis = int.Parse(dr.Field<string>("EMIs"));
                loan.InterestRate = decimal.Parse(dr.Field<string>("InterestRate"));
                loan.TermLeftInMonths = int.Parse(dr.Field<string>("TermLeftInMonths"));
                loan.NoEmisPayableUntilYear = int.Parse(dr.Field<string>("NoEMISPayableUntilYear"));
                loan.Description = dr.Field<string>("Description");
                return loan;
            }
            return null;
        }

        private void btnDeleteLoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Loan loan = convertSelectedRowDataToLoan();
                LoanInfo laonInfo = new LoanInfo();
                laonInfo.Delete(loan);
                fillupLoanInfo();
            }
        }

        private void btnCancelLoan_Click(object sender, EventArgs e)
        {
            grpLoanDetails.Enabled = false;
            Loan loan = convertSelectedRowDataToLoan();
            displayLoanData(loan);
        }

        private void dtGridLoan_SelectionChanged(object sender, EventArgs e)
        {
            Loan loan = convertSelectedRowDataToLoan();
            displayLoanData(loan);
        }

        private void cmbIncomeSource_SelectedIndexChanged(object sender, EventArgs e)
        {           
            btnSalaryDetails.Enabled = cmbIncomeSource.Text.Equals("Salary", StringComparison.OrdinalIgnoreCase);            
        }

        private void btnSalaryDetails_Click(object sender, EventArgs e)
        {
            grpSalaryDetails.Enabled = true;
        }

        private void rdoClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoClient.Checked)
                lblIncomeFromName.Text = _client.Name;
        }

        private void rdoSpouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSpouse.Checked)
                lblIncomeFromName.Text = getSpouseName();
        }

        private string getSpouseName()
        {
            if (!string.IsNullOrEmpty(txtSpouseName.Text))
                return txtSpouseName.Text;
            else
            {
                fillupPersonalDetails();
                return txtSpouseName.Text;
            }
        }
        private void calculateNetTakeHome()
        {
            double ctc = 0;
            double reimbursement = 0;
            double pfContribution = 0;
            double employerPFContribution = 0;
            double penssion = 0;
            double otherDeduction = 0;
            double netTakeHome = 0;
            double bonusAmt = 0;

            double.TryParse(txtCTC.Text, out ctc);
            double.TryParse(txtReimbusement.Text, out reimbursement);
            double.TryParse(txtEmployeePFContribution.Text, out pfContribution);
            double.TryParse(txtEmployerPFContribution.Text, out employerPFContribution);
            double.TryParse(txtSuperanuation.Text, out penssion);
            double.TryParse(txtOtherDeduction.Text, out otherDeduction);
            double.TryParse(txtAnnualBonusAmt.Text, out bonusAmt);

            netTakeHome = (ctc + reimbursement + pfContribution + employerPFContribution + penssion) - otherDeduction;
            txtNetTakeHome.Text = netTakeHome.ToString("#,000.00");
            txtAnnualIncome.Text = (netTakeHome + bonusAmt).ToString("#,000.00");
        }

        private void txtCTC_Leave(object sender, EventArgs e)
        {
            calculateNetTakeHome();
        }

        private void txtReimbusement_Leave(object sender, EventArgs e)
        {
            calculateNetTakeHome();
        }

        private void txtEmployeePFContribution_Leave(object sender, EventArgs e)
        {
            calculateNetTakeHome();
        }

        private void txtEmployerPFContribution_Leave(object sender, EventArgs e)
        {
            calculateNetTakeHome();
        }

        private void txtSuperanuation_Leave(object sender, EventArgs e)
        {
            calculateNetTakeHome();
        }

        private void txtOtherDeduction_Leave(object sender, EventArgs e)
        {
            calculateNetTakeHome();
        }

        private void txtNetTakeHome_Leave(object sender, EventArgs e)
        {
            calculateNetTakeHome();
        }

        private void txtAnnualBonusAmt_Leave(object sender, EventArgs e)
        {
            calculateNetTakeHome();
        }       
    }
}
