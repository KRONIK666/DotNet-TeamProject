<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="MonthlyBudgetProject.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Expenses Statistics</title>
    <style>
        .button {
            margin-left: 10px;
        }

        #searchWeek,#searchMonth,#searchYear {
            float: right;
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <asp:LinkButton Text="Home Page" runat="server" CssClass="button" PostBackUrl="~/Home Page.aspx" />
            <asp:LinkButton Text="Expenses Statistics" runat="server" CssClass="button" PostBackUrl="~/Search.aspx" />
            <br />
            <br />
        </div>
        <div style="float: left; margin-left: 10px;">
            <asp:Label Text="Last Week: " runat="server" Font-Bold="True" />
            <asp:Button Text="Search" runat="server" ID="searchWeek" OnClick="searchWeek_Click" />
            <br />
            <br />
            <asp:Label Text="Last Month: " runat="server" Font-Bold="True" />
            <asp:Button Text="Search" runat="server" ID="searchMonth" OnClick="searchMonth_Click" />
            <br />
            <br />
            <asp:Label Text="Last Year: " runat="server" Font-Bold="True" />
            <asp:Button Text="Search" runat="server" ID="searchYear" OnClick="searchYear_Click" />
            <br />
            <br />
        </div>
        <div style="float: left; padding-left: 50px;">
            <asp:Repeater runat="server" ID="infoRepeater">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("Week") %>' runat="server" />
                    <br />
                    <asp:Label Text='<%# Eval("Month") %>' runat="server" />
                    <br />
                    <asp:Label Text='<%# Eval("Year") %>' runat="server" />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>