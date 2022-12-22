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
    public partial class Orders : System.Web.UI.Page
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
            OrdersBAL cat = new OrdersBAL();


            DataSet dSet = cat.GetOrders();

            GridView1.DataSource = dSet;
            GridView1.DataBind();

            SqlConnection con = new SqlConnection("data source=192.168.0.37;initial catalog=TSEGRP_2021;uid=tsegrpusr;pwd=PWDtsegrp!1;");
            string com = "Select UserID,UserName from Users_ShoppingCart";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.Items.Clear();
            DropDownList1.Items.Insert(0, new ListItem("Please Select UserName", "0"));
            DropDownList1.DataTextField = "UserName";
            DropDownList1.DataValueField = "UserID";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Orders1 sc = new Orders1();
            OrdersBAL subcat = new OrdersBAL();
            try
            {
                sc.UserID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
                sc.OrderDate = Convert.ToDateTime(TextBox2.Text.ToString());
                sc.OrderAmount = Convert.ToDecimal(TextBox4.Text.ToString());
                
                int Counter = subcat.InsertOrders(sc);
                BindData();
                if (Counter.Equals(1))
                {

                    Label5.Text = "<h5>Inserted Successfully..";

                }
                else
                {
                    Label5.Text = "Insertion failed..";
                }
                TextBox1.Text = "";
                TextBox2.Text = "";
                DropDownList1.SelectedValue = "";
                TextBox4.Text = "";
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Orders1 c = new Orders1();
            OrdersBAL us = new OrdersBAL();



            c.UserID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            c.OrderDate = Convert.ToDateTime(TextBox2.Text.ToString());
            c.OrderAmount = Convert.ToDecimal(TextBox4.Text.ToString());
            c.OrderID = Convert.ToInt32(TextBox1.Text.ToString());

            int Counter = us.UpdateOrders(c);


            GridView1.EditIndex = -1;
            BindData();
            if (Counter.Equals(1))
            {

                Label5.Text = "<h5>Updated Successfully..";

            }
            else
            {
                Label5.Text = "Updation failed..";
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList1.SelectedValue = "";
            TextBox4.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Orders1 c = new Orders1();
            OrdersBAL us = new OrdersBAL();



            c.OrderID = Convert.ToInt32(TextBox1.Text.ToString());

            int Counter = us.DeleteOrders(c);


            GridView1.EditIndex = -1;
            BindData();
            if (Counter.Equals(1))
            {

                Label5.Text = "<h5>Deleted Successfully..";

            }
            else
            {
                Label5.Text = "Deletion failed..";
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList1.SelectedValue = "";
            TextBox4.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            TextBox1.Text = row.Cells[1].Text;
            TextBox2.Text = row.Cells[2].Text;
            DropDownList1.Text = row.Cells[3].Text;
            TextBox4.Text = row.Cells[4].Text;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList1.SelectedValue = "";
            TextBox4.Text = "";
        }
    }
}