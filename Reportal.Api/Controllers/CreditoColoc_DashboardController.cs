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
    public class CreditoColoc_DashboardController : ApiController
    {
        // GET: CreditoColoc_Diaria
        private CreditoColoc_DiariaRepository ColocDiariaDash;

        public CreditoColoc_DashboardController()
        {
            ColocDiariaDash = new CreditoColoc_DiariaRepository();
        }

        public CreditoColoc_Diaria Get()
        {
            return ColocDiariaDash.OIbtenerDashboard();
        }
    }
}