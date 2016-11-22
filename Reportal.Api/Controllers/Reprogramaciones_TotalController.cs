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
    public class Reprogramaciones_TotalController : ApiController
    {

        private Reprogramaciones_TotalRepository evolucionRepo;

        public Reprogramaciones_TotalController()
        {
            evolucionRepo = new Reprogramaciones_TotalRepository();
        }

        public IEnumerable<Reprogramaciones> Get()
        {
            return evolucionRepo.Listar();
        }


    }
}