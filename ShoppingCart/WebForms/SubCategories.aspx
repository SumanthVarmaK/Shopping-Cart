<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubCategories.aspx.cs" Inherits="ShoppingCart.WebForms.SubCategories" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #000000;
            background-color: #00FFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="4">
                        <asp:Label ID="SubCategoryID" runat="server" Text="SubCategory ID"></asp:Label>
                    </td>
                    <td colspan="4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="SubCategoryName" runat="server" Text="SubCategory Name"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td colspan="2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="SubCategoryName is Must!" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="CategoryID1" runat="server" Text="Category Name"></asp:Label>
                    </td>
                    <td colspan="4">
                        <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <Items>
                                <asp:ListItem Text="Select" Value=""/>
                            </Items>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="SubInsert" runat="server" Text="Insert" OnClick="SubInsert_Click" />
                    </td>
                    <td colspan="2">
                        <asp:Button ID="SubUpdate" runat="server" Text="Update" OnClick="SubUpdate_Click" />
                    </td>
                    <td>
                        <asp:Button ID="SubDelete" runat="server" Text="Delete" OnClick="SubDelete_Click" />
                    </td>
                    <td rowspan="2">
                        &nbsp;</td>
                    <td rowspan="2" colspan="2">
                        &nbsp;</td>
                    <td rowspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" Text="Message"></asp:Label>
                    </td>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cancel" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
