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
    public class ProductsDAL : IProducts
    {
        public int DeleteProducts(Products1 us)
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
                cmd.CommandText = StoredProceduresList.USP_PRODUCTS_ShoppingCart_Delete;

                cmd.Parameters.AddWithValue("@ProductID", us.ProductID);

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

        public DataSet GetProducts()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Common.ConnectionString;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProceduresList.USP_Products_ShoppingCart_Select;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            sda.Fill(dSet);
            //cn.Close();
            return (dSet);
        }

        public DataSet GetIDwiseProducts()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Common.ConnectionString;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProceduresList.USP_PRODUCTS_ShoppingCart_SelectPRODUCTID;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            sda.Fill(dSet);
            //cn.Close();
            return (dSet);
        }
        public int InsertProducts(Products1 us)
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
                cmd.CommandText = StoredProceduresList.USP_Products_ShoppingCart_Insert;
                cmd.Parameters.AddWithValue("@SubCategoryID", us.SubCategoryID);
                cmd.Parameters.AddWithValue("@ProductName", us.ProductName);
                cmd.Parameters.AddWithValue("@ProductDescription", us.ProductDescription);
                cmd.Parameters.AddWithValue("@Cost", us.Cost);
                cmd.Parameters.AddWithValue("@ImagePath", us.ImagePath);
                cmd.Parameters.AddWithValue("@StockLevel", us.StockLevel);
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



        public int UpdateProducts(Products1 us)
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
                cmd.CommandText = StoredProceduresList.USP_PRODUCT_ShoppingCart_Update;
                cmd.Parameters.AddWithValue("@SubCategoryID", us.SubCategoryID);
                cmd.Parameters.AddWithValue("@ProductName", us.ProductName);
                cmd.Parameters.AddWithValue("@ProductDescription", us.ProductDescription);
                cmd.Parameters.AddWithValue("@Cost", us.Cost);
                cmd.Parameters.AddWithValue("@ImagePath", us.ImagePath);
                cmd.Parameters.AddWithValue("@StockLevel", us.StockLevel);
                cmd.Parameters.AddWithValue("@CategoryID", us.CategoryID);
                cmd.Parameters.AddWithValue("@ProductID", us.ProductID);

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