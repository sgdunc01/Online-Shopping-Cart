<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingPlazaForm.aspx.cs" Inherits="Final_Project.WebForms.ShoppingPlazaForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Shopping Page</title>
    <link rel="stylesheet" href="ShoppingPlazaStyle.css" type="text/css" />

    </style>
    <style type="text/css">
        .auto-style1 {
            margin-right: 270px;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
    <a href="ShoppingPlazaForm.aspx">ShoppingPlazaForm.aspx</a>
</head>
<body class="font">
    <form id="form1" runat="server">
        <div><h2>Here you make your selections. You can select one book title and one DVD title.</h2></div>
        <table>
            <tr>
                <td >Books</td>
                <td class="auto-style1" >
                    <asp:DropDownList ID="BooksDropDown" width="100%" runat="server" AutoPostBack="True" OnSelectedIndexChanged="BooksDropDown_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td >Quantity</td>
                <td>
                    <asp:TextBox ID="BookQuantityTB" runat="server" ></asp:TextBox>
                </td>
                <td>Price of Book:</td>
                <td>
                    <asp:Label ID="BookPriceValueLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td >DVDs</td>
                <td class="auto-style1" >
                    <asp:DropDownList ID="DvdDropDown" width="100%" runat="server"  AutoPostBack="True" OnSelectedIndexChanged="DvdDropDown_SelectedIndexChanged" CssClass="auto-style1">
                    </asp:DropDownList>
                </td>
                <td >Quantity</td>
                <td >
                    <asp:TextBox ID="DvdQuantityTB" runat="server"></asp:TextBox>
                </td>
                <td >Price of DVD:</td>
                <td>
                    <asp:Label ID="DVDPriceValueLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td ></td>
                <td class="auto-style1" >
                    &nbsp;</td>
                <td ></td>
                <td ></td>
                <td ></td>
                <td></td>
            </tr>
            <tr>
                <td ></td>
                <td colspan="4" >
                    <asp:Label ID="MessageLabel" class="validator" runat="server" ></asp:Label>
                </td>
                <td></td>
            </tr>
            <tr>
                <td ></td>
                <td class="auto-style2">
                    <asp:Button ID="AddBtn" runat="server" Text="Add" Width="107px" OnClick="AddBtn_Click" />
                </td>
                <td >
                    <asp:Button ID="CheckoutBtn" runat="server" Text="Checkout"   OnClick="CheckoutBtn_Click"/>
                </td>
                <td ></td>
                <td >
                    <asp:Button ID="ExitBtn" runat="server" Text="Exit" Width="124px"  OnClick="ExitBtn_Click"/>
                </td>
                <td></td>
            </tr>
            </table>
    </form>
</body>
</html>

