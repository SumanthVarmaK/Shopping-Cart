using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repositories
{
    //Creating Interface For Categories Table 
    interface ICategories 
    {
        int InsertCategories(Categories1 us); 
        int DeleteCategories(Categories1 us);
        int UpdateCategories(Categories1 us);
       
        DataSet GetCategories();

    }
}
