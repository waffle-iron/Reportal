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
    public class EvolucionCamadas_3MController : ApiController
    {

        private EvolucionCamadas_3MRepository evolucionRepo;

        public EvolucionCamadas_3MController()
        {
            evolucionRepo = new EvolucionCamadas_3MRepository();
        }

        public IEnumerable<EvolucionCamadas_3M> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}