using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using Reportal.Domain;
using CDK.System.Configuration;


namespace Reportal.Web.Models.Caller
{
    public class CVidaEmpCaller
    {

        private RestClient client;

        public CVidaEmpCaller()
        {
            client = new RestClient(ConfigHelper.ObtenerKeyWebConfig("ServiceBaseUrl"));
        }
      

        public CicloVidaEmpresa Get(int Rut)
        {
            var request = new RestRequest("campanias/{id}", Method.GET);
            request.AddUrlSegment("id", Rut.ToString());
            IRestResponse<CicloVidaEmpresa> response = client.Execute<CicloVidaEmpresa>(request);
            return response.Data;

        }

    }
}