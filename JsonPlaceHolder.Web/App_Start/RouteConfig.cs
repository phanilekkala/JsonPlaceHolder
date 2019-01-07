using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JsonPlaceHolder.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "postwithPatameters",
            url: "{controller}/{action}/{userId}/{postId}",
            defaults: new { controller = "Home", action = "Posts", userId = UrlParameter.Optional, postId = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "users", id = UrlParameter.Optional }
            );

            
        }
    }
}
