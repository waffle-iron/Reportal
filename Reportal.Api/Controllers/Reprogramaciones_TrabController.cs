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
    public class Reprogramaciones_TrabController : ApiController
    {

        private Reprogramaciones_TrabRepository evolucionRepo;

        public Reprogramaciones_TrabController()
        {
            evolucionRepo = new Reprogramaciones_TrabRepository();
        }

        public IEnumerable<Reprogramaciones> Get()
        {
            return evolucionRepo.Listar();
        }


    }
}