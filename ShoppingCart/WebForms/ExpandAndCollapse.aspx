<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExpandAndCollapse.aspx.cs" Inherits="ShoppingCart.WebForms.ExpandDropdown" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <script src="../Scripts/jquery-3.6.0.js"></script>
     <script type="text/javascript">
         function ShowHide(img, div) {

             var current = $('#' + div).css('display');
             if (current == 'none') {
                 $('#' + div).show('slow');
                 $(img).attr('src', '../Images/minus.png');
             }
             else {
                 $('#' + div).hide('slow');
                 $(img).attr('src', '../Images/plus.png');
             }
         }
     </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
                CellPadding="2" ForeColor="Black" GridLines="None" DataKeyNames="CategoryID" 
                OnRowDataBound="GridView1_RowDataBound" ClientIDRowSuffix="CategoryID">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />


                <Columns>
                    <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" ItemStyle-VerticalAlign="Top" >
<ItemStyle VerticalAlign="Top"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" ItemStyle-VerticalAlign="Top">
<ItemStyle VerticalAlign="Top"></ItemStyle>
                    </asp:BoundField>

                    <asp:TemplateField>
                        <ItemTemplate>

                             <img alt = "" 
                             onclick="ShowHide(this, 'GridView1_pnlSubCategories_<%# Eval("CategoryID") %>')" 
                        style="cursor: pointer" id="hi" src="../Images/plus.png" width ="30" />

                            <asp:Panel ID="pnlSubCategories" runat="server" Style="display: none">
                                 <asp:GridView ID="gvSubCategories" Width="100%" runat="server" 
                                     AutoGenerateColumns="false"
                                     OnRowDataBound="gvSubCategories_RowDataBound" ClientIDRowSuffix="SubCategoryID">

                                     <Columns>
                                        <asp:BoundField DataField="SubCategoryID" HeaderText="SubCategoryID" />
                                       
                                        <asp:BoundField DataField="SubCategoryName" HeaderText="SubCategoryName" />

                                           <asp:TemplateField HeaderText="SubCategoryID" Visible="false">
                                            <ItemTemplate>
                                                <asp:Label ID="lblSubCategoryID" runat="server" 
                                                    Text='<%#DataBinder.Eval(Container.DataItem, "SubCategoryID") %>'></asp:Label>
                                             </ItemTemplate>
                                        </asp:TemplateField>

                            <asp:TemplateField >
                                <ItemTemplate>

                                    <img alt = "" onclick="ShowHide(this, 'GridView1_gvSubCategories_<%# Eval("CategoryID") %>_pnlProducts_<%# Eval("SubCategoryID") %>')" 
                        style="cursor: pointer" id="hi" src="../Images/plus.png" width="30" />


                                        <asp:Panel ID="pnlProducts" runat="server" Style="display: none">
                                             <asp:GridView ID="gvProducts" Width="100%" runat="server" 
                                                 AutoGenerateColumns="false">
                                                 <Columns>
                
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" HtmlEncode="False" DataFormatString="{0:C2}" ItemStyle-HorizontalAlign="Right" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" ItemStyle-HorizontalAlign="Right" />
                <asp:BoundField DataField="BillAmount" HeaderText="Bill Amount" HtmlEncode="False" DataFormatString="{0:C2}" ItemStyle-HorizontalAlign="Right" />
                                  </Columns>
                                             </asp:GridView>
                                        </asp:Panel>
                                 </ItemTemplate>
                                          </asp:TemplateField>



                                     </Columns>
                                     </asp:GridView>
                                     </asp:Panel>

                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
