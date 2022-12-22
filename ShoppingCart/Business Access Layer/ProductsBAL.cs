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
    public class ProductsBAL : IProducts
    {
        ProductsDAL dalObj = new ProductsDAL();



        public DataSet GetProducts()
        {
            try
            {
                DataSet dSet = dalObj.GetProducts();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int InsertProducts(Products1 us)
        {
            try
            {
                int Counter = dalObj.InsertProducts(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public int UpdateProducts(Products1 us)
        {
            try
            {
                int Counter = dalObj.UpdateProducts(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int DeleteProducts(Products1 us)
        {
            try
            {
                int Counter = dalObj.DeleteProducts(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet GetIDwiseProducts()
        {
            try
            {
                DataSet dSet = dalObj.GetIDwiseProducts();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}