using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repositories
{
    interface IUsers
    {
        int InsertUsers(Users1 us);
        int DeleteUsers(Users1 us);
        int UpdateUser(Users1 us);

        DataSet GetUsers();
       


    }
}
