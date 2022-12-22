using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repositories
{
    interface IOrders
    {
        int InsertOrders(Orders1 us);
        int DeleteOrders(Orders1 us);
        int UpdateOrders(Orders1 us);
        DataSet GetIDwiseOrders();
        DataSet GetOrders();
    }
}
