using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    //Creating Auto Implemented Properties For Orders Table
    public class OrderDetails1 //Class Name
    {
        public int OrderDetailsID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public decimal Amount { get; set; }
    }
}