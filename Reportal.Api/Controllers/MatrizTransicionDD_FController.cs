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
    public class MatrizTransicionDD_FController : ApiController
    {

        private MatrizTransicionDD_FRepository evolucionRepo;

        public MatrizTransicionDD_FController()
        {
            evolucionRepo = new MatrizTransicionDD_FRepository();
        }

        public IEnumerable<MatrizTransicionDD> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}