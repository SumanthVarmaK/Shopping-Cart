using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Common_Utilities
{
    public class StoredProceduresList
    {
        

        //Stored Procedures for Categories Table
        public static string USP_Categories_ShoppingCart_Insert = "USP_Categories_ShoppingCart_Insert";
        public static string USP_Categories_ShoppingCart_Select = "USP_Categories_ShoppingCart_Select";
        public static string USP_Categories_ShoppingCart_Update = "USP_Categories_ShoppingCart_Update";
        public static string USP_Categories_ShoppingCart_Delete = "USP_Categories_ShoppingCart_Delete";


        //Stored Procedures for SubCategories Table
        public static string USP_SubCategories_ShoppingCart_Insert = "USP_SubCategories_ShoppingCart_Insert";
        public static string USP_SubCategories_ShoppingCart_Select = "USP_SubCategories_ShoppingCart_Select";
        public static string USP_SubCategories_ShoppingCart_Update = "USP_SubCategories_ShoppingCart_Update";
        public static string usp_GetCategoryIDColumn = "usp_GetCategoryIDColumn";
        public static string USP_SubCategories_ShoppingCart_Delete = "USP_SubCategories_ShoppingCart_Delete";

        //Stored Procedures for Products Table
        public static string USP_Products_ShoppingCart_Insert = "USP_Products_ShoppingCart_Insert";
        public static string USP_Products_ShoppingCart_Select = "USP_Products_ShoppingCart_Select";
        public static string USP_PRODUCT_ShoppingCart_Update = "USP_PRODUCT_ShoppingCart_Update";
        public static string USP_PRODUCTS_ShoppingCart_SelectPRODUCTID = "USP_PRODUCTS_ShoppingCart_SelectPRODUCTID";
        public static string USP_PRODUCTS_ShoppingCart_Delete = "USP_PRODUCTS_ShoppingCart_Delete";

        //Stored Procedures for Users Table
        public static string USP_Users_ShoppingCart_Insert = "USP_Users_ShoppingCart_Insert";
        public static string USP_Users_ShoppingCart_Select = "USP_Users_ShoppingCart_Select";
        public static string USP_Users_ShoppingCart_Update = "USP_Users_ShoppingCart_Update";
        public static string USP_Users_ShoppingCart_Delete = "USP_Users_ShoppingCart_Delete";

        //Stored Procedures for Roles Table
        public static string USP_Roles_ShoppingCart_Insert = "USP_Roles_ShoppingCart_Insert";
        public static string USP_Roles_ShoppingCart_Select = "USP_Roles_ShoppingCart_Select";
        public static string USP_Roles_ShoppingCart_Update = "USP_Roles_ShoppingCart_Update";
        public static string USP_Roles_ShoppingCart_SelectRoleID = "USP_Roles_ShoppingCart_SelectRoleID";
        public static string USP_Roles_ShoppingCart_Delete = "USP_Roles_ShoppingCart_Delete";

        //Stored Procedures for Orders Table
        public static string USP_Orders_ShoppingCart_Insert = "USP_Orders_ShoppingCart_Insert";
        public static string USP_Orders_ShoppingCart_Select = "USP_Orders_ShoppingCart_Select";
        public static string USP_Orders_ShoppingCart_Update = "USP_Orders_ShoppingCart_Update";
        public static string USP_Orders_ShoppingCart_SelectOrderID = "USP_Orders_ShoppingCart_SelectOrderID";
        public static string USP_Orders_ShoppingCart_Delete = "USP_Orders_ShoppingCart_Delete";

        //Stored Procedures for OrdersDetails Table
        public static string USP_OrderDetails_ShoppingCart_Insert = "USP_OrderDetails_ShoppingCart_Insert";
        public static string USP_OrderDetails_ShoppingCart_Select = "USP_OrderDetails_ShoppingCart_Select";
        public static string USP_OrderDetails_ShoppingCart_Update = "USP_OrderDetails_ShoppingCart_Update";
        public static string USP_OrderDetails_ShoppingCart_SelectOrderID = "USP_OrderDetails_ShoppingCart_SelectOrderID";
        public static string USP_OrderDetails_ShoppingCart_Delete = "USP_OrderDetails_ShoppingCart_Delete";

        //Stored Procedures for Expand And Collapse Table
        public static string USP_GetProducts1 = "USP_GetProducts1";
        public static string USP_GetSubCategories1 = "USP_GetSubCategories1";

        //Stored Procedure for Login page
        public static string USP_ShoopingCart_Login = "USP_ShoopingCart_Login";
        






    }
}