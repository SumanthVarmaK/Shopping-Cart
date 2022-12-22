using ShoppingCart.Common_Utilities;
using ShoppingCart.Models;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data_Access_Layer
{
    public class CategoriesDAL : ICategories // Inheriting the Categories Interface Class to CategoriesDAL Class
    {
        //Delete Function For Categories Table 
        public int DeleteCategories(Categories1 us)
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
                cmd.CommandText = StoredProceduresList.USP_Categories_ShoppingCart_Delete;

                cmd.Parameters.AddWithValue("@CategoryID", us.CategoryID);

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

        //Select Function For Categories Table 
        public DataSet GetCategories()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Common.ConnectionString;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProceduresList.USP_Categories_ShoppingCart_Select;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            sda.Fill(dSet);
            return (dSet);
        }

        //Insert Function For Categories Table 
        public int InsertCategories(Categories1 us)
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
                cmd.CommandText = StoredProceduresList.USP_Categories_ShoppingCart_Insert;
                cmd.Parameters.AddWithValue("@CategoryName", us.CategoryName);

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


        //Update Function For Categories Table 
        public int UpdateCategories(Categories1 us)
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
                cmd.CommandText = StoredProceduresList.USP_Categories_ShoppingCart_Update;
                cmd.Parameters.AddWithValue("@CategoryName", us.CategoryName);
                cmd.Parameters.AddWithValue("@CategoryID", us.CategoryID);

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
