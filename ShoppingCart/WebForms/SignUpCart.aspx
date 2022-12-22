<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpCart.aspx.cs" Inherits="ShoppingCart.WebForms.SignUpCart" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #000000;
            background-color: #808080;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" BorderColor="Black" BorderStyle="Solid" PostBackUrl="~/WebForms/UsersForUsers.aspx">SignUp</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton2" runat="server" BorderColor="Black" BorderStyle="Solid" PostBackUrl="~/WebForms/CheckCredentials.aspx">LogIn</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Electronics images.jfif" />
                    </td>
                    <td>
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/groceries image.jfif" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/Stationary image.jfif" />
                    </td>
                    <td>
                        <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/Kitchen appliances image.jfif" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
