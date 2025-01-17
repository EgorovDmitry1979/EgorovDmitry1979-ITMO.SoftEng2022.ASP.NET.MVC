﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebMVCR1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } // п.1.5
                defaults: new { controller = "My", action = "Index", id = UrlParameter.Optional } // п.2.2
                //defaults: new { controller = "My", action = "Start", id = UrlParameter.Optional } // п.2.2
            );
        }
    }
}
