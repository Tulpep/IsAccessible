﻿using System.Web;
using System.Web.Mvc;

namespace Tulpep.IsAccessible
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
