using ShoppingCart.Models;
using ShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ShoppingCart.Common_Utilities;

namespace ShoppingCart.Data_Access_Layer
{
    public class UsersDAL : IUsers
    {
       
        public int DeleteUsers(Users1 us)
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
                cmd.CommandText = StoredProceduresList.USP_Users_ShoppingCart_Delete;

                cmd.Parameters.AddWithValue("@UserID", us.UserID);

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

        public DataSet GetUsers()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Common.ConnectionString;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProceduresList.USP_Users_ShoppingCart_Select;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            sda.Fill(dSet);
            
            return (dSet);
        }

        public int InsertUsers(Users1 us)
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
                cmd.CommandText = StoredProceduresList.USP_Users_ShoppingCart_Insert;
                cmd.Parameters.AddWithValue("@UserName", us.UserName);
                cmd.Parameters.AddWithValue("@Password", us.Password);
                cmd.Parameters.AddWithValue("@Email", us.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", us.PhoneNumber);
                cmd.Parameters.AddWithValue("@DoorNumber", us.DoorNumber);
                cmd.Parameters.AddWithValue("@StreetLine", us.StreetLine);
                cmd.Parameters.AddWithValue("@LandMark", us.LandMark);
                cmd.Parameters.AddWithValue("@City", us.City);
                cmd.Parameters.AddWithValue("@State", us.State);
                cmd.Parameters.AddWithValue("@PinCode", us.PinCode);
                cmd.Parameters.AddWithValue("@Country", us.Country);
                cmd.Parameters.AddWithValue("@RoleID", us.RoleID);
               




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

        public int UpdateUser(Users1 us)
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
                cmd.CommandText = StoredProceduresList.USP_Users_ShoppingCart_Update;
               
                cmd.Parameters.AddWithValue("@UserID", us.UserID);
                cmd.Parameters.AddWithValue("@Password", us.Password);
                cmd.Parameters.AddWithValue("@Email", us.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", us.PhoneNumber);
                cmd.Parameters.AddWithValue("@DoorNumber", us.DoorNumber);
                cmd.Parameters.AddWithValue("@StreetLine", us.StreetLine);
                cmd.Parameters.AddWithValue("@Landmark", us.LandMark);
                cmd.Parameters.AddWithValue("@City", us.City);
                cmd.Parameters.AddWithValue("@State", us.State);
                cmd.Parameters.AddWithValue("@Pincode", us.PinCode);
                cmd.Parameters.AddWithValue("@Country", us.Country);
                cmd.Parameters.AddWithValue("@RoleID", us.RoleID);


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