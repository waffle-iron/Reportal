using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Domain;
using Reportal.Data;
using System.Web.Http.Cors;

namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class SegPreaprobadosPorSegmentoController : ApiController
    {
        // GET: api/SegPreaprobadosPorSegmento/
        public IEnumerable<SegPreaprobadosGlobal> Get()
        {
            return SegPreaprobadosGlobalDataAccess.ListarBySegment(201609);
        }
    }
}
