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
    public class CredCumplimiento_NetoController : ApiController
    {
        // GET: CreditoColoc_Diaria
        private CredCumplimiento_Neto CumpNeto;

        public CredCumplimiento_NetoController()
        {
            CumpNeto = new CredCumplimiento_Neto();
        }

        public IEnumerable<Cred_CumplimientoPpto> Get()
        {
            return CumpNeto.Listar();
        }
    }
}

