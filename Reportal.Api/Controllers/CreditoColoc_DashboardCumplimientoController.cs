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
    public class CreditoColoc_DashboardCumplimientoController : ApiController
    {
        // GET: CreditoColoc_Diaria
        private Cred_ColocDiariaTableRepositorycs ColocDiariaDash;

        public CreditoColoc_DashboardCumplimientoController()
        {
            ColocDiariaDash = new Cred_ColocDiariaTableRepositorycs();
        }

        public Cred_ColocDashboard Get()
        {
            return ColocDiariaDash.OIbtenerDashboardCumplimiento();
        }
    }
}