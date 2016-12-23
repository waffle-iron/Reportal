using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IA.Security.Data;
using IA.Security.Domain;
using IA.Security.Api.Filters;
using IA.Security.Api.ActionFilters;
using IA.Security.Api.Providers;
using System.Web.Http.Cors;

namespace IA.Security.Api.Controllers
{
    [RoutePrefix("api/manta")]
    [EnableCors(origins: "http://localhost, http://serv-55, http://localhost:4200", headers: "*", methods: "*")]
    public class MantaController : ApiController
    {

        #region Resources

        [HttpGet]
        [Route("resources")]
        public IEnumerable<Recurso> ListarRecursosGlobal()
        {
            return RecursoDataAccess.ListarRecursos();
        }

        #endregion
    }
}
