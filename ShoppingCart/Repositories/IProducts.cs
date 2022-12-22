using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repositories
{
    interface IProducts
    {
        int InsertProducts(Products1 us);
        int DeleteProducts(Products1 us);
        int UpdateProducts(Products1 us);
        DataSet GetIDwiseProducts();
        DataSet GetProducts();
    }
}
