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
    public class CreditoColoc_DashboardGraficoController : ApiController
    {

        private Cred_ColocDiariaTableRepositorycs creditoGrafico;
        // GET: CreditoColoc_DashboardGrafico
        public CreditoColoc_DashboardGraficoController()
        {
            creditoGrafico = new Cred_ColocDiariaTableRepositorycs();
        }
        public IEnumerable<Cred_ColocDiariaTable> Get()
        {
            return creditoGrafico.ListarEnGrafico();
        }
    }
}