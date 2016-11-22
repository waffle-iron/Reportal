using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Api.Models;
using Reportal.Domain;
using System.Web.Http.Cors;


namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    public class RiesgoCreditoController : ApiController
    {
        private RiesgoCreditoRepository RCRepo;

        public RiesgoCreditoController()
        {
            RCRepo = new RiesgoCreditoRepository();
        }

        // GET: api/IndRiesgoCredito/201606
        public IEnumerable<IndRiesgoCredito> Get(int id)
        {
            return RCRepo.Obtener(id);
        }

    }
}
