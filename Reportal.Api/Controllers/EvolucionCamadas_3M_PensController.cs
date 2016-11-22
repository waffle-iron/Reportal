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
    public class EvolucionCamadas_3M_PensController : ApiController
    {
        private EvolucionCamadas_3M_PensRepository evolucionPenRepo;

        public EvolucionCamadas_3M_PensController()
        {
            evolucionPenRepo = new EvolucionCamadas_3M_PensRepository();
        }

        public IEnumerable<EvolucionCamadas_3M> Get()
        {
            return evolucionPenRepo.Listar();
        }
    }
}