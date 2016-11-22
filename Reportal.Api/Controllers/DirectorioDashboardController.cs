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
    public class DirectorioDashboardController : ApiController
    {
        // GET: CreditoColoc_Diaria
        private CreditoColoc_DiariaRepository ColocDiaria;

        public DirectorioDashboardController()
        {
            ColocDiaria = new CreditoColoc_DiariaRepository();
        }

        public IEnumerable<DirectorioDashboard> Get()
        {
            return ColocDiaria.Listar();
        }
    }
}