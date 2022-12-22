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
    public partial class CheckCredentials : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckCredentialsBAL bobj = new CheckCredentialsBAL();
            CheckCredentials1 ud = new CheckCredentials1();
            try
            {

                ud.Email = TextBox1.Text;
                ud.Password = TextBox2.Text;

                //int Counter = bobj.CheckCredentials(ud);
                DataSet dSet = bobj.CheckCredentials(ud);

                int Counter = dSet.Tables[0].Rows.Count;

                if (Counter.Equals(1))
                {
                    Label3.Text = "<h2>Login attempt is successful..";

                    Session["UserID"] = dSet.Tables[0].Rows[0]["UserID"].ToString();
                    Session["Email"] = ud.Email;
                    Session["Password"] = ud.Password;

                    Response.Redirect("Products.aspx");
                }
                else
                {
                    Label3.Text = "<h2>Login attempt is failed..";
                }
            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
            }
        }
    }
}