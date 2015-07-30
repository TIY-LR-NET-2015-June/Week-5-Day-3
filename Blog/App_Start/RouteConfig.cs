using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Blog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Detail Indexing",
                url: "Posts/{id}",
                defaults: new { controller = "Post", action = "Details", id = 0 }
                );
            routes.MapRoute(
                name: "Create",
                url: "Posts/new",
                defaults: new { controller = "Posts", action = "Create"}
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Post", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}
