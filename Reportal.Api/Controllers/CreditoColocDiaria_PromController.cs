﻿using System;
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
    public class CreditoColocDiaria_PromController : ApiController
    {
        private CreditoColocDiaria_PromRepository CredProm;

        public CreditoColocDiaria_PromController()
        {
            CredProm = new CreditoColocDiaria_PromRepository();
        }

        public IEnumerable<CreditoColocDiaria_Prom> Get(int id)
        {
            return CredProm.Listar(id);
        }
    }
}