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
    public class ReprogramacionesController : ApiController
    {

        private ReprogramacionesRepository evolucionRepo;

        public ReprogramacionesController()
        {
            evolucionRepo = new ReprogramacionesRepository();
        }

        public IEnumerable<Reprogramaciones> Get()
        {
            return evolucionRepo.Listar();
        }


    }
}