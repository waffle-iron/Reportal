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
    public class CastigosNetos_TotalController : ApiController
    {

        private CastigosNetos_TotalRepository evolucionRepo;

        public CastigosNetos_TotalController()
        {
            evolucionRepo = new CastigosNetos_TotalRepository();
        }

        public IEnumerable<CastigosNetos> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}