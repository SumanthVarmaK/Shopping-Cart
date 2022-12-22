using ShoppingCart.Data_Access_Layer;
using ShoppingCart.Models;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShoppingCart.Business_Access_Layer
{
    public class ExpandAndCollapseBAL : IExpandAndCollapse
    {
        ExpandAndCollapseDAL dalObj = new ExpandAndCollapseDAL();
        public DataSet GetProducts1()
        {
            DataSet dSet = dalObj.GetProducts1();
            return (dSet);
        }

        public DataSet GetSubCategories1()
        {
            DataSet dSet = dalObj.GetSubCategories1();
            return (dSet);
        }
    }
}