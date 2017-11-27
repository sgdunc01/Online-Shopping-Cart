<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Final_Project.WebForms.Checkout" %>

<!<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Checkout Page</title>
    <link rel="stylesheet" href="CheckoutStyle.css" type="text/css" />

    <style type="text/css">
        .auto-style1 {
            width: 524px;
        }
        .auto-style2 {
            width: 524px;
            text-align: center;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
      <div>
          <asp:ListBox ID="ProductLstBx" runat="server"  OnSelectedIndexChanged="ProductLstBx_SelectedIndexChanged" AutoPostBack="True" Width="100%"></asp:ListBox>
          <table >
              <tr>
                  <td >Change Quantity:<asp:TextBox ID="QuantityTxt" runat="server" Class="entry"></asp:TextBox>
                  </td>
                  <td class="auto-style2" >
                      <asp:Button ID="QtyEditBtn" runat="server" Text="Accept Change"  OnClick="QtyEditBtn_Click" Width="153px" />
                  </td>
              </tr>
              <tr>
                  <td >&nbsp;</td>
                  <td class="auto-style1" >&nbsp;</td>
              </tr>
              <tr>
                  <td >
                      <asp:Button ID="PayBtn" runat="server" Text="Pay" Width="114px" class="mybutton" OnClick="PayButton_Click"/>
                  </td>
                  <td class="auto-style1" >
                      <asp:Button ID="ExitBtn" runat="server" Text="Exit" Width="114px" class="mybutton" OnClick="ExitButton_Click"/>
                  </td>
              </tr>
              <tr>
                  <td colspan="2">
                      <asp:Label ID="TotalLbl" runat="server" class="label"></asp:Label>
                  </td>
              </tr>
              </table>
        </div>
    </form>
</body>
</html>
