using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Reportal.Api
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "CreditoFinanciamento",
                url: "{controller}/{action}/{Periodo}/{iSegmento}",
                defaults: new { controller = "CreditoFinanciamento", action = "Index", Periodo = UrlParameter.Optional, iSegmento = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "FechasActualizacion",
                url: "{controller}/{action}/{elcontrolador}/{laaccion}",
                defaults: new { controller = "FechaActualizacion", action = "Index", elcontrolador = UrlParameter.Optional, laaccion = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );




            /*routes.MapRoute(
                name: "Benchmark",
                url: "{controller}/{action}/{periodo}/{item}",
                defaults: new { controller = "Home", action = "Index", periodo = UrlParameter.Optional, item = UrlParameter.Optional }
            );*/




        }
    }
}
