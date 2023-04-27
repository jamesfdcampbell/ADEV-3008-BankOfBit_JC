using BankOfBIT_JC.Data;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsBanking
{
    public partial class History : Form
    {
        BankOfBIT_JCContext db = new BankOfBIT_JCContext();

        ConstructorData constructorData;

        /// <summary>
        /// Form can only be opened with a Constructor Data object
        /// containing client and account details.
        /// </summary>
        /// <param name="constructorData">Populated Constructor data object.</param>
        public History(ConstructorData constructorData)
        {
            //Given, more code to be added.
            InitializeComponent();
            this.constructorData = constructorData;

            clientBindingSource.DataSource = constructorData.Client;
            bankAccountBindingSource.DataSource = constructorData.BankAccount;
        }


        /// <summary>
        /// Return to the Client Data form passing specific client and 
        /// account information within ConstructorData.
        /// </summary>
        private void lnkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientData client = new ClientData(constructorData);
            client.MdiParent = this.MdiParent;
            client.Show();
            this.Close();
        }
        /// <summary>
        /// Always display the form in the top right corner of the frame.
        /// </summary>
        private void History_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

            accountNumberMaskedLabel.Mask = Utility.BusinessRules.AccountFormat(constructorData.BankAccount.Description);

            var innerJoinQuery =
                from Transactions in db.Transactions
                join TransactionTypes in db.TransactionTypes
                on Transactions.TransactionTypeId
                equals TransactionTypes.TransactionTypeId
                where constructorData.BankAccount.BankAccountId == Transactions.BankAccountId
                orderby Transactions.DateCreated descending
                select new { DateCreated = Transactions.DateCreated, TransactionType = TransactionTypes.Description, Deposit = Transactions.Deposit, Withdrawal = Transactions.Withdrawal, Notes = Transactions.Notes };

            transactionDataGridView.DataSource = innerJoinQuery.ToList();
        }

        private void transactionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpAccount_Enter(object sender, EventArgs e)
        {

        }
    }
}