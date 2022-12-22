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
    public partial class OrderDetails : System.Web.UI.Page
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
            OrderDetailsBAL cat = new OrderDetailsBAL();


            DataSet dSet = cat.GetOrderDetails();

            GridView1.DataSource = dSet;
            GridView1.DataBind();

            SqlConnection con = new SqlConnection("data source=192.168.0.37;initial catalog=TSEGRP_2021;uid=tsegrpusr;pwd=PWDtsegrp!1;");
            string com = "Select OrderID from Orders_ShoppingCart";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.Items.Clear();
            DropDownList1.Items.Insert(0, new ListItem("Please Select OrderID", "0"));
            DropDownList1.DataTextField = "OrderID";
            DropDownList1.DataValueField = "OrderID";
            DropDownList1.DataBind();

            SqlConnection cn = new SqlConnection("data source=192.168.0.37;initial catalog=TSEGRP_2021;uid=tsegrpusr;pwd=PWDtsegrp!1;");
            string cos = "Select ProductID,ProductName from Products_ShoppingCart";
            SqlDataAdapter adp = new SqlDataAdapter(cos, cn);
            DataTable dtt = new DataTable();
            adp.Fill(dtt);
            DropDownList2.DataSource = dtt;
            DropDownList2.DataBind();
            DropDownList2.Items.Clear();
            DropDownList2.Items.Insert(0, new ListItem("Please Select ProductName", "0"));
            DropDownList2.DataTextField = "ProductName";
            DropDownList2.DataValueField = "ProductID";
            DropDownList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OrderDetails1 sc = new OrderDetails1();
            OrderDetailsBAL subcat = new OrderDetailsBAL();
            try
            {
                sc.OrderID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
                sc.ProductID = Convert.ToInt32(DropDownList2.SelectedValue.ToString());
                sc.Quantity = Convert.ToInt32(TextBox2.Text.ToString());
                sc.Cost =Convert.ToDecimal(TextBox3.Text.ToString());
                sc.Amount = Convert.ToDecimal(TextBox4.Text.ToString());
                
                int Counter = subcat.InsertOrderDetails(sc);
                BindData();
                if (Counter.Equals(1))
                {

                    Label7.Text = "<h5>Inserted Successfully..";

                }
                else
                {
                    Label7.Text = "Insertion failed..";
                }
                TextBox1.Text = "";
                DropDownList1.SelectedValue = "";
                DropDownList2.SelectedValue = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            OrderDetails1 c = new OrderDetails1();
            OrderDetailsBAL us = new OrderDetailsBAL();



            c.OrderID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            c.ProductID = Convert.ToInt32(DropDownList2.SelectedValue.ToString());
            c.Quantity = Convert.ToInt32(TextBox2.Text.ToString());
            c.Cost = Convert.ToDecimal(TextBox3.Text.ToString());
            c.Amount = Convert.ToDecimal(TextBox4.Text.ToString());

            int Counter = us.UpdateOrderDetails(c);


            GridView1.EditIndex = -1;
            BindData();
            if (Counter.Equals(1))
            {

                Label7.Text = "<h5>Updated Successfully..";

            }
            else
            {
                Label7.Text = "Updation failed..";
            }
            TextBox1.Text = "";
            DropDownList1.SelectedValue = "";
            DropDownList2.SelectedValue = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            OrderDetails1 c = new OrderDetails1();
            OrderDetailsBAL us = new OrderDetailsBAL();



            c.OrderDetailsID = Convert.ToInt32(TextBox1.Text.ToString());

            int Counter = us.DeleteOrderDetails(c);


            GridView1.EditIndex = -1;
            BindData();
            if (Counter.Equals(1))
            {

                Label7.Text = "<h5>Deleted Successfully..";

            }
            else
            {
                Label7.Text = "Deletion failed..";
            }
            TextBox1.Text = "";
            DropDownList1.SelectedValue = "";
            DropDownList2.SelectedValue = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            TextBox1.Text = row.Cells[1].Text;
            DropDownList1.Text = row.Cells[2].Text;
            DropDownList2.Text = row.Cells[3].Text;
            TextBox4.Text = row.Cells[4].Text;
            TextBox4.Text = row.Cells[5].Text;
            TextBox4.Text = row.Cells[6].Text;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            DropDownList1.SelectedValue = "";
            DropDownList2.SelectedValue = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
             
        }
    }
}