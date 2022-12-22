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
    public class OrdersBAL : IOrders
    {
        OrdersDAL dalObj = new OrdersDAL();
        public int DeleteOrders(Orders1 us)
        {
            try
            {
                int Counter = dalObj.DeleteOrders(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet GetIDwiseOrders()
        {
            try
            {
                DataSet dSet = dalObj.GetIDwiseOrders();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }    

        public DataSet GetOrders()
        {
            try
            {
                DataSet dSet = dalObj.GetOrders();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int InsertOrders(Orders1 us)
        {
            try
            {
                int Counter = dalObj.InsertOrders(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public int UpdateOrders(Orders1 us)
        {
            try
            {
                int Counter = dalObj.UpdateOrders(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}