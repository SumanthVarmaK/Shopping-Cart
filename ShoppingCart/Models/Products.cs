using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    //Creating Auto Implemented Properties For  Products Table
    public class Products1 //Class Name
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Cost { get; set; }
        public string ImagePath { get; set; }
        public int StockLevel { get; set; }


    }
}