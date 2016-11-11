using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Data;
using Reportal.Domain;
using System.Web.Http.Cors;

namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class SeguimientoVentaCascadaController : ApiController
    {
        public IEnumerable<SeguimientoVentaCascadaEntity> Get(int Periodo)
        {
            return SeguimientoVentaCascadaDataAccess.ListarByPeriodo(Periodo);
        }
    }
}
