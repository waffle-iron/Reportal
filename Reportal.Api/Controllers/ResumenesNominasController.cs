using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Reportal.Data;
using Reportal.Domain;
using Reportal.Api.ActionFilters;

namespace Reportal.Api.Controllers
{
    [RoutePrefix("api/resumenes-nominas")]
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    [AuthorizationRequired]
    public class ResumenesNominasController : ApiController
    {
        [HttpGet]
        [Route("resumen-cascadas-pensionados")]
        public List<ResumenCascadas> ResumenCascadasPensionados(int periodo)
        {
            return ResumenCascadasDataAccess.ObtenerResumenPensionados(periodo);
        }

        [HttpGet]
        [Route("resumen-cascadas-trabajadores")]
        public List<ResumenCascadas> ResumenCascadasTrabajadores(int periodo)
        {
            return ResumenCascadasDataAccess.ObtenerResumenTrabajadores(periodo);
        }

        [HttpGet]
        [Route("resumen-canales")]
        public List<ResumenCanal> ResumenCanal(int periodo)
        {
            return ResumenCanalDataAccess.ObtenerResumenCanal(periodo);
        }

        [HttpGet]
        [Route("resumen-nominas")]
        public ResumenBase ResumenNominas(int periodo)
        {
            ResumenBase retorno = new ResumenBase();
            retorno.ResumenNominas = ResumenNominasDataAccess.ObtenerResumen(periodo);
            retorno.RowsCanales = ResumenNominasRowDataAccess.Obtener(periodo);
            return retorno;
        }

    }
}
