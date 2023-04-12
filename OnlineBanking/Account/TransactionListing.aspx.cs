using BankOfBIT_JC.Data;
using BankOfBIT_JC.Models;
using System;
using System.Linq;

namespace OnlineBanking.Account
{
    public partial class TransactionListing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (this.Page.User.Identity.IsAuthenticated)
                    {
                        // Create new db context object
                        BankOfBIT_JCContext db = new BankOfBIT_JCContext();

                        // Define client using session variable
                        Client client = (Client)Session["client"];

                        // define selectedAccount from session variable
                        string selectedAccount = Session["selectedAccount"].ToString();

                        // parse selectedAccount as an int, assign value to local variable
                        int accountNumber = int.Parse(selectedAccount);

                        // define account from LINQ query
                        BankAccount account =
                            (from results
                             in db.BankAccounts
                             where results.AccountNumber == accountNumber
                             select results).SingleOrDefault();

                        // binding labels to data from LINQ queries/session vrbls
                        lblCustomerName.Text = client.FullName.ToString();
                        lblAcctNumber.Text = account.AccountNumber.ToString();
                        lblBalance.Text = account.Balance.ToString("C");

                        gvTransactions.DataSource = account.Transaction.ToList();

                        this.DataBind();
                    }

                    else
                    {
                        Response.Redirect("~/Account/Login.aspx");
                    }
                }
            }

            catch (Exception ex)
            {
                lblErrorMsg.Text = "An error occurred: " + ex.Message;
                lblErrorMsg.Visible = true;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lbtnPayBillTransfer_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/CreateTransaction.aspx");
        }

        protected void lbtnReturnToAccounts_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/AccountListing.aspx");
        }
    }
}