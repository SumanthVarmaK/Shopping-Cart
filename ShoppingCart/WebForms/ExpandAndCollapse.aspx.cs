using ShoppingCart.Business_Access_Layer;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingCart.WebForms
{
    public partial class ExpandDropdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }
        private void BindData()
        {
            
            CategoriesBAL cat = new CategoriesBAL();
            DataSet dSdet = cat.GetCategories();
            GridView1.DataSource = dSdet;
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            SubCategories1 clssubcat = new SubCategories1(); // Ob
            ExpandAndCollapseBAL expbal = new ExpandAndCollapseBAL();
            DataSet dSet = new DataSet();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                clssubcat.SubCategoryID =Convert.ToInt32 (GridView1.DataKeys[e.Row.RowIndex].Value.ToString());
                GridView gvSubCategories = e.Row.FindControl("gvSubCategories") as GridView;
                dSet = expbal.GetSubCategories1();
                gvSubCategories.DataSource = dSet;
                gvSubCategories.DataBind();

            }
        }

        protected void gvSubCategories_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            SubCategories1 ord = new SubCategories1();

            ExpandAndCollapseBAL sum = new ExpandAndCollapseBAL();
             ord.SubCategoryID = 0;
            DataSet dSet = new DataSet();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblSubCategoryID = (Label)e.Row.FindControl("lblSubCategoryID");

                ord.SubCategoryID = Convert.ToInt32(lblSubCategoryID.Text);
                
                GridView gvProducts = e.Row.FindControl("gvProducts") as GridView;
                dSet = sum.GetProducts1();          //error prone area//////////////////////////////////////
                gvProducts.DataSource = dSet;
                gvProducts.DataBind();
            }
        }



        private void AddTotalRow(string cellText, string CellValue)
        {
            GridViewRow row = new GridViewRow(0, 0, DataControlRowType.DataRow, DataControlRowState.Normal);
            row.BackColor = ColorTranslator.FromHtml("#F9F9F9");

            row.Cells.AddRange(new TableCell[4] {new TableCell (),new TableCell (),
                                        new TableCell { Text = cellText, HorizontalAlign = HorizontalAlign.Right},
                                        new TableCell { Text = CellValue, HorizontalAlign = HorizontalAlign.Right } });

            GridView1.Controls[0].Controls.Add(row);
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            //decimal GrandTotal = Convert.ToDecimal(ViewState["GrandTotal"].ToString());
            //this.AddTotalRow("Grand Total", GrandTotal.ToString("C2"));
        }
    }
}