using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Reportal.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            config.EnableCors();
            // Rutas de API web
            config.MapHttpAttributeRoutes();
            

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "FechasActualizacionApi",
                routeTemplate: "api/{controller}/{elcontrolador}/{laaccion}",
                defaults: new { elcontrolador = RouteParameter.Optional, laaccion = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "BenchmarkApi",
                routeTemplate: "api/{controller}/{periodo}/{item}",
                defaults: new { periodo = RouteParameter.Optional, item = RouteParameter.Optional }
            );

            

        }
    }
}
