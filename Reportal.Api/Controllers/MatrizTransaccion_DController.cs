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
    public class MatrizTransaccion_DController : ApiController
    {

        private MatrizTransaccion_DRepository evolucionRepo;

        public MatrizTransaccion_DController()
        {
            evolucionRepo = new MatrizTransaccion_DRepository();
        }

        public IEnumerable<MatrizTransaccion> Get()
        {
            return evolucionRepo.Listar();
        }

     
    }
}