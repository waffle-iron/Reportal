﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Domain;
using Reportal.Data;
using Reportal.Api.Models;
using System.Web.Http.Cors;

namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class FechaActualizacionController : ApiController
    {
        public FechaActualizacion Get(int id)
        {
            return FechaActualizacionDataAccess.Obtener(id);
        }

    }
}
