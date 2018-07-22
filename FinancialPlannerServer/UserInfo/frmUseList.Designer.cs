namespace FinancialPlannerServer.UserInfo
{
    partial class frmUseList
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
            this.pnlUser = new System.Windows.Forms.Panel();
            this.grpActionControls = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtGridUser = new System.Windows.Forms.DataGridView();
            this.lblUserlst = new System.Windows.Forms.Label();
            this.pnlUser.SuspendLayout();
            this.grpActionControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.grpActionControls);
            this.pnlUser.Controls.Add(this.dtGridUser);
            this.pnlUser.Controls.Add(this.lblUserlst);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(576, 319);
            this.pnlUser.TabIndex = 0;
            // 
            // grpActionControls
            // 
            this.grpActionControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActionControls.Controls.Add(this.btnDelete);
            this.grpActionControls.Controls.Add(this.btnAdd);
            this.grpActionControls.Controls.Add(this.btnEdit);
            this.grpActionControls.Location = new System.Drawing.Point(406, 3);
            this.grpActionControls.Name = "grpActionControls";
            this.grpActionControls.Size = new System.Drawing.Size(158, 38);
            this.grpActionControls.TabIndex = 5;
            this.grpActionControls.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(108, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 24);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(57, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 24);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtGridUser
            // 
            this.dtGridUser.AllowUserToAddRows = false;
            this.dtGridUser.AllowUserToDeleteRows = false;
            this.dtGridUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUser.Location = new System.Drawing.Point(12, 47);
            this.dtGridUser.MultiSelect = false;
            this.dtGridUser.Name = "dtGridUser";
            this.dtGridUser.ReadOnly = true;
            this.dtGridUser.RowHeadersVisible = false;
            this.dtGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridUser.Size = new System.Drawing.Size(552, 260);
            this.dtGridUser.TabIndex = 1;
            // 
            // lblUserlst
            // 
            this.lblUserlst.AutoSize = true;
            this.lblUserlst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserlst.Location = new System.Drawing.Point(13, 13);
            this.lblUserlst.Name = "lblUserlst";
            this.lblUserlst.Size = new System.Drawing.Size(64, 17);
            this.lblUserlst.TabIndex = 0;
            this.lblUserlst.Text = "User List";
            // 
            // frmUseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 319);
            this.Controls.Add(this.pnlUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUseList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmUseList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUseList_FormClosing);
            this.Load += new System.EventHandler(this.frmUseList_Load);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.grpActionControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.DataGridView dtGridUser;
        private System.Windows.Forms.Label lblUserlst;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpActionControls;
    }
}