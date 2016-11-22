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
    public class MatrizTransicionDD_DController : ApiController
    {

        private MatrizTransicionDD_DRepository evolucionRepo;

        public MatrizTransicionDD_DController()
        {
            evolucionRepo = new MatrizTransicionDD_DRepository();
        }

        public IEnumerable<MatrizTransicionDD> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}