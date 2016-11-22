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
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    public class ResumenLicenciaController : ApiController
    {
        private ResumenLicenciaRepository resumenRepo;

        public ResumenLicenciaController()
        {
            resumenRepo = new ResumenLicenciaRepository();
        }

        // GET api/TendenciaResumen
        public TendenciaBarChart Get(int id)
        {
            return resumenRepo.ObtenerGraficoBarra(id);
        }
    }
}