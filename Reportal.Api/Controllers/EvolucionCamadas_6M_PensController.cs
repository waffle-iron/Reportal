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
    public class EvolucionCamadas_6M_PensController : ApiController
    {
        private EvolucionCamadas_6M_PensRepository evolucionPenRepo;

        public EvolucionCamadas_6M_PensController()
        {
            evolucionPenRepo = new EvolucionCamadas_6M_PensRepository();
        }

        public IEnumerable<EvolucionCamadas_6M> Get()
        {
            return evolucionPenRepo.Listar();
        }
    }
}