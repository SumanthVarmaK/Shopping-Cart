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
    public class UsersBAL : IUsers
    {
        UsersDAL dalObj = new UsersDAL();
        public int DeleteUsers(Users1 us)
        {
            try
            {
                int Counter = dalObj.DeleteUsers(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet GetUsers()
        {
            try
            {
                DataSet dSet = dalObj.GetUsers();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int InsertUsers(Users1 us)
        {
            try
            {
                int Counter = dalObj.InsertUsers(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateUser(Users1 us)
        {
            try
            {
                int Counter = dalObj.UpdateUser(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}