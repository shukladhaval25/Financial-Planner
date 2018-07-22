﻿namespace FinancialPlannerClient.ProspectCustomer
{
    partial class ProspectCustomer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProspectCustomer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIsConvertedToCustomer = new System.Windows.Forms.CheckBox();
            this.chkStopSendingEmail = new System.Windows.Forms.CheckBox();
            this.txtRefBy = new System.Windows.Forms.TextBox();
            this.lblRefBy = new System.Windows.Forms.Label();
            this.dtEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.imgCollection = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.grpConverstion = new System.Windows.Forms.GroupBox();
            this.grpActionControls = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEditConversation = new System.Windows.Forms.Button();
            this.dataGridConversation = new System.Windows.Forms.DataGridView();
            this.imgLstProspectCustomer = new System.Windows.Forms.ImageList(this.components);
            this.btnAddConversation = new System.Windows.Forms.Button();
            this.btnShowConversation = new System.Windows.Forms.Button();
            this.btnHideConversation = new System.Windows.Forms.Button();
            this.toolTipProspeectClient = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.grpConverstion.SuspendLayout();
            this.grpActionControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConversation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkIsConvertedToCustomer);
            this.groupBox1.Controls.Add(this.chkStopSendingEmail);
            this.groupBox1.Controls.Add(this.txtRefBy);
            this.groupBox1.Controls.Add(this.lblRefBy);
            this.groupBox1.Controls.Add(this.dtEventDate);
            this.groupBox1.Controls.Add(this.lblEventDate);
            this.groupBox1.Controls.Add(this.txtEvent);
            this.groupBox1.Controls.Add(this.lblEvent);
            this.groupBox1.Controls.Add(this.txtOccupation);
            this.groupBox1.Controls.Add(this.lblOccupation);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPhoneNo);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblPhoneNo);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propsect Customer Information";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(443, 161);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(251, 75);
            this.txtRemark.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Remark:";
            // 
            // chkIsConvertedToCustomer
            // 
            this.chkIsConvertedToCustomer.AutoSize = true;
            this.chkIsConvertedToCustomer.Location = new System.Drawing.Point(527, 115);
            this.chkIsConvertedToCustomer.Name = "chkIsConvertedToCustomer";
            this.chkIsConvertedToCustomer.Size = new System.Drawing.Size(115, 17);
            this.chkIsConvertedToCustomer.TabIndex = 22;
            this.chkIsConvertedToCustomer.Text = "Converted to client";
            this.chkIsConvertedToCustomer.UseVisualStyleBackColor = true;
            // 
            // chkStopSendingEmail
            // 
            this.chkStopSendingEmail.AutoSize = true;
            this.chkStopSendingEmail.Location = new System.Drawing.Point(527, 79);
            this.chkStopSendingEmail.Name = "chkStopSendingEmail";
            this.chkStopSendingEmail.Size = new System.Drawing.Size(164, 17);
            this.chkStopSendingEmail.TabIndex = 21;
            this.chkStopSendingEmail.Text = "Stop sending email by system";
            this.chkStopSendingEmail.UseVisualStyleBackColor = true;
            // 
            // txtRefBy
            // 
            this.txtRefBy.Location = new System.Drawing.Point(527, 37);
            this.txtRefBy.Name = "txtRefBy";
            this.txtRefBy.Size = new System.Drawing.Size(167, 20);
            this.txtRefBy.TabIndex = 20;
            // 
            // lblRefBy
            // 
            this.lblRefBy.AutoSize = true;
            this.lblRefBy.Location = new System.Drawing.Point(440, 40);
            this.lblRefBy.Name = "lblRefBy";
            this.lblRefBy.Size = new System.Drawing.Size(81, 13);
            this.lblRefBy.TabIndex = 19;
            this.lblRefBy.Text = "Referenced By:";
            // 
            // dtEventDate
            // 
            this.dtEventDate.Location = new System.Drawing.Point(158, 215);
            this.dtEventDate.Name = "dtEventDate";
            this.dtEventDate.Size = new System.Drawing.Size(268, 20);
            this.dtEventDate.TabIndex = 18;
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(30, 223);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(64, 13);
            this.lblEventDate.TabIndex = 17;
            this.lblEventDate.Text = "Event Date:";
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(158, 183);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(268, 20);
            this.txtEvent.TabIndex = 16;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(30, 186);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(93, 13);
            this.lblEvent.TabIndex = 15;
            this.lblEvent.Text = "Event Information:";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(158, 148);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(268, 20);
            this.txtOccupation.TabIndex = 14;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(30, 151);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(65, 13);
            this.lblOccupation.TabIndex = 13;
            this.lblOccupation.Text = "Occupation:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(158, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(158, 76);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(268, 20);
            this.txtPhoneNo.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 20);
            this.txtName.TabIndex = 10;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(27, 112);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(35, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Email:";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(27, 76);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(58, 13);
            this.lblPhoneNo.TabIndex = 8;
            this.lblPhoneNo.Text = "Phone No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.ImageKey = "icons8-cancel-16.png";
            this.btnCancel.ImageList = this.imgCollection;
            this.btnCancel.Location = new System.Drawing.Point(645, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.toolTipProspeectClient.SetToolTip(this.btnCancel, "Cancel and close.");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imgCollection
            // 
            this.imgCollection.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCollection.ImageStream")));
            this.imgCollection.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCollection.Images.SetKeyName(0, "Add-Action.png");
            this.imgCollection.Images.SetKeyName(1, "delete.png");
            this.imgCollection.Images.SetKeyName(2, "deleteline.png");
            this.imgCollection.Images.SetKeyName(3, "drop-add.gif");
            this.imgCollection.Images.SetKeyName(4, "Edit.png");
            this.imgCollection.Images.SetKeyName(5, "icons8-cancel-16.png");
            this.imgCollection.Images.SetKeyName(6, "icons8-save-close-16.png");
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.ImageKey = "icons8-save-close-16.png";
            this.btnSave.ImageList = this.imgCollection;
            this.btnSave.Location = new System.Drawing.Point(564, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.toolTipProspeectClient.SetToolTip(this.btnSave, "Save prospect client data.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpConverstion
            // 
            this.grpConverstion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConverstion.Controls.Add(this.grpActionControls);
            this.grpConverstion.Controls.Add(this.dataGridConversation);
            this.grpConverstion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConverstion.Location = new System.Drawing.Point(17, 317);
            this.grpConverstion.Name = "grpConverstion";
            this.grpConverstion.Size = new System.Drawing.Size(702, 189);
            this.grpConverstion.TabIndex = 6;
            this.grpConverstion.TabStop = false;
            this.grpConverstion.Text = "Conversation Details";
            this.grpConverstion.Visible = false;
            // 
            // grpActionControls
            // 
            this.grpActionControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActionControls.Controls.Add(this.btnDelete);
            this.grpActionControls.Controls.Add(this.btnAdd);
            this.grpActionControls.Controls.Add(this.btnEditConversation);
            this.grpActionControls.Location = new System.Drawing.Point(588, 151);
            this.grpActionControls.Name = "grpActionControls";
            this.grpActionControls.Size = new System.Drawing.Size(111, 38);
            this.grpActionControls.TabIndex = 7;
            this.grpActionControls.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imgCollection;
            this.btnDelete.Location = new System.Drawing.Point(76, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(29, 24);
            this.btnDelete.TabIndex = 4;
            this.toolTipProspeectClient.SetToolTip(this.btnDelete, "Remove conversation detail.");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 3;
            this.btnAdd.ImageList = this.imgCollection;
            this.btnAdd.Location = new System.Drawing.Point(6, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 24);
            this.btnAdd.TabIndex = 2;
            this.toolTipProspeectClient.SetToolTip(this.btnAdd, "Add conversation details");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddConversation_Click);
            // 
            // btnEditConversation
            // 
            this.btnEditConversation.ImageIndex = 4;
            this.btnEditConversation.ImageList = this.imgCollection;
            this.btnEditConversation.Location = new System.Drawing.Point(41, 10);
            this.btnEditConversation.Name = "btnEditConversation";
            this.btnEditConversation.Size = new System.Drawing.Size(29, 24);
            this.btnEditConversation.TabIndex = 3;
            this.toolTipProspeectClient.SetToolTip(this.btnEditConversation, "Edit conversation details");
            this.btnEditConversation.UseVisualStyleBackColor = true;
            this.btnEditConversation.Click += new System.EventHandler(this.btnEditConversation_Click);
            // 
            // dataGridConversation
            // 
            this.dataGridConversation.AllowUserToAddRows = false;
            this.dataGridConversation.AllowUserToDeleteRows = false;
            this.dataGridConversation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridConversation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConversation.Location = new System.Drawing.Point(3, 18);
            this.dataGridConversation.MultiSelect = false;
            this.dataGridConversation.Name = "dataGridConversation";
            this.dataGridConversation.ReadOnly = true;
            this.dataGridConversation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridConversation.Size = new System.Drawing.Size(696, 131);
            this.dataGridConversation.TabIndex = 0;
            // 
            // imgLstProspectCustomer
            // 
            this.imgLstProspectCustomer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstProspectCustomer.ImageStream")));
            this.imgLstProspectCustomer.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstProspectCustomer.Images.SetKeyName(0, "icons8-double-down-16.png");
            this.imgLstProspectCustomer.Images.SetKeyName(1, "icons8-double-up-16.png");
            this.imgLstProspectCustomer.Images.SetKeyName(2, "icons8-chat-16.png");
            // 
            // btnAddConversation
            // 
            this.btnAddConversation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddConversation.ImageKey = "icons8-chat-16.png";
            this.btnAddConversation.ImageList = this.imgLstProspectCustomer;
            this.btnAddConversation.Location = new System.Drawing.Point(166, 284);
            this.btnAddConversation.Name = "btnAddConversation";
            this.btnAddConversation.Size = new System.Drawing.Size(147, 26);
            this.btnAddConversation.TabIndex = 8;
            this.btnAddConversation.Text = "Add Conversation";
            this.toolTipProspeectClient.SetToolTip(this.btnAddConversation, "Add conversation detail.");
            this.btnAddConversation.UseVisualStyleBackColor = true;
            this.btnAddConversation.Click += new System.EventHandler(this.btnAddConversation_Click);
            // 
            // btnShowConversation
            // 
            this.btnShowConversation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowConversation.ImageKey = "icons8-double-down-16.png";
            this.btnShowConversation.ImageList = this.imgLstProspectCustomer;
            this.btnShowConversation.Location = new System.Drawing.Point(13, 284);
            this.btnShowConversation.Name = "btnShowConversation";
            this.btnShowConversation.Size = new System.Drawing.Size(147, 26);
            this.btnShowConversation.TabIndex = 5;
            this.btnShowConversation.Text = "Show Conversation";
            this.toolTipProspeectClient.SetToolTip(this.btnShowConversation, "Show conversation details");
            this.btnShowConversation.UseVisualStyleBackColor = true;
            this.btnShowConversation.Click += new System.EventHandler(this.btnShowConversation_Click);
            // 
            // btnHideConversation
            // 
            this.btnHideConversation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHideConversation.ImageKey = "icons8-double-up-16.png";
            this.btnHideConversation.ImageList = this.imgLstProspectCustomer;
            this.btnHideConversation.Location = new System.Drawing.Point(14, 284);
            this.btnHideConversation.Name = "btnHideConversation";
            this.btnHideConversation.Size = new System.Drawing.Size(147, 26);
            this.btnHideConversation.TabIndex = 7;
            this.btnHideConversation.Text = "Hide Conversation";
            this.btnHideConversation.UseVisualStyleBackColor = true;
            this.btnHideConversation.Click += new System.EventHandler(this.btnHideConversation_Click);
            // 
            // toolTipProspeectClient
            // 
            this.toolTipProspeectClient.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ProspectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 509);
            this.Controls.Add(this.btnAddConversation);
            this.Controls.Add(this.grpConverstion);
            this.Controls.Add(this.btnShowConversation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHideConversation);
            this.Name = "ProspectCustomer";
            this.Text = "Prospect Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProspectCustomer_FormClosing);
            this.Load += new System.EventHandler(this.ProspectCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpConverstion.ResumeLayout(false);
            this.grpActionControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConversation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtEventDate;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowConversation;
        private System.Windows.Forms.GroupBox grpConverstion;
        private System.Windows.Forms.DataGridView dataGridConversation;
        private System.Windows.Forms.Button btnHideConversation;
        private System.Windows.Forms.CheckBox chkStopSendingEmail;
        private System.Windows.Forms.TextBox txtRefBy;
        private System.Windows.Forms.Label lblRefBy;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIsConvertedToCustomer;
        private System.Windows.Forms.ImageList imgLstProspectCustomer;
        private System.Windows.Forms.Button btnAddConversation;
        private System.Windows.Forms.GroupBox grpActionControls;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEditConversation;
        private System.Windows.Forms.ImageList imgCollection;
        private System.Windows.Forms.ToolTip toolTipProspeectClient;
    }
}