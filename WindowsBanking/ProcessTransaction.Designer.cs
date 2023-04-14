namespace WindowsBanking
{
    partial class ProcessTransaction
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
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label accountNumberLabel;
            System.Windows.Forms.Label clientNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.balanceLabel1 = new System.Windows.Forms.Label();
            this.bankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameLabel1 = new System.Windows.Forms.Label();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountNumberMaskedLabel = new EWSoftware.MaskedLabelControl.MaskedLabel();
            this.clientNumberMaskedLabel = new EWSoftware.MaskedLabelControl.MaskedLabel();
            this.grpTransaction = new System.Windows.Forms.GroupBox();
            this.descriptionComboBox = new System.Windows.Forms.ComboBox();
            this.transactionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lnkReturn = new System.Windows.Forms.LinkLabel();
            this.lnkUpdate = new System.Windows.Forms.LinkLabel();
            this.cboPayeeAccount = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPayeeAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoAdditionalAccounts = new System.Windows.Forms.Label();
            this.payeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            balanceLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            accountNumberLabel = new System.Windows.Forms.Label();
            clientNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.grpClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.grpTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new System.Drawing.Point(381, 61);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(49, 13);
            balanceLabel.TabIndex = 14;
            balanceLabel.Text = "Balance:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(373, 30);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 12;
            fullNameLabel.Text = "Full Name:";
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new System.Drawing.Point(96, 61);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new System.Drawing.Size(90, 13);
            accountNumberLabel.TabIndex = 10;
            accountNumberLabel.Text = "Account Number:";
            // 
            // clientNumberLabel
            // 
            clientNumberLabel.AutoSize = true;
            clientNumberLabel.Location = new System.Drawing.Point(96, 30);
            clientNumberLabel.Name = "clientNumberLabel";
            clientNumberLabel.Size = new System.Drawing.Size(76, 13);
            clientNumberLabel.TabIndex = 8;
            clientNumberLabel.Text = "Client Number:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(168, 68);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 13);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Transaction Type:";
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(balanceLabel);
            this.grpClient.Controls.Add(this.balanceLabel1);
            this.grpClient.Controls.Add(fullNameLabel);
            this.grpClient.Controls.Add(this.fullNameLabel1);
            this.grpClient.Controls.Add(accountNumberLabel);
            this.grpClient.Controls.Add(this.accountNumberMaskedLabel);
            this.grpClient.Controls.Add(clientNumberLabel);
            this.grpClient.Controls.Add(this.clientNumberMaskedLabel);
            this.grpClient.Location = new System.Drawing.Point(47, 48);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(694, 108);
            this.grpClient.TabIndex = 0;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client Data";
            this.grpClient.Enter += new System.EventHandler(this.grpClient_Enter);
            // 
            // balanceLabel1
            // 
            this.balanceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "Balance", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.balanceLabel1.Location = new System.Drawing.Point(436, 61);
            this.balanceLabel1.Name = "balanceLabel1";
            this.balanceLabel1.Size = new System.Drawing.Size(152, 23);
            this.balanceLabel1.TabIndex = 15;
            this.balanceLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bankAccountBindingSource
            // 
            this.bankAccountBindingSource.DataSource = typeof(BankOfBIT_JC.Models.BankAccount);
            // 
            // fullNameLabel1
            // 
            this.fullNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "FullName", true));
            this.fullNameLabel1.Location = new System.Drawing.Point(436, 30);
            this.fullNameLabel1.Name = "fullNameLabel1";
            this.fullNameLabel1.Size = new System.Drawing.Size(152, 23);
            this.fullNameLabel1.TabIndex = 13;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BankOfBIT_JC.Models.Client);
            // 
            // accountNumberMaskedLabel
            // 
            this.accountNumberMaskedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountNumberMaskedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "AccountNumber", true));
            this.accountNumberMaskedLabel.Location = new System.Drawing.Point(192, 61);
            this.accountNumberMaskedLabel.Name = "accountNumberMaskedLabel";
            this.accountNumberMaskedLabel.Size = new System.Drawing.Size(100, 23);
            this.accountNumberMaskedLabel.TabIndex = 11;
            // 
            // clientNumberMaskedLabel
            // 
            this.clientNumberMaskedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientNumberMaskedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNumber", true));
            this.clientNumberMaskedLabel.Location = new System.Drawing.Point(192, 30);
            this.clientNumberMaskedLabel.Mask = "0000-0000";
            this.clientNumberMaskedLabel.Name = "clientNumberMaskedLabel";
            this.clientNumberMaskedLabel.Size = new System.Drawing.Size(100, 23);
            this.clientNumberMaskedLabel.TabIndex = 9;
            this.clientNumberMaskedLabel.Text = "    -";
            // 
            // grpTransaction
            // 
            this.grpTransaction.Controls.Add(descriptionLabel);
            this.grpTransaction.Controls.Add(this.descriptionComboBox);
            this.grpTransaction.Controls.Add(this.lnkReturn);
            this.grpTransaction.Controls.Add(this.lnkUpdate);
            this.grpTransaction.Controls.Add(this.cboPayeeAccount);
            this.grpTransaction.Controls.Add(this.txtAmount);
            this.grpTransaction.Controls.Add(this.lblPayeeAccount);
            this.grpTransaction.Controls.Add(this.label1);
            this.grpTransaction.Controls.Add(this.lblNoAdditionalAccounts);
            this.grpTransaction.Location = new System.Drawing.Point(47, 187);
            this.grpTransaction.Name = "grpTransaction";
            this.grpTransaction.Size = new System.Drawing.Size(694, 227);
            this.grpTransaction.TabIndex = 1;
            this.grpTransaction.TabStop = false;
            this.grpTransaction.Text = "Perform Transaction";
            // 
            // descriptionComboBox
            // 
            this.descriptionComboBox.DataSource = this.transactionTypeBindingSource;
            this.descriptionComboBox.DisplayMember = "Description";
            this.descriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descriptionComboBox.FormattingEnabled = true;
            this.descriptionComboBox.Location = new System.Drawing.Point(303, 65);
            this.descriptionComboBox.Name = "descriptionComboBox";
            this.descriptionComboBox.Size = new System.Drawing.Size(201, 21);
            this.descriptionComboBox.TabIndex = 8;
            this.descriptionComboBox.ValueMember = "Description";
            this.descriptionComboBox.SelectedIndexChanged += new System.EventHandler(this.descriptionComboBox_SelectedIndexChanged);
            // 
            // transactionTypeBindingSource
            // 
            this.transactionTypeBindingSource.DataSource = typeof(BankOfBIT_JC.Models.TransactionType);
            // 
            // lnkReturn
            // 
            this.lnkReturn.AutoSize = true;
            this.lnkReturn.Location = new System.Drawing.Point(350, 186);
            this.lnkReturn.Name = "lnkReturn";
            this.lnkReturn.Size = new System.Drawing.Size(80, 13);
            this.lnkReturn.TabIndex = 5;
            this.lnkReturn.TabStop = true;
            this.lnkReturn.Text = "Return to Client";
            this.lnkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReturn_LinkClicked);
            // 
            // lnkUpdate
            // 
            this.lnkUpdate.AutoSize = true;
            this.lnkUpdate.Location = new System.Drawing.Point(252, 186);
            this.lnkUpdate.Name = "lnkUpdate";
            this.lnkUpdate.Size = new System.Drawing.Size(42, 13);
            this.lnkUpdate.TabIndex = 4;
            this.lnkUpdate.TabStop = true;
            this.lnkUpdate.Text = "Update";
            this.lnkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdate_LinkClicked);
            // 
            // cboPayeeAccount
            // 
            this.cboPayeeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayeeAccount.FormattingEnabled = true;
            this.cboPayeeAccount.Location = new System.Drawing.Point(303, 129);
            this.cboPayeeAccount.Name = "cboPayeeAccount";
            this.cboPayeeAccount.Size = new System.Drawing.Size(201, 21);
            this.cboPayeeAccount.TabIndex = 3;
            this.cboPayeeAccount.Visible = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(303, 98);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(201, 20);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPayeeAccount
            // 
            this.lblPayeeAccount.AutoSize = true;
            this.lblPayeeAccount.Location = new System.Drawing.Point(223, 132);
            this.lblPayeeAccount.Name = "lblPayeeAccount";
            this.lblPayeeAccount.Size = new System.Drawing.Size(40, 13);
            this.lblPayeeAccount.TabIndex = 1;
            this.lblPayeeAccount.Text = "Payee:";
            this.lblPayeeAccount.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount:";
            // 
            // lblNoAdditionalAccounts
            // 
            this.lblNoAdditionalAccounts.Location = new System.Drawing.Point(300, 153);
            this.lblNoAdditionalAccounts.Name = "lblNoAdditionalAccounts";
            this.lblNoAdditionalAccounts.Size = new System.Drawing.Size(207, 33);
            this.lblNoAdditionalAccounts.TabIndex = 6;
            this.lblNoAdditionalAccounts.Text = "No accounts available to receive transfer.";
            this.lblNoAdditionalAccounts.Visible = false;
            // 
            // payeeBindingSource
            // 
            this.payeeBindingSource.DataSource = typeof(BankOfBIT_JC.Models.Payee);
            // 
            // ProcessTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTransaction);
            this.Controls.Add(this.grpClient);
            this.Name = "ProcessTransaction";
            this.Text = "ProcessTransaction";
            this.Load += new System.EventHandler(this.ProcessTransaction_Load);
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.grpTransaction.ResumeLayout(false);
            this.grpTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.GroupBox grpTransaction;
        private System.Windows.Forms.Label lblNoAdditionalAccounts;
        private System.Windows.Forms.LinkLabel lnkReturn;
        private System.Windows.Forms.LinkLabel lnkUpdate;
        private System.Windows.Forms.ComboBox cboPayeeAccount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPayeeAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bankAccountBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Label balanceLabel1;
        private System.Windows.Forms.Label fullNameLabel1;
        private EWSoftware.MaskedLabelControl.MaskedLabel accountNumberMaskedLabel;
        private EWSoftware.MaskedLabelControl.MaskedLabel clientNumberMaskedLabel;
        private System.Windows.Forms.ComboBox descriptionComboBox;
        private System.Windows.Forms.BindingSource transactionTypeBindingSource;
        private System.Windows.Forms.BindingSource payeeBindingSource;
    }
}