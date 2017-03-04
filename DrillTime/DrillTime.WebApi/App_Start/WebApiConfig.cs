using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using DrillTime.DomainClasses;

namespace DrillTime.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Drill>("Drills");
            builder.EntitySet<LogEntry>("LogEntries");
            config.Routes.MapODataServiceRoute("api", "api", builder.GetEdmModel());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
