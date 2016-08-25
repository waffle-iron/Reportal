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
    public class MatrizTransicionDD_EController : ApiController
    {

        private MatrizTransicionDD_ERepository evolucionRepo;

        public MatrizTransicionDD_EController()
        {
            evolucionRepo = new MatrizTransicionDD_ERepository();
        }

        public IEnumerable<MatrizTransicionDD> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}