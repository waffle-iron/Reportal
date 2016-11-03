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
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class CreditoColocAcumuladaController : ApiController
    {
        // GET: CreditoColocAcumulada
        private CreditoColocAcumuladaRepository CredAcumulada;

        public CreditoColocAcumuladaController()
        {
            CredAcumulada = new CreditoColocAcumuladaRepository();
        }

        public IEnumerable<CreditoColocAcumulada> Get(int id)
        {
            return CredAcumulada.Listar(id);
        }
    }
}