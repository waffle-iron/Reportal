using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using Reportal.Domain;
using CDK.System.Configuration;

namespace Reportal.Directorio.Web.Models.Caller
{
    public class ColocCaller
    {
        private RestClient client;

        public ColocCaller()
        {
            client = new RestClient(ConfigHelper.ObtenerKeyWebConfig("ServiceBaseUrl"));
        }
    }
}