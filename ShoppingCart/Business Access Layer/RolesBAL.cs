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
    public class RolesBAL: IRoles
    {
        RolesDAL dalObj = new RolesDAL();



        public DataSet GetRoles()
        {
            try
            {
                DataSet dSet = dalObj.GetRoles();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int InsertRoles(Roles1 us)
        {
            try
            {
                int Counter = dalObj.InsertRoles(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public int UpdateRoles(Roles1 us)
        {
            try
            {
                int Counter = dalObj.UpdateRoles(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int DeleteRoles(Roles1 us)
        {
            try
            {
                int Counter = dalObj.DeleteRoles(us);
                return (Counter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet GetIDwiseRoles()
        {
            try
            {
                DataSet dSet = dalObj.GetIDwiseRoles();
                return (dSet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}