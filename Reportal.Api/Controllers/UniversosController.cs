using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Domain;
using Reportal.Data;
using Reportal.Api.Models;
using System.Web.Http.Cors;
using Reportal.Api.ActionFilters;


namespace Reportal.Api.Controllers
{
    [RoutePrefix("api/seg-preaprobados")]
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    [AuthorizationRequired]
    public class UniversosController : ApiController
    {

        [HttpGet]
        [Route("resumenes-universos")]
        public ResultadoUniversos ResumenUniversos(int Periodo)
        {
            return new ResultadoUniversos
            {
                totalesUniverso = SegPreaprobadosGlobalDataAccess.ListarTotalesUniverso(Periodo),
                universoCampagnado = SegPreaprobadosGlobalDataAccess.ListarUniversoCampagnado(Periodo),
                universoGestionable = SegPreaprobadosGlobalDataAccess.ListarUniversoGestionable(Periodo),
                universoCampagnadoPropension = SegPreaprobadosGlobalDataAccess.ListarUniversoCampagnadoPropension(Periodo),
                universoGestionablePropension = SegPreaprobadosGlobalDataAccess.ListarUniversoGestionablePropension(Periodo),
            };
        }
    }
}
