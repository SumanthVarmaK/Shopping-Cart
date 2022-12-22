using ShoppingCart.Data_Access_Layer;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShoppingCart.Business_Access_Layer
{
    public class CheckCredentialsBAL
    {
        CheckCredentialsDAL dalObj = new CheckCredentialsDAL();

        public DataSet CheckCredentials(CheckCredentials1 chk)
        {
            DataSet dSet = dalObj.CheckCredentials(chk);
            return (dSet);
        }
    }
}