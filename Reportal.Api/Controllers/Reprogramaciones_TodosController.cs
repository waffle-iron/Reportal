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
    public class Reprogramaciones_TodosController : ApiController
    {

        private Reprogramaciones_TodosRepository evolucionRepo;

        public Reprogramaciones_TodosController()
        {
            evolucionRepo = new Reprogramaciones_TodosRepository();
        }

        public IEnumerable<Reprogramaciones> Get()
        {
            return evolucionRepo.Listar();
        }


    }
}