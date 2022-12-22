using ShoppingCart.Data_Access_Layer;
using ShoppingCart.Models;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShoppingCart.Business_Access_Layer
{
    public class CategoriesBAL : ICategories // Inheriting the Categories Interface Class to CategoriesBAL Class
    {
        CategoriesDAL dalObj = new CategoriesDAL(); //Creating the Object 
       


        //Select Function For Categories Table 
        public DataSet GetCategories()
        {
            try
            {
                DataSet dSet = dalObj.GetCategories();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Insert Function For Categories Table 
        public int InsertCategories(Categories1 us)
        {
            try 
            {
                int Counter = dalObj.InsertCategories(us);
                return (Counter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //Update Function For Categories Table 
        public int UpdateCategories(Categories1 us)
        {
            try
            {
                int Counter = dalObj.UpdateCategories(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Delete Function For Categories Table 
        public int DeleteCategories(Categories1 us)
        {
            try
            {
                int Counter = dalObj.DeleteCategories(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       
    }
}