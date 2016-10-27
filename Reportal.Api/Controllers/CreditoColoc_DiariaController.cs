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
    public class CreditoColoc_DiariaController : ApiController
    {
        // GET: CreditoColoc_Diaria
        private CreditoColoc_DiariaRepository ColocDiaria;

        public CreditoColoc_DiariaController()
        {
            ColocDiaria = new CreditoColoc_DiariaRepository();
        }

        public IEnumerable<CreditoColoc_Diaria> Get()
        {
            return ColocDiaria.Listar();
        }
    }
}