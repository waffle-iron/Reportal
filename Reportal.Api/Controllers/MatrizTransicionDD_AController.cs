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
    public class MatrizTransicionDD_AController : ApiController
    {

        private MatrizTransicionDD_ARepository evolucionRepo;

        public MatrizTransicionDD_AController()
        {
            evolucionRepo = new MatrizTransicionDD_ARepository();
        }

        public IEnumerable<MatrizTransicionDD> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}