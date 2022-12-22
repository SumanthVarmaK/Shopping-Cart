using ShoppingCart.Business_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoppingCart.Models;

namespace ShoppingCart.WebForms
{
    public partial class Categories : System.Web.UI.Page
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
            CategoriesBAL cat = new CategoriesBAL();


            DataSet dSet = cat.GetCategories();

            GridView1.DataSource = dSet;
            GridView1.DataBind();


        }



        //Insert Button Function For Categories Table
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Categories1 c = new Categories1();
            CategoriesBAL us = new CategoriesBAL();



            try
            {

                c.CategoryName = TextBox2.Text.ToString();
                int Counter = us.InsertCategories(c);
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
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

        }

        //Delete Button Function For Categories Table
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Categories1 c = new Categories1();
            CategoriesBAL us = new CategoriesBAL();



            try
            {
                c.CategoryID = Convert.ToInt32(TextBox1.Text.ToString());

                int Counter = us.DeleteCategories(c);


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
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

        }

        //Update Button Function For Categories Table
        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Categories1 c = new Categories1();
            CategoriesBAL us = new CategoriesBAL();


           try
           {
                c.CategoryName = TextBox2.Text.ToString();
                c.CategoryID = Convert.ToInt32(TextBox1.Text.ToString());

                int Counter = us.UpdateCategories(c);


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
           }
           catch (Exception ex)
           {
                Label1.Text = ex.Message;
           }

        }

        //Grid View Function
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            TextBox1.Text = row.Cells[1].Text;
            TextBox2.Text = row.Cells[2].Text;
        }

        //Cancel Button Function
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Emptying the Data in TextBoxes
            TextBox1.Text ="";
            TextBox2.Text ="";
        }
    }
}

