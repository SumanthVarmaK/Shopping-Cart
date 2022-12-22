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
    public class SubCategoriesDAL : ISubCategories // Inheriting the SubCategories Interface Class to SubCategoriesDAL Class
    {
        //Delete Function For SubCategories Table 
        public int DeleteSubCategories(SubCategories1 us)
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
                cmd.CommandText = StoredProceduresList.USP_SubCategories_ShoppingCart_Delete;

                cmd.Parameters.AddWithValue("@SubCategoryID", us.SubCategoryID);

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

        //Select Function For SubCategories Table 
        public DataSet GetSubCategories()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Common.ConnectionString;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProceduresList.USP_SubCategories_ShoppingCart_Select;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            sda.Fill(dSet);
            //cn.Close();
            return (dSet);
        }

        //Select ParticularID For SubCategories Table 
        public DataSet GetIDwiseSubCategories()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Common.ConnectionString;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProceduresList.usp_GetCategoryIDColumn;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            sda.Fill(dSet);
            //cn.Close();
            return (dSet);
        }
        //Insert Function For SubCategories Table 
        public int InsertSubCategories(SubCategories1 us)
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
                cmd.CommandText = StoredProceduresList.USP_SubCategories_ShoppingCart_Insert;
                cmd.Parameters.AddWithValue("@SubCategoryName", us.SubCategoryName);
                cmd.Parameters.AddWithValue("@CategoryID", us.CategoryID);
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


        //Update Function For SubCategories Table 
        public int UpdateSubCategories(SubCategories1 us)
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
                cmd.CommandText = StoredProceduresList.USP_SubCategories_ShoppingCart_Update;
                cmd.Parameters.AddWithValue("@SubCategoryName", us.SubCategoryName);
                cmd.Parameters.AddWithValue("@CategoryID", us.CategoryID);
                cmd.Parameters.AddWithValue("@SubCategoryID", us.SubCategoryID);

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