using BankOfBIT_JC.Data;
using BankOfBIT_JC.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsBanking
{
    public partial class ClientData : Form
    {
        BankOfBIT_JCContext db = new BankOfBIT_JCContext();

        ConstructorData constructorData = new ConstructorData();

        /// <summary>
        /// This constructor will execute when the form is opened
        /// from the MDI Frame.
        /// </summary>
        public ClientData()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This constructor will execute when the form is opened by
        /// returning from the History or Transaction forms.
        /// </summary>
        /// <param name="constructorData">Populated ConstructorData object.</param>
        public ClientData(ConstructorData constructorData)
        {
            //Given:
            InitializeComponent();
            this.constructorData = constructorData;

            //More code to be added:
            clientNumberMaskedTextBox.Text = constructorData.Client.ClientNumber.ToString();
            clientNumberMaskedTextBox_Leave(null, null);
        }

        /// <summary>
        /// Populates the ConstructorData object with the 
        /// current Client and BankAccount records.
        /// </summary>
        private void PopulateConstructorData()
        {
            this.constructorData.Client = (Client)clientBindingSource.Current;
            this.constructorData.BankAccount = (BankAccount)bankAccountBindingSource.Current;
        }

        /// <summary>
        /// Open the Transaction form passing ConstructorData object.
        /// </summary>
        private void lnkProcess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Given, more code to be added.
            PopulateConstructorData();
            ProcessTransaction transaction = new ProcessTransaction(constructorData);
            transaction.MdiParent = this.MdiParent;
            transaction.Show();
            this.Close();
        }

        /// <summary>
        /// Open the History form passing ConstructorData object.
        /// </summary>
        private void lnkDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Given, more code to be added.
            PopulateConstructorData();
            History history = new History(constructorData);
            history.MdiParent = this.MdiParent;
            history.Show();
            this.Close();
        }

        /// <summary>
        /// Always display the form in the top right corner of the frame.
        /// </summary>
        private void ClientData_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void clientNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void fullAddressLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void fullNameLabel1_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void notesLabel_Click(object sender, EventArgs e)
        {

        }

        private void accountNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateCreatedLabel_Click(object sender, EventArgs e)
        {

        }

        private void clientNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel2_Click(object sender, EventArgs e)
        {

        }

        private void balanceMaskedLabel_Click(object sender, EventArgs e)
        {

        }

        private void grpClient_Enter(object sender, EventArgs e)
        {

        }

        private void clientNumberMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (clientNumberMaskedTextBox.MaskCompleted)
            {
                double clientNumber = Convert.ToDouble(clientNumberMaskedTextBox.Text);

                Client client = (from results
                                 in db.Clients
                                 where results.ClientNumber == clientNumber
                                 select results).SingleOrDefault();

                if (client != null)
                {
                    clientBindingSource.DataSource = client;

                    IQueryable<BankAccount> bankAccounts = from results
                                                           in db.BankAccounts
                                                           where results.ClientId == client.ClientId
                                                           select results;

                    if (bankAccounts.Count() == 0)
                    {
                        lnkProcess.Enabled = false;
                        lnkDetails.Enabled = false;
                        bankAccountBindingSource.DataSource = typeof(BankAccount);
                    }

                    else
                    {
                        bankAccountBindingSource.DataSource = bankAccounts.ToList();

                        if (constructorData.BankAccount != null)
                        {
                            accountNumberComboBox.Text = constructorData.BankAccount.AccountNumber.ToString();
                        }

                        lnkProcess.Enabled = true;
                        lnkDetails.Enabled = true;
                    }
                }

                else
                {
                    string message = ("Client Number: " + clientNumber + " does not exist.");
                    string title = "Invalid Client Number";
                    MessageBox.Show(message, title);

                    lnkProcess.Enabled = false;
                    lnkDetails.Enabled = false;
                    clientNumberMaskedTextBox.Focus();

                    clientBindingSource.DataSource = typeof(Client);
                    bankAccountBindingSource.DataSource = typeof(BankAccount);
                }
            }

            else
            {
                string message = ("Please enter a client number.");
                string title = "No Client Number Entered";
                MessageBox.Show(message, title);
            }

        }

        private void clientNumberMaskedTextBox_ModifiedChanged(object sender, EventArgs e)
        {

        }
    }
}
