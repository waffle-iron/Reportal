﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Api.Models;
using Reportal.Domain;
using System.Web.Http.Cors;

namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class ResumenController : ApiController
    {
        private ResumenRepository resumenRepo;

        public ResumenController()
        {
            resumenRepo = new ResumenRepository();
        }

        // GET api/Resumen
        public ResumenGlobal Get()
        {
            return resumenRepo.Obtener();
        }

        public List<ResumenGlobal> Get(string listar)
        {
            return resumenRepo.Listar();
        }

    }
}
