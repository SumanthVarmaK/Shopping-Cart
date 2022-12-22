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
    public class SubCategoriesBAL : ISubCategories
    {
        SubCategoriesDAL dalObj = new SubCategoriesDAL(); //Creating the Object 


        //Select Function For SubCategories Table 
        public DataSet GetSubCategories()
        {
            try
            {
                DataSet dSet = dalObj.GetSubCategories();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Insert Function For SubCategories Table 
        public int InsertSubCategories(SubCategories1 us)
        {
            try
            {
                int Counter = dalObj.InsertSubCategories(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //Update Function For SubCategories Table 
        public int UpdateSubCategories(SubCategories1 us)
        {
            try
            {
                int Counter = dalObj.UpdateSubCategories(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Delete Function For SubCategories Table 
        public int DeleteSubCategories(SubCategories1 us)
        {
            try
            {
                int Counter = dalObj.DeleteSubCategories(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Select ParticularID For SubCategories Table 
        public DataSet GetIDwiseSubCategories()
        {
            try
            {
                DataSet dSet = dalObj.GetIDwiseSubCategories();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}