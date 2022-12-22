using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShoppingCart.Repositories
{
    interface IExpandAndCollapse
    {
       
        DataSet GetSubCategories1();
        DataSet GetProducts1();
    }
}