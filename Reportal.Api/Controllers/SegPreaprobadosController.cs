using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Domain;
using Reportal.Api.Models;
using Reportal.Api.ActionFilters;
using System.Web.Http.Cors;

namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    [AuthorizationRequired]
    public class SegPreaprobadosController : ApiController
    {
        private SegPreaprobadosRepository repo;

        public SegPreaprobadosController()
        {
            repo = new SegPreaprobadosRepository();
        }

        // GET: api/SegPreaprobados/
        public IEnumerable<SegPreaprobadosGlobal> Get(int id)
        {
            return repo.ListarGlobal(id);
        }

    }
}
