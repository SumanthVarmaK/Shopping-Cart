using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    //Creating Auto Implemented Properties For Orders Table
    public class Orders1 //Class Name
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserID { get; set; }
        public decimal OrderAmount { get; set; }
    }
}