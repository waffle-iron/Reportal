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
    public class MatrizTransaccion_EController : ApiController
    {

        private MatrizTransaccion_ERepository evolucionRepo;

        public MatrizTransaccion_EController()
        {
            evolucionRepo = new MatrizTransaccion_ERepository();
        }

        public IEnumerable<MatrizTransaccion> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}