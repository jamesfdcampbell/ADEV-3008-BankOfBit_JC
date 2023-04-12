using BankOfBIT_JC.Data;
using System;

namespace OnlineBanking.Account
{
    public partial class CreateTransaction : System.Web.UI.Page
    {
        BankOfBIT_JCContext db = new BankOfBIT_JCContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (this.Page.User.Identity.IsAuthenticated)
                    {

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

        protected void LinqTransactionType_Selecting(object sender, System.Web.UI.WebControls.LinqDataSourceSelectEventArgs e)
        {

        }

        protected void drpTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}