using System.Web.Mvc;
using System.Web.Routing;

namespace E_Ticaret.WEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "Default10",
             url: "UyeOl",
             defaults: new { controller = "Customer", action = "Register", id = UrlParameter.Optional }
         );

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "Default9",
             url: "Logout",
             defaults: new { controller = "Customer", action = "Logout", id = UrlParameter.Optional }
         );

            routes.MapRoute(
              name: "Default8",
              url: "Login",
              defaults: new { controller = "Customer", action = "Login", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "Default7",
               url: "Arama",
               defaults: new { controller = "Home", action = "Search", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default6",
                url: "Odeme",
                defaults: new { controller = "Home", action = "Payment", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default5",
                url: "Yazar/{id}",
                defaults: new { controller = "Home", action = "Writer", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default4",
                url: "Sepetim",
                defaults: new { controller = "Home", action = "ShoppingChart", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default3",
                url: "Kategori/{id}",
                defaults: new { controller = "Home", action = "Category", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default2",
                url: "Kitap-Bilgileri/{id}",
                defaults: new { controller = "Home", action = "BookDetails", id = UrlParameter.Optional }
            );



            routes.MapRoute(
                name: "Default1",
                url: "Anasayfa",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
