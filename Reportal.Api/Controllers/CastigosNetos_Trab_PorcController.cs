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
    public class CastigosNetos_Trab_PorcController : ApiController
    {

        private CastigosNetos_Trab_PorcRepository evolucionRepo;

        public CastigosNetos_Trab_PorcController()
        {
            evolucionRepo = new CastigosNetos_Trab_PorcRepository();
        }

        public IEnumerable<CastigosNetos> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}