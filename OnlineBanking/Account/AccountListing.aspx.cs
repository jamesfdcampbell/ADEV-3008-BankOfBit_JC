using BankOfBIT_JC.Data;
using BankOfBIT_JC.Models;
using System;
using System.Linq;

namespace OnlineBanking
{
    public partial class AccountListing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // create new db context object
            BankOfBIT_JCContext db = new BankOfBIT_JCContext();

            try
            {
                if (!IsPostBack)
                {
                    if (this.Page.User.Identity.IsAuthenticated)
                    {
                        string clientUserName = this.Page.User.Identity.Name;
                        long clientNumber = (long)Convert.ToDouble(clientUserName.Substring(0, clientUserName.IndexOf("@")));

                        Client client =
                            (from foundClient
                             in db.Clients
                             where foundClient.ClientNumber == clientNumber
                             select foundClient).SingleOrDefault();

                        IQueryable<BankAccount> accounts =
                            from results in db.BankAccounts
                            where results.ClientId == client.ClientId
                            select results;

                        Session["accounts"] = accounts;
                        Session["client"] = client;

                        gvAccounts.DataSource = accounts.ToList();

                        this.DataBind();

                        lblCustomerName.Text = client.FullName;
                    }

                    else
                    {
                        Response.Redirect("~/Account/Login.aspx");
                    }
                }
            }

            catch (Exception ex)
            {
                // if exception occurs, make lblErrorMsg visible
                // and populate with the exception message
                lblErrorMsg.Text = "An error occurred: " + ex.Message;
                lblErrorMsg.Visible = true;
            }
        }

        protected void gvAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["selectedAccount"] = gvAccounts.Rows[gvAccounts.SelectedIndex].Cells[1].Text;

            Response.Redirect("~/Account/TransactionListing.aspx");
        }
    }
};