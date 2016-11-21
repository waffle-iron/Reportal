using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Domain;
using Reportal.Data;
using System.Web.Http.Cors;
using Reportal.Api.ActionFilters;

namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    [AuthorizationRequired]
    public class SegPreaprobadosPorCanalesPropensionController : ApiController
    {
        // GET: api/SegPreaprobadosPorCanalesPropension/
        public IEnumerable<SegPreaprobadosFull> Get(int id)
        {
            return SegPreaprobadosGlobalDataAccess.ListarByCanalesPropension(id);
        }
        
    }
}
