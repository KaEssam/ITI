﻿using System.Web;
using System.Web.Mvc;

namespace ASP.Net_MVC_Day2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
