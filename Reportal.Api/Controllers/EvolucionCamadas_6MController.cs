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
    public class EvolucionCamadas_6MController : ApiController
    {

        private EvolucionCamadas_6MRepository evolucionRepo;

        public EvolucionCamadas_6MController()
        {
            evolucionRepo = new EvolucionCamadas_6MRepository();
        }

        public IEnumerable<EvolucionCamadas_6M> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}