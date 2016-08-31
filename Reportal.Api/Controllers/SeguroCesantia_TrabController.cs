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
    public class SeguroCesantia_TrabController : ApiController
    {

        private SeguroCesantia_TrabRepository evolucionRepo;

        public SeguroCesantia_TrabController()
        {
            evolucionRepo = new SeguroCesantia_TrabRepository();
        }

        public IEnumerable<SeguroCesantia> Get()
        {
            return evolucionRepo.Listar();
        }


    }
}