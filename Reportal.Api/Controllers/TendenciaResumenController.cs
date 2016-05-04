using System;
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
    public class TendenciaResumenController : ApiController
    {

        private ResumenRepository resumenRepo;

        public TendenciaResumenController()
        {
            resumenRepo = new ResumenRepository();
        }

        // GET api/TendenciaResumen
        public TendenciaBarChart Get()
        {
            return resumenRepo.ObtenerGraficoBarra();
        }

    }
}
