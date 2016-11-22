using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Domain;
using Reportal.Api.Models;
using System.Web.Http.Cors;

namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    public class BenchmarkController : ApiController
    {
        private RiesgoCreditoRepository RCRepo;

        public BenchmarkController()
        {
            RCRepo = new RiesgoCreditoRepository();
        }

        // GET: api/Benchmark/201607/Tasa Riesgo (Mora hasta 365)/
        public IEnumerable<Benchmark> Get(int periodo, string item)
        {
            return RCRepo.ObtenerBenchmark(periodo, item);
        }
    }
}
