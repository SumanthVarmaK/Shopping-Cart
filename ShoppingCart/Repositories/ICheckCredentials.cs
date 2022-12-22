using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repositories
{
    interface ICheckCredentials
    {
        DataSet CheckCredentials(CheckCredentials1 chk);
    }
}
