using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OvningMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "abbreviation",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Abbreviation", action = "AbbreviationList", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Abbreviation", action = "SingleAbbreviation", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "abbreviation2",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Abbreviation", action = "AbbreviationList2", id = UrlParameter.Optional }
           );
        }
    }
}
