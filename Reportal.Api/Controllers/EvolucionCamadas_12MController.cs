using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Domain;
using Reportal.Api.Models;
using System.Web.Http.Cors;
using Reportal.Api.ActionFilters;

namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    [AuthorizationRequired]
    public class EvolucionCamadas_12MController : ApiController
    {

        private EvolucionCamadas_12MRepository evolucionRepo;

        public EvolucionCamadas_12MController()
        {
            evolucionRepo = new EvolucionCamadas_12MRepository();
        }

        public IEnumerable<EvolucionCamadas_12M> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}