using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ShoppingCart.Common_Utilities
{
    public class Common
    {
        public static string ConnectionString { get; set; }
        static Common()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        }
    }
}