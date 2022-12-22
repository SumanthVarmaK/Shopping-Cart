using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShoppingCart.Repositories
{
    interface IRoles
    {
        int InsertRoles(Roles1 us);
        int DeleteRoles(Roles1 us);
        int UpdateRoles(Roles1 us);
        DataSet GetIDwiseRoles();
        DataSet GetRoles();
    }
}