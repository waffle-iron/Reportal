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
    public class CastigosNetos_PensController : ApiController
    {

        private CastigosNetos_PensRepository evolucionRepo;

        public CastigosNetos_PensController()
        {
            evolucionRepo = new CastigosNetos_PensRepository();
        }

        public IEnumerable<CastigosNetos> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}