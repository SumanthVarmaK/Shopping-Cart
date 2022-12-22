using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repositories
{
    interface IOrderDetails
    {
        int InsertOrderDetails(OrderDetails1 us);
        int DeleteOrderDetails(OrderDetails1 us);
        int UpdateOrderDetails(OrderDetails1 us);
        DataSet GetIDwiseOrderDetails();
        DataSet GetOrderDetails();
    }
}
