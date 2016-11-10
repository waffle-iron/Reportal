using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Api.Models;
using System.Web.Http.Cors;

namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class RcPeriodosController : ApiController
    {
        private RiesgoCreditoRepository RCRepo;

        public RcPeriodosController()
        {
            RCRepo = new RiesgoCreditoRepository();
        }

        public IEnumerable<int> Get()
        {
            return RCRepo.ObtenerPeriodos();
        }
    }
}
