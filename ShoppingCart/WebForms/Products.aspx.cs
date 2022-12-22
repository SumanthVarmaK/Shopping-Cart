using ShoppingCart.Business_Access_Layer;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingCart.WebForms
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            ProductsBAL cat = new ProductsBAL();


            DataSet dSet = cat.GetProducts();

            GridView1.DataSource = dSet;
            GridView1.DataBind();

            SqlConnection con = new SqlConnection("data source=192.168.0.37;initial catalog=TSEGRP_2021;uid=tsegrpusr;pwd=PWDtsegrp!1;");
            string com = "Select CategoryID,CategoryName from Categories_ShoppingCart";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.Items.Clear();
            DropDownList1.Items.Insert(0, new ListItem("Please Select CategoryName", "0"));
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataValueField = "CategoryID";
            DropDownList1.DataBind();

            SqlConnection cn = new SqlConnection("data source=192.168.0.37;initial catalog=TSEGRP_2021;uid=tsegrpusr;pwd=PWDtsegrp!1;");
            string cos = "Select SubCategoryID, SubCategoryName from SubCategories_ShoppingCart";
            SqlDataAdapter adp = new SqlDataAdapter(cos, cn);
            DataTable dtt = new DataTable();
            adp.Fill(dtt);
            DropDownList2.DataSource = dtt;
            DropDownList2.DataBind();
            DropDownList2.Items.Clear();
            DropDownList2.Items.Insert(0, new ListItem("Please Select SubCategoryName", "0"));
            DropDownList2.DataTextField = "SubCategoryName";
            DropDownList2.DataValueField = "SubCategoryID";
            DropDownList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Products1 sc = new Products1();
            ProductsBAL subcat = new ProductsBAL();
            try
            {
                sc.CategoryID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
                sc.SubCategoryID = Convert.ToInt32(DropDownList2.SelectedValue.ToString());
                sc.ProductName = TextBox2.Text.ToString();
                sc.ProductDescription = TextBox6.Text.ToString();
                sc.Cost = Convert.ToInt32(TextBox4.Text.ToString());
                sc.ImagePath = TextBox7.Text.ToString();
                sc.StockLevel = Convert.ToInt32(TextBox5.Text.ToString());
                int Counter = subcat.InsertProducts(sc);
                BindData();
                if (Counter.Equals(1))
                {

                    Label11.Text = "<h5>Inserted Successfully..";

                }
                else
                {
                    Label11.Text = "Insertion failed..";
                }
                TextBox1.Text = "";
                DropDownList1.SelectedValue = "";
                DropDownList1.SelectedValue = "";
                TextBox2.Text = "";
                TextBox6.Text = "";
                TextBox4.Text = "";
                TextBox7.Text = "";
                TextBox5.Text = "";
            }
            catch (Exception ex)
            {
                Label11.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Products1 c = new Products1();
            ProductsBAL us = new ProductsBAL();

            try
            {
                c.CategoryID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
                c.SubCategoryID = Convert.ToInt32(DropDownList2.SelectedValue.ToString());
                c.ProductName = TextBox2.Text.ToString();
                c.ProductDescription = TextBox6.Text.ToString();
                c.Cost = Convert.ToDecimal(TextBox4.Text.ToString());
                c.ImagePath = TextBox7.Text.ToString();
                c.StockLevel = Convert.ToInt32(TextBox5.Text.ToString());
                c.ProductID = Convert.ToInt32(TextBox1.Text.ToString());

                int Counter = us.UpdateProducts(c);


                GridView1.EditIndex = -1;
                BindData();
                if (Counter.Equals(1))
                {

                    Label11.Text = "<h5>Updated Successfully..";

                }
                else
                {
                    Label11.Text = "Updation failed..";
                }
                TextBox1.Text = "";
                DropDownList1.SelectedValue = "";
                DropDownList1.SelectedValue = "";
                TextBox2.Text = "";
                TextBox6.Text = "";
                TextBox4.Text = "";
                TextBox7.Text = "";
                TextBox5.Text = "";

            }
            catch (Exception ex)
            {
                Label11.Text = ex.Message;
            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Products1 c = new Products1();
            ProductsBAL us = new ProductsBAL();

            try
            {
                c.ProductID = Convert.ToInt32(TextBox1.Text.ToString());

                int Counter = us.DeleteProducts(c);


                GridView1.EditIndex = -1;
                BindData();
                if (Counter.Equals(1))
                {

                    Label11.Text = "<h5>Deleted Successfully..";

                }
                else
                {
                    Label11.Text = "Deletion failed..";
                }
                TextBox1.Text = "";
                DropDownList1.SelectedValue = "";
                DropDownList1.SelectedValue = "";
                TextBox2.Text = "";
                TextBox6.Text = "";
                TextBox4.Text = "";
                TextBox7.Text = "";
                TextBox5.Text = "";


            }
            catch (Exception ex)
            {
                Label11.Text = ex.Message;
            }


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            TextBox1.Text = row.Cells[1].Text;
            DropDownList1.Text = row.Cells[2].Text;
            DropDownList2.Text = row.Cells[3].Text;
            TextBox2.Text = row.Cells[4].Text;
            TextBox6.Text = row.Cells[5].Text;
            TextBox4.Text = row.Cells[6].Text;
            TextBox5.Text = row.Cells[7].Text;
            TextBox7.Text = row.Cells[8].Text;
            
        }

       

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            DropDownList1.SelectedValue = "";
            DropDownList1.SelectedValue = "";
            TextBox2.Text = "";
            TextBox6.Text = "";
            TextBox4.Text = "";
            TextBox7.Text = "";
            TextBox5.Text = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=192.168.0.37;initial catalog=TSEGRP_2021;uid=tsegrpusr;pwd=PWDtsegrp!1;");
            string com = "Select CategoryID,CategoryName from Categories_ShoppingCart";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            //DropDownList1.Items.Clear();
            //DropDownList1.Items.Insert(0, new ListItem("Please Select CategoryName", "0"));
            //DropDownList1.DataTextField = "CategoryName";
            //DropDownList1.DataValueField = "CategoryID";
            //DropDownList1.DataBind();
            string CategoryName = DropDownList1.SelectedItem.Text;

            DataSet dSet = (DataSet)ViewState["vs_AllUsers"];

            //dataview is a subset / copy of dataset
            DataView dv = dSet.Tables[0].DefaultView;

            //if (CategoryName != "All Countries")
            //{
            //    dv.RowFilter = "CategoryName='" + CategoryName + "'";
            //    dv.Sort = "UserName asc";
            //}

        }
    }
}