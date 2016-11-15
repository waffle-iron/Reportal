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
    public class SegPreaprobadosPorSegmentoController : ApiController
    {
        // GET: api/SegPreaprobadosPorSegmento/201609
        public IEnumerable<SegPreaprobadosGlobal> Get(int id)
        {
            return SegPreaprobadosGlobalDataAccess.ListarBySegment(id);
        }
    }
}
