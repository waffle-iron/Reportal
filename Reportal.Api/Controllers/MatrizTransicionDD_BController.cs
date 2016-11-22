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
    public class MatrizTransicionDD_BController : ApiController
    {

        private MatrizTransicionDD_BRepository evolucionRepo;

        public MatrizTransicionDD_BController()
        {
            evolucionRepo = new MatrizTransicionDD_BRepository();
        }

        public IEnumerable<MatrizTransicionDD> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}