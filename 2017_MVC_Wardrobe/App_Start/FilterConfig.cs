﻿using System.Web;
using System.Web.Mvc;

namespace _2017_MVC_Wardrobe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
