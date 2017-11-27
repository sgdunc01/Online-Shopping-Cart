<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="Final_Project.WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to the Shopping Plaza</title>
    <link rel="stylesheet" href ="WebForms/site.css" type="text/css" />
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <table>
                <tr>
                    <td ></td>
                </tr>
                <tr>
                    <td ><h1> Welcome to the Shopping Plaza!!!!</h1></td>
                </tr>
                <tr>
                    <td ></td>
                </tr>
                <tr>
                    <td  > Here you can purchase books and DVDs. Simply follow the instructions provided below</td>
                </tr>
                <tr>
                    <td  ></td>
                </tr>
                <tr>
                    <td > Instructions:<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td > 1. Select the book and enter the quantity. Click Add.<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td > 2. Select the DVD and enter the quantity. Click Add.<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td > 3. To check out, click Check-out.<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td  > 4. To close the application, click Exit. You will lose your selections.<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td > 5. In the check out screen revise the quantities if you wish to. If you do, click Edit.<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td > 6. To place final order, click Pay.<br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td > 7. To close the application, click Exit. You will lose your selections. 
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td ></td>
                </tr>
                <tr>
                    <td >
                        <asp:Button ID="PlazaBtn" runat="server" Text="Go To Shopping Plaza" Width="232px" class="mybutton" OnClick="PlazaBtn_Click"/>
                        <asp:Button ID="ExitBtn" runat="server" Text="Exit" Width="114px" class="mybutton" OnClick="ExitBtn_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>