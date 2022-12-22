using ShoppingCart.Business_Access_Layer;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingCart.WebForms
{
    public partial class Roles : System.Web.UI.Page
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
            RolesBAL cat = new RolesBAL();


            DataSet dSet = cat.GetRoles();

            GridView1.DataSource = dSet;
            GridView1.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Roles1 c = new Roles1();
            RolesBAL us = new RolesBAL();



            try
            {

                c.RoleName = TextBox2.Text.ToString();
                int Counter = us.InsertRoles(c);
                BindData();
                if (Counter.Equals(1))
                {

                    Label3.Text = "<h5>Inserted Successfully..";

                }
                else
                {
                    Label3.Text = "Insertion failed..";
                }
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Roles1 c = new Roles1();
            RolesBAL us = new RolesBAL();


            try
            {
                c.RoleName = TextBox2.Text.ToString();
                c.RoleID = Convert.ToInt32(TextBox1.Text.ToString());

                int Counter = us.UpdateRoles(c);


                GridView1.EditIndex = -1;
                BindData();
                if (Counter.Equals(1))
                {

                    Label3.Text = "<h5>Updated Successfully..";

                }
                else
                {
                    Label3.Text = "Updation failed..";
                }
                TextBox1.Text = "";
                TextBox2.Text = "";

            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Roles1 c = new Roles1();
            RolesBAL us = new RolesBAL();

            try
            {
                c.RoleID = Convert.ToInt32(TextBox1.Text.ToString());

                int Counter = us.DeleteRoles(c);


                GridView1.EditIndex = -1;
                BindData();
                if (Counter.Equals(1))
                {

                    Label3.Text = "<h5>Deleted Successfully..";

                }
                else
                {
                    Label3.Text = "Deletion failed..";
                }
                TextBox1.Text = "";
                TextBox2.Text = "";


            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
            }


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            TextBox1.Text = row.Cells[1].Text;
            TextBox2.Text = row.Cells[2].Text;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";

        }
    }
}