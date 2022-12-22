using ShoppingCart.Common_Utilities;
using ShoppingCart.Models;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShoppingCart.Data_Access_Layer
{
    public class OrdersDAL : IOrders
    {
        public int DeleteOrders(Orders1 us)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            int Counter = 0;

            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = Common.ConnectionString;

                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProceduresList.USP_Orders_ShoppingCart_Delete;

                cmd.Parameters.AddWithValue("@OrderID", us.OrderID);

                cn.Open();
                Counter = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
            return (Counter);
        }

        public DataSet GetOrders()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Common.ConnectionString;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProceduresList.USP_Orders_ShoppingCart_Select;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            sda.Fill(dSet);
            //cn.Close();
            return (dSet);
        }

        public DataSet GetIDwiseOrders()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Common.ConnectionString;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProceduresList.USP_Orders_ShoppingCart_SelectOrderID;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            sda.Fill(dSet);
            //cn.Close();
            return (dSet);
        }
        public int InsertOrders(Orders1 us)
        {


            SqlConnection cn = null;
            SqlCommand cmd = null;
            int Counter = 0;

            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = Common.ConnectionString;

                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProceduresList.USP_Orders_ShoppingCart_Insert;
                cmd.Parameters.AddWithValue("@OrderDate", us.OrderDate);
                cmd.Parameters.AddWithValue("@UserID", us.UserID);
                cmd.Parameters.AddWithValue("@OrderAmount", us.OrderAmount);
               
                cn.Open();

                Counter = cmd.ExecuteNonQuery();





            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
            return Counter;
        }



        public int UpdateOrders(Orders1 us)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            int Counter = 0;

            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = Common.ConnectionString;

                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProceduresList.USP_Orders_ShoppingCart_Update;
                cmd.Parameters.AddWithValue("@OrderDate", us.OrderDate);
                cmd.Parameters.AddWithValue("@UserID", us.UserID);
                cmd.Parameters.AddWithValue("@OrderAmount", us.OrderAmount);
                cmd.Parameters.AddWithValue("@OrderID", us.OrderID);

                cn.Open();
                Counter = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
            return (Counter);
        }
    }
}