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
    public class OrderDetailsBAL : IOrderDetails
    {
        OrderDetailsDAL dalObj = new OrderDetailsDAL();
        public int DeleteOrderDetails(OrderDetails1 us)
        {
            try
            {
                int Counter = dalObj.DeleteOrderDetails(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet GetIDwiseOrderDetails()
        {
            try
            {
                DataSet dSet = dalObj.GetIDwiseOrderDetails();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet GetOrderDetails()
        {
            try
            {
                DataSet dSet = dalObj.GetOrderDetails();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int InsertOrderDetails(OrderDetails1 us)
        {
            try
            {
                int Counter = dalObj.InsertOrderDetails(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateOrderDetails(OrderDetails1 us)
        {
            try
            {
                int Counter = dalObj.UpdateOrderDetails(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}