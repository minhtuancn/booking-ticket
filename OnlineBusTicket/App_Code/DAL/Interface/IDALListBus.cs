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

/// <summary>
/// Summary description for IDALListBus
/// </summary>
/// 
namespace DAL
{
    public interface IDALListBus
    {
        //int InsertListBus(ListBus listBus);
        //int UpdateListBus(ListBus listBus);
        //int DeleteListBus(int key);
        //ListBus[] getListBusByID(int id);
        ListBus[] getListBusCustomer(DateTime star, DateTime end,int routerID,Boolean status);
        //DataTable getAllListBus();
        //DataTable getAllListBusByStatus(Boolean status);
        
    }
}
