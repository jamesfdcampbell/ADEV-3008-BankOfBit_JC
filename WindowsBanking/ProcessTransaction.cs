using BankOfBIT_JC.Data;
using BankOfBIT_JC.Models;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace WindowsBanking
{
    public partial class ProcessTransaction : Form
    {
        BankOfBIT_JCContext db = new BankOfBIT_JCContext();

        ConstructorData constructorData;

        /// Form can only be opened with a Constructor Data object
        /// containing client and account details.
        /// </summary>
        /// <param name="constructorData">Populated Constructor data object.</param>
        public ProcessTransaction(ConstructorData constructorData)
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
        private void ProcessTransaction_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            accountNumberMaskedLabel.Mask = Utility.BusinessRules.AccountFormat(constructorData.BankAccount.Description);

            IQueryable<TransactionType> transactionTypes = from results
                                                           in db.TransactionTypes
                                                           where results.Description != "Interest"
                                                           && results.Description != "Transfer (Recipient)"
                                                           select results;

            transactionTypeBindingSource.DataSource = transactionTypes.ToList();
        }

        private void grpClient_Enter(object sender, EventArgs e)
        {

        }

        private void descriptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (descriptionComboBox.Text == "Deposit" ||
                descriptionComboBox.Text == "Withdrawal")
            {
                cboPayeeAccount.Visible = false;
                lblPayeeAccount.Visible = false;
                lblNoAdditionalAccounts.Visible = false;
                lnkUpdate.Visible = true;
            }

            else if (descriptionComboBox.Text == "Bill Payment")
            {
                cboPayeeAccount.Visible = true;
                lblPayeeAccount.Visible = true;

                IQueryable<Payee> payees = from results
                                           in db.Payees
                                           select results;

                cboPayeeAccount.DataSource = payees.ToList();
                cboPayeeAccount.DisplayMember = "Description";
                cboPayeeAccount.ValueMember = "Description";
            }

            else if (descriptionComboBox.Text == "Transfer")
            {
                IQueryable<BankAccount> accounts = from results
                                                   in db.BankAccounts
                                                   where results.ClientId == constructorData.BankAccount.ClientId
                                                   && results.AccountNumber != constructorData.BankAccount.AccountNumber
                                                   select results;
                if (accounts.Count() > 0)
                {
                    lblNoAdditionalAccounts.Visible = false;
                    lnkUpdate.Visible = true;
                }

                else
                {
                    lblNoAdditionalAccounts.Visible = true;
                    lnkUpdate.Visible = false;
                }

                cboPayeeAccount.Visible = true;
                lblPayeeAccount.Visible = true;

                cboPayeeAccount.DataSource = accounts.ToList();
                cboPayeeAccount.DisplayMember = "AccountNumber";
                cboPayeeAccount.ValueMember = "AccountNumber";
            }
        }

        private void lnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Utility.Numeric.IsNumeric(txtAmount.Text, NumberStyles.Number))
            {
                string title = "Non-numeric value entered";
                string message = "Please enter a numeric value.";
                MessageBox.Show(message, title);
            }

            else
            {
                if (descriptionComboBox.Text == "Bill Payment" ||
                    descriptionComboBox.Text == "Transfer" ||
                    descriptionComboBox.Text == "Withdrawal")
                {
                    if (Double.Parse(txtAmount.Text) > constructorData.BankAccount.Balance)
                    {
                        string title = "Insufficient Funds";
                        string message = "Insufficient funds exist for requested transaction.";
                        MessageBox.Show(message, title);
                    }

                    else
                    {
                        if (descriptionComboBox.Text == "Bill Payment")
                        {
                            BankingService.TransactionManagerClient service = new BankingService.TransactionManagerClient();

                            string note = "Bill payment to " + cboPayeeAccount.Text;

                            double? newBalance = service.BillPayment(constructorData.BankAccount.BankAccountId, Double.Parse(txtAmount.Text), note);

                            if (newBalance != null)
                            {
                                balanceLabel1.Text = constructorData.BankAccount.Balance.ToString("C");
                            }

                            else
                            {
                                string title = "Transaction Error";
                                string message = "Error completing Transaction.";
                                MessageBox.Show(message, title);
                            }
                        }

                        else if (descriptionComboBox.Text == "Transfer")
                        {
                            BankingService.TransactionManagerClient service = new BankingService.TransactionManagerClient();

                            string note = "Transfer to account " + cboPayeeAccount.Text;

                            double? newBalance = service.Transfer(constructorData.BankAccount.BankAccountId, Int32.Parse(cboPayeeAccount.Text), Double.Parse(txtAmount.Text), note);

                            if (newBalance != null)
                            {
                                balanceLabel1.Text = constructorData.BankAccount.Balance.ToString("C");
                            }

                            else
                            {
                                string title = "Transaction Error";
                                string message = "Error completing Transaction.";
                                MessageBox.Show(message, title);
                            }
                        }

                        else if (descriptionComboBox.Text == "Withdrawal")
                        {
                            BankingService.TransactionManagerClient service = new BankingService.TransactionManagerClient();

                            string note = "Withdrawal";

                            double? newBalance = service.Withdrawal(constructorData.BankAccount.BankAccountId, Double.Parse(txtAmount.Text), note);

                            if (newBalance != null)
                            {
                                balanceLabel1.Text = newBalance.Value.ToString("C");
                            }

                            else
                            {
                                string title = "Transaction Error";
                                string message = "Error completing Transaction.";
                                MessageBox.Show(message, title);
                            }
                        }
                    }
                }
                else if (descriptionComboBox.Text == "Deposit")
                {
                    BankingService.TransactionManagerClient service = new BankingService.TransactionManagerClient();

                    string note = "Deposit";

                    double? newBalance = service.Deposit(constructorData.BankAccount.BankAccountId, Double.Parse(txtAmount.Text), note);

                    if (newBalance != null)
                    {
                        balanceLabel1.Text = newBalance.Value.ToString("C");
                    }

                    else
                    {
                        string title = "Transaction Error";
                        string message = "Error completing Transaction.";
                        MessageBox.Show(message, title);
                    }
                }
            }
        }
    }
}