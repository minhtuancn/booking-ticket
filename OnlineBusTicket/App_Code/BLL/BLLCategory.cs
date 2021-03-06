﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DAL;

/// <summary>
/// Summary description for BLLCategory
/// </summary>
/// 
namespace BLL
{
    public class BLLCategory
    {
        public BLLCategory()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static int InsertCategory(Category category)
        {
            int result = 0;
            try
            {
                result = DataAccessHelper.GetCategoryDA().InsertCategory(category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static int UpdateCategory(Category category)
        {
            int result = 0;
            try
            {
                result = DataAccessHelper.GetCategoryDA().UpdateCategory(category);
            }
            catch (Exception ex)
            {
                throw ex; 
            }
            return result;
        }

        public static int DeleteCategory(int id)
        {
            int result = 0;
            try
            {
                result = DataAccessHelper.GetCategoryDA().DeleteCategory(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static Category[] getCategoryByID(int id)
        {
            try
            {
                return DataAccessHelper.GetCategoryDA().getCategoryByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getAllDataByStatus(Boolean status)
        {
            try
            {
                return DataAccessHelper.GetCategoryDA().getAllDataByStatus(status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getAllData()
        {
            try
            {
                return DataAccessHelper.GetCategoryDA().getAllData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int checkCategoryExistName(String name)
        {
            try
            {
                return DataAccessHelper.GetCategoryDA().checkCategoryExistName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
