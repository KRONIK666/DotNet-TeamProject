<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home Page.aspx.cs" Inherits="MonthlyBudgetProject.Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <style>
        .button {
            margin-left: 10px;
        }

        #dateTxtBox, #chooseExpense, #priceTxtBox {
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
            <asp:Label Text="Date: " runat="server" />
            <asp:TextBox TextMode="Date" runat="server" ID="dateTxtBox" />
            <br />
            <br />
            <asp:Label Text="Expense: " runat="server" />
            <asp:DropDownList ID="chooseExpense" runat="server" OnSelectedIndexChanged="chooseExpense_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Please choose an expense.." />
                <asp:ListItem Text="Bills" Value="Bills" />
                <asp:ListItem Text="Food" Value="Food" />
                <asp:ListItem Text="Fuel" Value="Fuel" />
                <asp:ListItem Text="Rent" Value="Rent" />
                <asp:ListItem Text="Clothes" Value="Clothes" />
                <asp:ListItem Text="Health" Value="Health" />
                <asp:ListItem Text="Household" Value="Household" />
                <asp:ListItem Text="Transport" Value="Transport" />
                <asp:ListItem Text="Entertainment" Value="Entertainment" />
                <asp:ListItem Text="Vacation" Value="Vacation" />
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label Text="Price: " runat="server" />
            <asp:TextBox TextMode="Number" runat="server" ID="priceTxtBox" />
            <br />
            <br />
            <asp:Button Text="Submit" CssClass="my-button" runat="server" Enabled="false" ID="submitBtn" OnClick="submitBtn_Click" />
        </div>
    </form>
</body>
</html>