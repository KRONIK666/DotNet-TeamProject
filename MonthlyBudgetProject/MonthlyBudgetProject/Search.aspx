<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="MonthlyBudgetProject.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Expense History</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton Text="Home Page" runat="server" CssClass="button" PostBackUrl="~/Home Page.aspx" />
            <br />
            <br />
        </div>

        <div style="float: left;">
            <asp:Label Text="Last Week: " runat="server" Font-Bold="True" />
            <asp:Button Text="Search" runat="server" ID="searchWeek" />
            <br />
            <br />
            <asp:Label Text="Last Month: " runat="server" Font-Bold="True" />
            <asp:Button Text="Search" runat="server" ID="searchMonth" />
            <br />
            <br />
            <asp:Label Text="Last Year: " runat="server" Font-Bold="True" />
            <asp:Button Text="Search" runat="server" ID="searchYear" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>