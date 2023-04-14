namespace WindowsBanking
{
    partial class ClientData
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
            System.Windows.Forms.Label dateCreatedLabel;
            System.Windows.Forms.Label fullAddressLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label clientNumberLabel;
            System.Windows.Forms.Label accountNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.Label descriptionLabel2;
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.clientNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateCreatedLabel1 = new System.Windows.Forms.Label();
            this.fullAddressLabel1 = new System.Windows.Forms.Label();
            this.fullNameLabel1 = new System.Windows.Forms.Label();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.descriptionLabel3 = new System.Windows.Forms.Label();
            this.bankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balanceMaskedLabel = new EWSoftware.MaskedLabelControl.MaskedLabel();
            this.notesLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.accountNumberComboBox = new System.Windows.Forms.ComboBox();
            this.lnkDetails = new System.Windows.Forms.LinkLabel();
            this.lnkProcess = new System.Windows.Forms.LinkLabel();
            dateCreatedLabel = new System.Windows.Forms.Label();
            fullAddressLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            clientNumberLabel = new System.Windows.Forms.Label();
            accountNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            descriptionLabel2 = new System.Windows.Forms.Label();
            this.grpClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateCreatedLabel
            // 
            dateCreatedLabel.AutoSize = true;
            dateCreatedLabel.Location = new System.Drawing.Point(43, 127);
            dateCreatedLabel.Name = "dateCreatedLabel";
            dateCreatedLabel.Size = new System.Drawing.Size(73, 13);
            dateCreatedLabel.TabIndex = 2;
            dateCreatedLabel.Text = "Date Created:";
            dateCreatedLabel.Click += new System.EventHandler(this.dateCreatedLabel_Click);
            // 
            // fullAddressLabel
            // 
            fullAddressLabel.AutoSize = true;
            fullAddressLabel.Location = new System.Drawing.Point(43, 95);
            fullAddressLabel.Name = "fullAddressLabel";
            fullAddressLabel.Size = new System.Drawing.Size(67, 13);
            fullAddressLabel.TabIndex = 4;
            fullAddressLabel.Text = "Full Address:";
            fullAddressLabel.Click += new System.EventHandler(this.fullAddressLabel_Click);
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(43, 63);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 6;
            fullNameLabel.Text = "Full Name:";
            fullNameLabel.Click += new System.EventHandler(this.fullNameLabel_Click);
            // 
            // clientNumberLabel
            // 
            clientNumberLabel.AutoSize = true;
            clientNumberLabel.Location = new System.Drawing.Point(43, 34);
            clientNumberLabel.Name = "clientNumberLabel";
            clientNumberLabel.Size = new System.Drawing.Size(76, 13);
            clientNumberLabel.TabIndex = 7;
            clientNumberLabel.Text = "Client Number:";
            clientNumberLabel.Click += new System.EventHandler(this.clientNumberLabel_Click);
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new System.Drawing.Point(43, 33);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new System.Drawing.Size(90, 13);
            accountNumberLabel.TabIndex = 2;
            accountNumberLabel.Text = "Account Number:";
            accountNumberLabel.Click += new System.EventHandler(this.accountNumberLabel_Click);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(43, 61);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(35, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "State:";
            descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(43, 93);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 6;
            notesLabel.Text = "Notes:";
            notesLabel.Click += new System.EventHandler(this.notesLabel_Click);
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new System.Drawing.Point(422, 33);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(49, 13);
            balanceLabel.TabIndex = 8;
            balanceLabel.Text = "Balance:";
            // 
            // descriptionLabel2
            // 
            descriptionLabel2.AutoSize = true;
            descriptionLabel2.Location = new System.Drawing.Point(394, 60);
            descriptionLabel2.Name = "descriptionLabel2";
            descriptionLabel2.Size = new System.Drawing.Size(77, 13);
            descriptionLabel2.TabIndex = 10;
            descriptionLabel2.Text = "Account Type:";
            descriptionLabel2.Click += new System.EventHandler(this.descriptionLabel2_Click);
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(clientNumberLabel);
            this.grpClient.Controls.Add(this.clientNumberMaskedTextBox);
            this.grpClient.Controls.Add(dateCreatedLabel);
            this.grpClient.Controls.Add(this.dateCreatedLabel1);
            this.grpClient.Controls.Add(fullAddressLabel);
            this.grpClient.Controls.Add(this.fullAddressLabel1);
            this.grpClient.Controls.Add(fullNameLabel);
            this.grpClient.Controls.Add(this.fullNameLabel1);
            this.grpClient.Location = new System.Drawing.Point(55, 25);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(677, 184);
            this.grpClient.TabIndex = 0;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client Data";
            this.grpClient.Enter += new System.EventHandler(this.grpClient_Enter);
            // 
            // clientNumberMaskedTextBox
            // 
            this.clientNumberMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientNumberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNumber", true));
            this.clientNumberMaskedTextBox.Location = new System.Drawing.Point(154, 32);
            this.clientNumberMaskedTextBox.Mask = "0000-0000";
            this.clientNumberMaskedTextBox.Name = "clientNumberMaskedTextBox";
            this.clientNumberMaskedTextBox.Size = new System.Drawing.Size(133, 20);
            this.clientNumberMaskedTextBox.TabIndex = 0;
            this.clientNumberMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.clientNumberMaskedTextBox.ModifiedChanged += new System.EventHandler(this.clientNumberMaskedTextBox_ModifiedChanged);
            this.clientNumberMaskedTextBox.Leave += new System.EventHandler(this.clientNumberMaskedTextBox_Leave);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BankOfBIT_JC.Models.Client);
            // 
            // dateCreatedLabel1
            // 
            this.dateCreatedLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateCreatedLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "DateCreated", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateCreatedLabel1.Location = new System.Drawing.Point(154, 126);
            this.dateCreatedLabel1.Name = "dateCreatedLabel1";
            this.dateCreatedLabel1.Size = new System.Drawing.Size(133, 23);
            this.dateCreatedLabel1.TabIndex = 3;
            this.dateCreatedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullAddressLabel1
            // 
            this.fullAddressLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullAddressLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "FullAddress", true));
            this.fullAddressLabel1.Location = new System.Drawing.Point(154, 94);
            this.fullAddressLabel1.Name = "fullAddressLabel1";
            this.fullAddressLabel1.Size = new System.Drawing.Size(471, 23);
            this.fullAddressLabel1.TabIndex = 2;
            this.fullAddressLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fullAddressLabel1.Click += new System.EventHandler(this.fullAddressLabel1_Click);
            // 
            // fullNameLabel1
            // 
            this.fullNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "FullName", true));
            this.fullNameLabel1.Location = new System.Drawing.Point(154, 62);
            this.fullNameLabel1.Name = "fullNameLabel1";
            this.fullNameLabel1.Size = new System.Drawing.Size(471, 23);
            this.fullNameLabel1.TabIndex = 1;
            this.fullNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fullNameLabel1.Click += new System.EventHandler(this.fullNameLabel1_Click);
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(descriptionLabel2);
            this.grpAccount.Controls.Add(this.descriptionLabel3);
            this.grpAccount.Controls.Add(balanceLabel);
            this.grpAccount.Controls.Add(this.balanceMaskedLabel);
            this.grpAccount.Controls.Add(notesLabel);
            this.grpAccount.Controls.Add(this.notesLabel1);
            this.grpAccount.Controls.Add(descriptionLabel);
            this.grpAccount.Controls.Add(this.descriptionLabel1);
            this.grpAccount.Controls.Add(accountNumberLabel);
            this.grpAccount.Controls.Add(this.accountNumberComboBox);
            this.grpAccount.Controls.Add(this.lnkDetails);
            this.grpAccount.Controls.Add(this.lnkProcess);
            this.grpAccount.Location = new System.Drawing.Point(55, 189);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(677, 223);
            this.grpAccount.TabIndex = 1;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Bank Account Data";
            // 
            // descriptionLabel3
            // 
            this.descriptionLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "Description", true));
            this.descriptionLabel3.Location = new System.Drawing.Point(487, 60);
            this.descriptionLabel3.Name = "descriptionLabel3";
            this.descriptionLabel3.Size = new System.Drawing.Size(138, 23);
            this.descriptionLabel3.TabIndex = 3;
            this.descriptionLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bankAccountBindingSource
            // 
            this.bankAccountBindingSource.DataSource = typeof(BankOfBIT_JC.Models.BankAccount);
            // 
            // balanceMaskedLabel
            // 
            this.balanceMaskedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceMaskedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "Balance", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.balanceMaskedLabel.Location = new System.Drawing.Point(487, 32);
            this.balanceMaskedLabel.Name = "balanceMaskedLabel";
            this.balanceMaskedLabel.Size = new System.Drawing.Size(138, 23);
            this.balanceMaskedLabel.TabIndex = 1;
            this.balanceMaskedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.balanceMaskedLabel.Click += new System.EventHandler(this.balanceMaskedLabel_Click);
            // 
            // notesLabel1
            // 
            this.notesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "Notes", true));
            this.notesLabel1.Location = new System.Drawing.Point(153, 92);
            this.notesLabel1.Name = "notesLabel1";
            this.notesLabel1.Size = new System.Drawing.Size(472, 73);
            this.notesLabel1.TabIndex = 4;
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "AccountState.Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(153, 60);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(121, 23);
            this.descriptionLabel1.TabIndex = 2;
            this.descriptionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // accountNumberComboBox
            // 
            this.accountNumberComboBox.DataSource = this.bankAccountBindingSource;
            this.accountNumberComboBox.DisplayMember = "AccountNumber";
            this.accountNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountNumberComboBox.FormattingEnabled = true;
            this.accountNumberComboBox.Location = new System.Drawing.Point(153, 32);
            this.accountNumberComboBox.Name = "accountNumberComboBox";
            this.accountNumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.accountNumberComboBox.TabIndex = 0;
            // 
            // lnkDetails
            // 
            this.lnkDetails.AutoSize = true;
            this.lnkDetails.Enabled = false;
            this.lnkDetails.Location = new System.Drawing.Point(432, 185);
            this.lnkDetails.Name = "lnkDetails";
            this.lnkDetails.Size = new System.Drawing.Size(65, 13);
            this.lnkDetails.TabIndex = 6;
            this.lnkDetails.TabStop = true;
            this.lnkDetails.Text = "View Details";
            this.lnkDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDetails_LinkClicked);
            // 
            // lnkProcess
            // 
            this.lnkProcess.AutoSize = true;
            this.lnkProcess.Enabled = false;
            this.lnkProcess.Location = new System.Drawing.Point(207, 185);
            this.lnkProcess.Name = "lnkProcess";
            this.lnkProcess.Size = new System.Drawing.Size(104, 13);
            this.lnkProcess.TabIndex = 5;
            this.lnkProcess.TabStop = true;
            this.lnkProcess.Text = "Process Transaction";
            this.lnkProcess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProcess_LinkClicked);
            // 
            // ClientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.grpClient);
            this.Name = "ClientData";
            this.Text = "ClientData";
            this.Load += new System.EventHandler(this.ClientData_Load);
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.LinkLabel lnkDetails;
        private System.Windows.Forms.LinkLabel lnkProcess;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Label dateCreatedLabel1;
        private System.Windows.Forms.Label fullAddressLabel1;
        private System.Windows.Forms.Label fullNameLabel1;
        private System.Windows.Forms.MaskedTextBox clientNumberMaskedTextBox;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.BindingSource bankAccountBindingSource;
        private System.Windows.Forms.ComboBox accountNumberComboBox;
        private EWSoftware.MaskedLabelControl.MaskedLabel balanceMaskedLabel;
        private System.Windows.Forms.Label notesLabel1;
        private System.Windows.Forms.Label descriptionLabel3;
    }
}