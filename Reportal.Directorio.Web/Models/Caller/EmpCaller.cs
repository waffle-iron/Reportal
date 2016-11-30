using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using Reportal.Domain;
using CDK.System.Configuration;

namespace Reportal.Web.Models.Caller
{
    public class EmpCaller
    {
        private RestClient client;

        public EmpCaller()
        {
            client = new RestClient(ConfigHelper.ObtenerKeyWebConfig("ServiceBaseUrl"));
        }
        public List<Empresa> Get()
        {
            var request = new RestRequest("empresa", Method.GET);
            IRestResponse<List<Empresa>> response = client.Execute<List<Empresa>>(request);
            return response.Data;
        }

        public Empresa Get(int id)
        {
            var request = new RestRequest("empresa/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            IRestResponse<Empresa> response = client.Execute<Empresa>(request);
            return response.Data;
        }
    }
}