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
    [EnableCors(origins: "http://172.16.133.65", headers: "*", methods: "*")]
    public class CreditoFinanciamentoController : ApiController
    {
        private CreditoFinanciamentoRepository CredFinan;

        public CreditoFinanciamentoController()
        {
            CredFinan = new CreditoFinanciamentoRepository();
        }

        public IEnumerable<Cred_Financiamento> Get()
        {
            return CredFinan.Listar();
        }
    }
}