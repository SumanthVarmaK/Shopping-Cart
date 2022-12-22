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
    public class ExpandAndCollapseDAL : IExpandAndCollapse
    {
        public DataSet GetProducts1()
        {
            SubCategories1 us = new SubCategories1();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Common.ConnectionString;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProceduresList.USP_GetProducts1;
            cmd.Parameters.AddWithValue("@SubCategoryID", us.SubCategoryID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            sda.Fill(dSet);
            //cn.Close();
            return (dSet);
        }

        public DataSet GetSubCategories1()
        {
            SubCategories1 us = new SubCategories1();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Common.ConnectionString;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProceduresList.USP_GetSubCategories1;
            //cmd.Parameters.AddWithValue("@SubCategoryID", us.SubCategoryID);
            cmd.Parameters.AddWithValue("@CategoryID", us.CategoryID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            sda.Fill(dSet);
            //cn.Close();
            return (dSet);
        }
    }
}