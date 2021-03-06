﻿using System;
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
    public class CredColocDiariaPromController : ApiController
    {
        // GET: CredColocDiariaProm
        private CredColoc_DiariaPromedio CredProm;

        public CredColocDiariaPromController()
        {
            CredProm = new CredColoc_DiariaPromedio();
        }

        public IEnumerable<CreditoColoc_Diaria> Get(int id)
        {
            return CredProm.Listar(id);
        }
    }
}