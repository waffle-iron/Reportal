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
    public class MatrizTransaccion_GController : ApiController
    {

        private MatrizTransaccion_GRepository evolucionRepo;

        public MatrizTransaccion_GController()
        {
            evolucionRepo = new MatrizTransaccion_GRepository();
        }

        public IEnumerable<MatrizTransaccion> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}