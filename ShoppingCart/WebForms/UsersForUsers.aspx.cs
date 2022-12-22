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
    public partial class UsersForUsers : System.Web.UI.Page
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



                //Binding Role ID to DropDownList
                SqlConnection con = new SqlConnection("data source=192.168.0.37;initial catalog=TSEGRP_2021;uid=tsegrpusr;pwd=PWDtsegrp!1;");
                string com = "select RoleID,RoleName from Roles_ShoppingCart";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                DropDownList1.Items.Clear();
                DropDownList1.Items.Insert(0, new ListItem("--Please Select RoleName--", "0"));
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
                DropDownList2.Items.Insert(0, new ListItem("--Please Select Country--", "0"));
                DropDownList2.DataTextField = "Country";
                DropDownList2.DataValueField = "Country";
                DropDownList2.DataBind();


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
                    us.PinCode = Convert.ToInt32( TextBox11.Text.ToString());
                    us.Country = DropDownList2.SelectedValue.ToString();
                    us.RoleID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());


                    int Counter = ubal.InsertUsers(us);
                    BindData();
                    if (Counter.Equals(1))
                    {

                        Label14.Text = "<h5>Enrolled Successfully You are Redirecting to Home Page Please Login";
                        Response.Redirect("SignUPCart.aspx");

                    }
                    else
                    {
                        Label14.Text = "Enroll failed please verify details that entered";
                    }
                    TextBox1.Text = " ";
                    TextBox2.Text = " ";
                    TextBox3.Text = " ";
                    TextBox4.Text = " ";
                    TextBox5.Text = " ";
                    TextBox6.Text = " ";
                    TextBox7.Text = " ";
                    TextBox8.Text = " ";
                    TextBox9.Text = " ";
                    TextBox10.Text = " ";
                    TextBox11.Text = " ";
                    DropDownList2.Text = " ";
                    DropDownList1.Text = " ";

                }

                catch (Exception eY)
                {

                    if (eY.Message.StartsWith("Violation of UNIQUE KEY constraint"))
                    {
                        Label14.Text = "Email is Already Exist Please Login or Try with another Email";
                    }
                    else
                    {
                        Label14.Text = eY.Message;
                    }





                }

            }

        protected void Button1_Click(object sender, EventArgs e)
        {
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
           
            
        }
    }
}