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
    public partial class Users : System.Web.UI.Page
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
            UsersBAL ubal = new UsersBAL();


            DataSet dSet = ubal.GetUsers();

            GridView1.DataSource = dSet;
            GridView1.DataBind();

            //Binding Role ID to DropDownList
            SqlConnection con = new SqlConnection("data source=192.168.0.37;initial catalog=TSEGRP_2021;uid=tsegrpusr;pwd=PWDtsegrp!1;");
            string com = "select RoleID, RoleName from Roles_ShoppingCart";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.Items.Clear();
            DropDownList1.Items.Insert(0, new ListItem("Please Select RoleName", "0"));
            DropDownList1.DataTextField = "RoleName";
            DropDownList1.DataValueField = "RoleID";
            DropDownList1.DataBind();

            //Binding Country to DropDownList
            SqlConnection cn = new SqlConnection("data source=192.168.0.37;initial catalog=TSEGRP_2021;uid=tsegrpusr;pwd=PWDtsegrp!1;");
            string cmi = "select * from country";
            SqlDataAdapter adp = new SqlDataAdapter(cmi, cn);
            DataTable dtt = new DataTable();
            adp.Fill(dtt);
            DropDownList2.DataSource = dtt;
            DropDownList2.DataBind();
            DropDownList2.Items.Clear();
            DropDownList2.Items.Insert(0, new ListItem("Please Select Country", "0"));
            DropDownList2.DataTextField = "Country";
            DropDownList2.DataValueField = "Country";
            DropDownList2.DataBind();


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            TextBox1.Text = row.Cells[1].Text;
            TextBox2.Text = row.Cells[2].Text;
            TextBox3.Text = row.Cells[3].Text;
            TextBox4.Text = row.Cells[4].Text;
            TextBox5.Text = row.Cells[5].Text;
            TextBox6.Text = row.Cells[6].Text;
            TextBox7.Text = row.Cells[7].Text;
            TextBox8.Text = row.Cells[8].Text;
            TextBox9.Text = row.Cells[9].Text;
            TextBox10.Text = row.Cells[10].Text;
            TextBox11.Text = row.Cells[11].Text;
            DropDownList2.Text = row.Cells[12].Text;
            DropDownList1.Text = row.Cells[13].Text;
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            Users1 us = new Users1();
            UsersBAL ubal = new UsersBAL();
            try
            {
                //sc.CategoryID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
                us.UserName = TextBox2.Text.ToString();
                us.Password = TextBox3.Text.ToString();
                us.Email = TextBox4.Text.ToString();
                us.PhoneNumber = TextBox5.Text.ToString();
                us.DoorNumber = TextBox6.Text.ToString();
                us.StreetLine = TextBox7.Text.ToString();
                us.LandMark = TextBox8.Text.ToString();
                us.City = TextBox9.Text.ToString();
                us.State = TextBox10.Text.ToString();
                us.PinCode = Convert.ToInt32(TextBox11.Text.ToString());
                us.Country = DropDownList2.SelectedValue.ToString();
                us.RoleID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());


                int Counter = ubal.InsertUsers(us);
                BindData();
                if (Counter.Equals(1))
                {

                    Label14.Text = "<h5>Inserted Successfully..";

                }
                else
                {
                    Label14.Text = "Insertion failed..";
                }
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                TextBox11.Text = "";
                DropDownList2.SelectedValue = "";
                DropDownList1.SelectedValue = "";
            }
            catch (Exception ex)
            {
                Label14.Text = ex.Message;
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            Users1 us = new Users1();
            UsersBAL ubal = new UsersBAL();

            try
            {
                //c.CategoryID = Convert.ToInt32(Text);
                //c.CategoryName = row.Cells[2].Text;
                us.UserID = Convert.ToInt32(TextBox1.Text.ToString());
                us.UserName = TextBox2.Text.ToString();
                us.Password = TextBox3.Text.ToString();
                us.Email = TextBox4.Text.ToString();
                us.PhoneNumber = TextBox5.Text.ToString();
                us.DoorNumber = TextBox6.Text.ToString();
                us.StreetLine = TextBox7.Text.ToString();
                us.LandMark = TextBox8.Text.ToString();
                us.City = TextBox9.Text.ToString();
                us.State = TextBox10.Text.ToString();
                us.PinCode = Convert.ToInt32(TextBox11.Text.ToString());
                us.Country = DropDownList2.SelectedValue.ToString();
                us.RoleID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());


                int Counter = ubal.UpdateUser(us);


                GridView1.EditIndex = -1;
                BindData();
                if (Counter.Equals(1))
                {

                    Label14.Text = "<h5>Updated Successfully..";

                }
                else
                {
                    Label4.Text = "Updation failed..";
                }
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                TextBox11.Text = "";
                DropDownList2.SelectedValue = "";
                DropDownList1.SelectedValue = "";
            }
            catch (Exception ex)
            {
                Label14.Text = ex.Message;
            }

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            Users1 us = new Users1();
            UsersBAL ubal = new UsersBAL();

            try
            {
                //c.CategoryID = Convert.ToInt32(Text);
                //c.CategoryName = row.Cells[2].Text;

                us.UserID = Convert.ToInt32(TextBox1.Text.ToString());

                int Counter = ubal.DeleteUsers(us);


                GridView1.EditIndex = -1;
                BindData();
                if (Counter.Equals(1))
                {

                    Label14.Text = "<h5>Deleted Successfully..";

                }
                else
                {
                    Label14.Text = "Deletion failed..";
                }
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                TextBox11.Text = "";
                DropDownList2.SelectedValue = "";
                DropDownList1.SelectedValue = "";
            }
            catch (Exception ex)
            {
                Label14.Text = ex.Message;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            DropDownList2.SelectedValue = "";
            DropDownList1.SelectedValue = "";

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}