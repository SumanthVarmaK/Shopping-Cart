using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repositories
{
    //Creating Interface For Subcategories Table
    interface ISubCategories
    {
        int InsertSubCategories(SubCategories1 us);
        int DeleteSubCategories(SubCategories1 us);
        int UpdateSubCategories(SubCategories1 us);
        DataSet GetIDwiseSubCategories();
        DataSet GetSubCategories();
    }
}
