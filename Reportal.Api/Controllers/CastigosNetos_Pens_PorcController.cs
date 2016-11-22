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
    public class CastigosNetos_Pens_PorcController : ApiController
    {

        private CastigosNetos_Pens_PorcRepository evolucionRepo;

        public CastigosNetos_Pens_PorcController()
        {
            evolucionRepo = new CastigosNetos_Pens_PorcRepository();
        }

        public IEnumerable<CastigosNetos> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}