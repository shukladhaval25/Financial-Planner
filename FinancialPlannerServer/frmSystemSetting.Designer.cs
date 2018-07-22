namespace FinancialPlannerServer
{
    partial class frmSystemSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemSetting));
            this.grpEmailSetting = new System.Windows.Forms.GroupBox();
            this.tabEmailSetting = new System.Windows.Forms.TabControl();
            this.tabpageSMTPSetting = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.btnSaveSMTPSetting = new System.Windows.Forms.Button();
            this.chkIsSSL = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lblFromEmail = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblSMTPHost = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSMTPPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.tbtnEmailOutgoingSetting = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDiallog = new System.Windows.Forms.FolderBrowserDialog();
            this.grpEmailSetting.SuspendLayout();
            this.tabEmailSetting.SuspendLayout();
            this.tabpageSMTPSetting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmailSetting
            // 
            this.grpEmailSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEmailSetting.Controls.Add(this.tabEmailSetting);
            this.grpEmailSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmailSetting.Location = new System.Drawing.Point(8, 11);
            this.grpEmailSetting.Name = "grpEmailSetting";
            this.grpEmailSetting.Size = new System.Drawing.Size(868, 303);
            this.grpEmailSetting.TabIndex = 0;
            this.grpEmailSetting.TabStop = false;
            this.grpEmailSetting.Text = "Email Configuration";
            // 
            // tabEmailSetting
            // 
            this.tabEmailSetting.Controls.Add(this.tabpageSMTPSetting);
            this.tabEmailSetting.Controls.Add(this.tbtnEmailOutgoingSetting);
            this.tabEmailSetting.ImageList = this.imageList1;
            this.tabEmailSetting.Location = new System.Drawing.Point(6, 20);
            this.tabEmailSetting.Name = "tabEmailSetting";
            this.tabEmailSetting.SelectedIndex = 0;
            this.tabEmailSetting.Size = new System.Drawing.Size(856, 277);
            this.tabEmailSetting.TabIndex = 13;
            // 
            // tabpageSMTPSetting
            // 
            this.tabpageSMTPSetting.Controls.Add(this.label3);
            this.tabpageSMTPSetting.Controls.Add(this.txtFromEmail);
            this.tabpageSMTPSetting.Controls.Add(this.btnSaveSMTPSetting);
            this.tabpageSMTPSetting.Controls.Add(this.chkIsSSL);
            this.tabpageSMTPSetting.Controls.Add(this.button4);
            this.tabpageSMTPSetting.Controls.Add(this.lblFromEmail);
            this.tabpageSMTPSetting.Controls.Add(this.textBox5);
            this.tabpageSMTPSetting.Controls.Add(this.label2);
            this.tabpageSMTPSetting.Controls.Add(this.txtHost);
            this.tabpageSMTPSetting.Controls.Add(this.lblSMTPHost);
            this.tabpageSMTPSetting.Controls.Add(this.textBox4);
            this.tabpageSMTPSetting.Controls.Add(this.label1);
            this.tabpageSMTPSetting.Controls.Add(this.lblSMTPPort);
            this.tabpageSMTPSetting.Controls.Add(this.txtPort);
            this.tabpageSMTPSetting.ImageKey = "icons8-group-message-30.png";
            this.tabpageSMTPSetting.Location = new System.Drawing.Point(4, 27);
            this.tabpageSMTPSetting.Name = "tabpageSMTPSetting";
            this.tabpageSMTPSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageSMTPSetting.Size = new System.Drawing.Size(848, 246);
            this.tabpageSMTPSetting.TabIndex = 0;
            this.tabpageSMTPSetting.Text = "SMTP Setting";
            this.tabpageSMTPSetting.ToolTipText = "This is email setting for outgoing.";
            this.tabpageSMTPSetting.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Set SMTP setting for sending ";
            // 
            // txtFromEmail
            // 
            this.txtFromEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromEmail.Location = new System.Drawing.Point(99, 43);
            this.txtFromEmail.Name = "txtFromEmail";
            this.txtFromEmail.Size = new System.Drawing.Size(467, 21);
            this.txtFromEmail.TabIndex = 5;
            // 
            // btnSaveSMTPSetting
            // 
            this.btnSaveSMTPSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSMTPSetting.Location = new System.Drawing.Point(99, 202);
            this.btnSaveSMTPSetting.Name = "btnSaveSMTPSetting";
            this.btnSaveSMTPSetting.Size = new System.Drawing.Size(90, 23);
            this.btnSaveSMTPSetting.TabIndex = 10;
            this.btnSaveSMTPSetting.Text = "Save Change";
            this.btnSaveSMTPSetting.UseVisualStyleBackColor = true;
            this.btnSaveSMTPSetting.Click += new System.EventHandler(this.btnSaveSMTPSetting_Click);
            // 
            // chkIsSSL
            // 
            this.chkIsSSL.AutoSize = true;
            this.chkIsSSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsSSL.Location = new System.Drawing.Point(99, 175);
            this.chkIsSSL.Name = "chkIsSSL";
            this.chkIsSSL.Size = new System.Drawing.Size(224, 19);
            this.chkIsSSL.TabIndex = 11;
            this.chkIsSSL.Text = "SMTP server requries authentication";
            this.chkIsSSL.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(173, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Restore Default";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblFromEmail
            // 
            this.lblFromEmail.AutoSize = true;
            this.lblFromEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromEmail.Location = new System.Drawing.Point(12, 46);
            this.lblFromEmail.Name = "lblFromEmail";
            this.lblFromEmail.Size = new System.Drawing.Size(74, 15);
            this.lblFromEmail.TabIndex = 4;
            this.lblFromEmail.Text = "From Email:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(99, 148);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(181, 21);
            this.textBox5.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(99, 70);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(181, 21);
            this.txtHost.TabIndex = 1;
            // 
            // lblSMTPHost
            // 
            this.lblSMTPHost.AutoSize = true;
            this.lblSMTPHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMTPHost.Location = new System.Drawing.Point(12, 73);
            this.lblSMTPHost.Name = "lblSMTPHost";
            this.lblSMTPHost.Size = new System.Drawing.Size(72, 15);
            this.lblSMTPHost.TabIndex = 0;
            this.lblSMTPHost.Text = "SMTP Host:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(99, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 21);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name:";
            // 
            // lblSMTPPort
            // 
            this.lblSMTPPort.AutoSize = true;
            this.lblSMTPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMTPPort.Location = new System.Drawing.Point(15, 100);
            this.lblSMTPPort.Name = "lblSMTPPort";
            this.lblSMTPPort.Size = new System.Drawing.Size(69, 15);
            this.lblSMTPPort.TabIndex = 2;
            this.lblSMTPPort.Text = "SMTP Port:";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(99, 97);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(67, 21);
            this.txtPort.TabIndex = 3;
            // 
            // tbtnEmailOutgoingSetting
            // 
            this.tbtnEmailOutgoingSetting.Location = new System.Drawing.Point(4, 27);
            this.tbtnEmailOutgoingSetting.Name = "tbtnEmailOutgoingSetting";
            this.tbtnEmailOutgoingSetting.Size = new System.Drawing.Size(848, 246);
            this.tbtnEmailOutgoingSetting.TabIndex = 1;
            this.tbtnEmailOutgoingSetting.Text = "Email Outgoing";
            this.tbtnEmailOutgoingSetting.ToolTipText = "Setting for email send to customer by system.";
            this.tbtnEmailOutgoingSetting.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "miscellaneous.png");
            this.imageList1.Images.SetKeyName(1, "icons8-double-up-16.png");
            this.imageList1.Images.SetKeyName(2, "icons8-double-down-16.png");
            this.imageList1.Images.SetKeyName(3, "icons8-group-message-30.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 94);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 21);
            this.button3.TabIndex = 11;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save Change";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(102, 33);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(423, 21);
            this.textBox8.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Application Path";
            // 
            // frmSystemSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEmailSetting);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystemSetting";
            this.Text = "System Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSystemSetting_FormClosing);
            this.grpEmailSetting.ResumeLayout(false);
            this.tabEmailSetting.ResumeLayout(false);
            this.tabpageSMTPSetting.ResumeLayout(false);
            this.tabpageSMTPSetting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmailSetting;
        private System.Windows.Forms.Button btnSaveSMTPSetting;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFromEmail;
        private System.Windows.Forms.Label lblFromEmail;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblSMTPPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblSMTPHost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDiallog;
        private System.Windows.Forms.TabControl tabEmailSetting;
        private System.Windows.Forms.TabPage tabpageSMTPSetting;
        private System.Windows.Forms.CheckBox chkIsSSL;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbtnEmailOutgoingSetting;
    }
}