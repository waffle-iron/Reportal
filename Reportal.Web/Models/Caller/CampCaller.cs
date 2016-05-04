using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using Reportal.Domain;
using CDK.System.Configuration;

namespace Reportal.Web.Models.Caller
{
    public class CampCaller
    {

        private RestClient client;

        public CampCaller()
        {
            client = new RestClient(ConfigHelper.ObtenerKeyWebConfig("ServiceBaseUrl"));
        }

        public List<Campania> Get()
        {
            var request = new RestRequest("campanias", Method.GET);
            IRestResponse<List<Campania>> response = client.Execute<List<Campania>>(request);
            return response.Data;
        }

        public Campania Get(int id)
        {            
            var request = new RestRequest("campanias/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            IRestResponse<Campania> response = client.Execute<Campania>(request);
            return response.Data;
        }


    }
}