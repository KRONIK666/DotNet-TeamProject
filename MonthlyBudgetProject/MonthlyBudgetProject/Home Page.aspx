<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home Page.aspx.cs" Inherits="MonthlyBudgetProject.Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <style>
        .button {
            margin-left: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton Text="Expence History" runat="server" CssClass="button" PostBackUrl="~/Search.aspx" />
            <br />
            <br />
            <asp:Label Text="Date" runat="server" ID="Date" />
            <asp:Calendar runat="server" ID="calendar" OnSelectionChanged="calendar_SelectionChanged" />
            <br />
            <br />
            <asp:Label Text="Expense: " runat="server" ID="Expense" />
            <asp:DropDownList ID="chooseExpense" runat="server" OnSelectedIndexChanged="chooseExpense_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Please choose an expense.." Value="test" />
                <asp:ListItem Text="Food" Value="Mercedes" />
                <asp:ListItem Text="Clothes" Value="Clothes" />
                <asp:ListItem Text="Household" Value="Household" />
                <asp:ListItem Text="Transport" Value="Transport" />
                <asp:ListItem Text="Entertainment" Value="Entertainment" />
                <asp:ListItem Text="Vacation" Value="Vacation" />
                <asp:ListItem Text="Health" Value="Health" />
                <asp:ListItem Text="Electronics" Value="Electronics" />
                <asp:ListItem Text="Car" Value="Car" />
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label Text="Price" runat="server" ID="Price" />
            <asp:TextBox runat="server" ID="priceTxtBox" TextMode="Number" />
            <asp:Label Text="лева" runat="server" ID="Label1" />
            <br />
            <br />
            <asp:Button Text="Submit" CssClass="my-button" runat="server" Enabled="false" ID="submitBtn" OnClick="submitBtn_Click"/>
        </div>
    </form>
</body>
</html>
