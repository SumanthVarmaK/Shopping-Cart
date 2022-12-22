using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    //Creating Auto Implemented Properties For Users Table
    public class Users1 //Class Name
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DoorNumber { get; set; }
        public string StreetLine { get; set; }
        public string LandMark { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PinCode { get; set; }
        public string Country { get; set; }
        public int RoleID { get; set; }


    }
}