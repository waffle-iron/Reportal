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
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    public class Reprogramaciones_PensController : ApiController
    {

        private Reprogramaciones_PensRepository evolucionRepo;

        public Reprogramaciones_PensController()
        {
            evolucionRepo = new Reprogramaciones_PensRepository();
        }

        public IEnumerable<Reprogramaciones> Get()
        {
            return evolucionRepo.Listar();
        }


    }
}