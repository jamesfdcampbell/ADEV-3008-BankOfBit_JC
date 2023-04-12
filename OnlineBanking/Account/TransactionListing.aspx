<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TransactionListing.aspx.cs" Inherits="OnlineBanking.Account.TransactionListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="lblCustomerName" runat="server" Font-Bold="True" Text="[Client Name]"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblAcctNumLabel" runat="server" Text="Account Number: "></asp:Label>
        <asp:Label ID="lblAcctNumber" runat="server" Text="[AcctNum]" Width="100px" TextAlign="Right"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="lblBalanceLabel" runat="server" Text="Balance: "></asp:Label>
        <asp:Label ID="lblBalance" runat="server" Text="[Balance]" Width="100px" TextAlign="Right"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="gvTransactions" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="DateCreated" HeaderText="Date" DataFormatString="{0:d}">
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="TransactionType.Description" HeaderText="Transaction Type">
                <ItemStyle Width="125px" />
                </asp:BoundField>
                <asp:BoundField DataField="Deposit" DataFormatString="{0:c}" HeaderText="Amount In">
                <ItemStyle HorizontalAlign="Right" Width="125px" />
                </asp:BoundField>
                <asp:BoundField DataField="Withdrawal" DataFormatString="{0:c}" HeaderText="Amount Out">
                <ItemStyle HorizontalAlign="Right" Width="125px" />
                </asp:BoundField>
                <asp:BoundField DataField="Notes" HeaderText="Details">
                <ItemStyle Width="300px" />
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </p>
    <p>
        <asp:LinkButton ID="lbtnPayBillTransfer" runat="server" OnClick="lbtnPayBillTransfer_Click">Pay Bills and Transfer Funds</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="lbtnReturnToAccounts" runat="server" OnClick="lbtnReturnToAccounts_Click">Return to Account Listing</asp:LinkButton>
    </p>
    <p>
        <asp:Label ID="lblErrorMsg" runat="server" Text="[Error Message]" Visible="False"></asp:Label>
    </p>
    <p>
    </p>
</asp:Content>
