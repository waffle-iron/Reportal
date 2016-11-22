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
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    [AuthorizationRequired]
    public class SegPreaprobadosPorNominasPropController : ApiController
    {
        // GET: api/SegPreaprobadosPorNominasProp/
        public IEnumerable<SegPreaprobadosFull> Get(int id)
        {
            return SegPreaprobadosGlobalDataAccess.ListarByNominayPropension(id);
        }
    }
}
