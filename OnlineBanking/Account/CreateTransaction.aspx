<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateTransaction.aspx.cs" Inherits="OnlineBanking.Account.CreateTransaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        Account Number:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblAcctNum" runat="server" TextAlign="Right" Text="Label"></asp:Label>
    </p>
    <p>
        Balance:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblBalance" runat="server" TextAlign="Right" Text="Label"></asp:Label>
    </p>
    <p>
        Transaction Type:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="drpTransactionType" runat="server" DataSourceID="LinqTransactionType" DataTextField="Description" DataValueField="Description" OnSelectedIndexChanged="drpTransactionType_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    <p>
        Amount:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" Enabled="False" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" Display="Dynamic" ErrorMessage="RangeValidator" MaximumValue="10,000.00" MinimumValue="0.01"></asp:RangeValidator>
    </p>
    <p>
        To:&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="drpRecipient" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:LinkButton ID="lbtnCompleteTransaction" runat="server">Complete Transaction</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="lbtnReturnToAccounts" runat="server" CausesValidation="False">Return to Account Listing</asp:LinkButton>
    </p>
    <p>
        <asp:Label ID="lblErrorMsg" runat="server" Text="[Error Message]" Visible="False"></asp:Label>
    </p>
    <p>
    </p>
</asp:Content>
