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
    public class SeguroCesantia_TotalController : ApiController
    {

        private SeguroCesantia_TotalRepository evolucionRepo;

        public SeguroCesantia_TotalController()
        {
            evolucionRepo = new SeguroCesantia_TotalRepository();
        }

        public IEnumerable<SeguroCesantia> Get()
        {
            return evolucionRepo.Listar();
        }


    }
}