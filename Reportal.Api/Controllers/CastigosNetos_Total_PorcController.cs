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
    public class CastigosNetos_Total_PorcController : ApiController
    {

        private CastigosNetos_Total_PorcRepository evolucionRepo;

        public CastigosNetos_Total_PorcController()
        {
            evolucionRepo = new CastigosNetos_Total_PorcRepository();
        }

        public IEnumerable<CastigosNetos> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}