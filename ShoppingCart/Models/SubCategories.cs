using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    //Creating Auto Implementation Property For SubCategories Table
    public class SubCategories1 //Class Name 
    {
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryID { get; set; }
    }
}