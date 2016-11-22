using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Domain;
using Reportal.Api.Models;
using System.Web.Http.Cors;
using Reportal.Api.ActionFilters;

namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    [AuthorizationRequired]
    public class CreditoColoc_DiariaController : ApiController
    {
        // GET: CreditoColoc_Diaria
        private CreditoColoc_DiariaRepository ColocDiaria;

        public CreditoColoc_DiariaController()
        {
            ColocDiaria = new CreditoColoc_DiariaRepository();
        }

        public IEnumerable<CreditoColoc_Diaria> Get(int id)
        {
            return ColocDiaria.Listar(id);
        }
    }
}