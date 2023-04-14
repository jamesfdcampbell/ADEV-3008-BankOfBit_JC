namespace WindowsBanking
{
    partial class History
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
            System.Windows.Forms.Label clientNumberLabel;
            System.Windows.Forms.Label accountNumberLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.balanceLabel1 = new System.Windows.Forms.Label();
            this.bankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameLabel1 = new System.Windows.Forms.Label();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountNumberMaskedLabel = new EWSoftware.MaskedLabelControl.MaskedLabel();
            this.clientNumberMaskedLabel = new EWSoftware.MaskedLabelControl.MaskedLabel();
            this.lnkReturn = new System.Windows.Forms.LinkLabel();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clientNumberLabel = new System.Windows.Forms.Label();
            accountNumberLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            this.grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientNumberLabel
            // 
            clientNumberLabel.AutoSize = true;
            clientNumberLabel.Location = new System.Drawing.Point(100, 36);
            clientNumberLabel.Name = "clientNumberLabel";
            clientNumberLabel.Size = new System.Drawing.Size(76, 13);
            clientNumberLabel.TabIndex = 0;
            clientNumberLabel.Text = "Client Number:";
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new System.Drawing.Point(100, 67);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new System.Drawing.Size(90, 13);
            accountNumberLabel.TabIndex = 2;
            accountNumberLabel.Text = "Account Number:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(377, 36);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "Full Name:";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new System.Drawing.Point(385, 67);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(49, 13);
            balanceLabel.TabIndex = 6;
            balanceLabel.Text = "Balance:";
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(balanceLabel);
            this.grpAccount.Controls.Add(this.balanceLabel1);
            this.grpAccount.Controls.Add(fullNameLabel);
            this.grpAccount.Controls.Add(this.fullNameLabel1);
            this.grpAccount.Controls.Add(accountNumberLabel);
            this.grpAccount.Controls.Add(this.accountNumberMaskedLabel);
            this.grpAccount.Controls.Add(clientNumberLabel);
            this.grpAccount.Controls.Add(this.clientNumberMaskedLabel);
            this.grpAccount.Location = new System.Drawing.Point(43, 37);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(708, 123);
            this.grpAccount.TabIndex = 0;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Account Data";
            this.grpAccount.Enter += new System.EventHandler(this.grpAccount_Enter);
            // 
            // balanceLabel1
            // 
            this.balanceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "Balance", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.balanceLabel1.Location = new System.Drawing.Point(440, 67);
            this.balanceLabel1.Name = "balanceLabel1";
            this.balanceLabel1.Size = new System.Drawing.Size(152, 23);
            this.balanceLabel1.TabIndex = 7;
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
            this.fullNameLabel1.Location = new System.Drawing.Point(440, 36);
            this.fullNameLabel1.Name = "fullNameLabel1";
            this.fullNameLabel1.Size = new System.Drawing.Size(152, 23);
            this.fullNameLabel1.TabIndex = 5;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BankOfBIT_JC.Models.Client);
            // 
            // accountNumberMaskedLabel
            // 
            this.accountNumberMaskedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountNumberMaskedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "AccountNumber", true));
            this.accountNumberMaskedLabel.Location = new System.Drawing.Point(196, 67);
            this.accountNumberMaskedLabel.Name = "accountNumberMaskedLabel";
            this.accountNumberMaskedLabel.Size = new System.Drawing.Size(100, 23);
            this.accountNumberMaskedLabel.TabIndex = 3;
            // 
            // clientNumberMaskedLabel
            // 
            this.clientNumberMaskedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientNumberMaskedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNumber", true));
            this.clientNumberMaskedLabel.Location = new System.Drawing.Point(196, 36);
            this.clientNumberMaskedLabel.Mask = "0000-0000";
            this.clientNumberMaskedLabel.Name = "clientNumberMaskedLabel";
            this.clientNumberMaskedLabel.Size = new System.Drawing.Size(100, 23);
            this.clientNumberMaskedLabel.TabIndex = 1;
            this.clientNumberMaskedLabel.Text = "    -";
            // 
            // lnkReturn
            // 
            this.lnkReturn.AutoSize = true;
            this.lnkReturn.Location = new System.Drawing.Point(385, 435);
            this.lnkReturn.Name = "lnkReturn";
            this.lnkReturn.Size = new System.Drawing.Size(80, 13);
            this.lnkReturn.TabIndex = 1;
            this.lnkReturn.TabStop = true;
            this.lnkReturn.Text = "Return to Client";
            this.lnkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReturn_LinkClicked);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(BankOfBIT_JC.Models.Transaction);
            // 
            // transactionDataGridView
            // 
            this.transactionDataGridView.AllowUserToAddRows = false;
            this.transactionDataGridView.AllowUserToDeleteRows = false;
            this.transactionDataGridView.AllowUserToResizeColumns = false;
            this.transactionDataGridView.AllowUserToResizeRows = false;
            this.transactionDataGridView.AutoGenerateColumns = false;
            this.transactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.transactionDataGridView.DataSource = this.transactionBindingSource;
            this.transactionDataGridView.Location = new System.Drawing.Point(43, 186);
            this.transactionDataGridView.Name = "transactionDataGridView";
            this.transactionDataGridView.Size = new System.Drawing.Size(708, 220);
            this.transactionDataGridView.TabIndex = 2;
            this.transactionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactionDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DateCreated";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn7.HeaderText = "Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TransactionType";
            this.dataGridViewTextBoxColumn11.HeaderText = "Type";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Deposit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.HeaderText = "Amount In";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Withdrawal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn6.HeaderText = "Amount Out";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn8.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 225;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.transactionDataGridView);
            this.Controls.Add(this.lnkReturn);
            this.Controls.Add(this.grpAccount);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.LinkLabel lnkReturn;
        private System.Windows.Forms.Label balanceLabel1;
        private System.Windows.Forms.BindingSource bankAccountBindingSource;
        private System.Windows.Forms.Label fullNameLabel1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private EWSoftware.MaskedLabelControl.MaskedLabel accountNumberMaskedLabel;
        private EWSoftware.MaskedLabelControl.MaskedLabel clientNumberMaskedLabel;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.DataGridView transactionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}