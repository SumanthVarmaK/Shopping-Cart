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
    public partial class SubCategories : System.Web.UI.Page
    {
        //PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        //Binding Sql Table Data
        private void BindData()
        {
            SubCategoriesBAL cat = new SubCategoriesBAL();


            DataSet dSet = cat.GetSubCategories();

            GridView1.DataSource = dSet;
            GridView1.DataBind();


            SqlConnection con = new SqlConnection("data source=192.168.0.37;initial catalog=TSEGRP_2021;uid=tsegrpusr;pwd=PWDtsegrp!1;");
            string com = "Select CategoryID,CategoryName  from Categories_ShoppingCart";
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




        }

        //Grid View Function
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            TextBox1.Text = row.Cells[1].Text;
            TextBox2.Text = row.Cells[2].Text;
        }
        //Delete Button Function For SubCategories Table
        protected void SubDelete_Click(object sender, EventArgs e)
        {
            SubCategories1 c = new SubCategories1();
            SubCategoriesBAL us = new SubCategoriesBAL();
            try
            {
                c.SubCategoryID = Convert.ToInt32(TextBox1.Text.ToString());

                int Counter = us.DeleteSubCategories(c);


                GridView1.EditIndex = -1;
                BindData();

                if (Counter.Equals(1))
                {

                    Label1.Text = "<h5>Deleted Successfully..";

                }
                else
                {
                    Label1.Text = "Deletion failed..";
                }
                TextBox1.Text = "";
                TextBox2.Text = "";
                DropDownList1.Text = "";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

        }
        //Update Button Function For SubCategories Table
        protected void SubUpdate_Click(object sender, EventArgs e)
        {
            SubCategories1 c = new SubCategories1();
            SubCategoriesBAL us = new SubCategoriesBAL();

            try
            {
                c.SubCategoryName = TextBox2.Text.ToString();
                c.SubCategoryID = Convert.ToInt32(TextBox1.Text.ToString());
                c.CategoryID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());

                int Counter = us.UpdateSubCategories(c);


                GridView1.EditIndex = -1;
                BindData();
                if (Counter.Equals(1))
                {

                    Label1.Text = "<h5>Updated Successfully..";

                }
                else
                {
                    Label1.Text = "Updation failed..";
                }
                TextBox1.Text = "";
                TextBox2.Text = "";
                DropDownList1.SelectedValue= "";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

        }
        //Insert Button Function For SubCategories Table
        protected void SubInsert_Click(object sender, EventArgs e)
        {
            SubCategories1 sc = new SubCategories1();
            SubCategoriesBAL subcat = new SubCategoriesBAL();
            try
            {
                sc.CategoryID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
                sc.SubCategoryName = TextBox2.Text.ToString();
                int Counter = subcat.InsertSubCategories(sc);
                BindData();
                if (Counter.Equals(1))
                {

                    Label1.Text = "<h5>Inserted Successfully..";

                }
                else
                {
                    Label1.Text = "Insertion failed..";
                }
                TextBox1.Text = "";
                TextBox2.Text = "";
                DropDownList1.SelectedValue = "";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
        //Cancel Button Function
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Emptying the Data in TextBoxes
            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList1.SelectedValue = "";

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}