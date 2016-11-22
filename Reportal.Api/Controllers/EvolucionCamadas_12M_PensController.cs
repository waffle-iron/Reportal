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
    public class EvolucionCamadas_12M_PensController : ApiController
    {
        private EvolucionCamadas_12M_PensRepository evolucionPenRepo;

        public EvolucionCamadas_12M_PensController()
        {
            evolucionPenRepo = new EvolucionCamadas_12M_PensRepository();
        }

        public IEnumerable<EvolucionCamadas_12M> Get()
        {
            return evolucionPenRepo.Listar();
        }
    }
}