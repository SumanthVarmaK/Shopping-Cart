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
    public class CheckCredentialsDAL : ICheckCredentials
    {
        public DataSet CheckCredentials(CheckCredentials1 chk)
        {

            SqlConnection cn = null;
            SqlCommand cmd = null;
            // int Counter = 0;
            SqlDataAdapter sda = null;
            DataSet dSet = null;

            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = Common.ConnectionString;

                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProceduresList.USP_ShoopingCart_Login;

                cmd.Parameters.AddWithValue("@Email", chk.Email);
                cmd.Parameters.AddWithValue("@Password", chk.Password);

                sda = new SqlDataAdapter(cmd);
                dSet = new DataSet();
                cn.Open();
                sda.Fill(dSet);

                //if your procedure is returning, one row and one column data.
                //Counter = Convert.ToInt32(cmd.ExecuteScalar().ToString());//Select


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
            return dSet;
        }
    }
}