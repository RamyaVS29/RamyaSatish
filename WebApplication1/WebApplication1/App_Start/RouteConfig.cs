using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Route for Electronics category
            routes.MapRoute(
                name: "Electronics",
                url: "Electronics",
                defaults: new { controller = "Home", action = "Electronics" }
            );

            // Route for Clothing category
            routes.MapRoute(
                name: "Clothing",
                url: "Clothing",
                defaults: new { controller = "Home", action = "Clothing" }
            );

            // Route for Shoes category
            routes.MapRoute(
                name: "Shoes",
                url: "Shoes",
                defaults: new { controller = "Home", action = "Shoes" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
