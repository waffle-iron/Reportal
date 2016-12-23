using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Domain;
using Reportal.Api.Models;
using System.Web.Http.Cors;
using Reportal.Api.ActionFilters;
namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    //[AuthorizationRequired]
    public class EmpresaLicenciaTop20Controller : ApiController
    {
        private EmpresaRepository Top;
        public EmpresaLicenciaTop20Controller()
        {
            Top = new EmpresaRepository();
        }

        public IEnumerable<EmpresaLicenciaC> Get(int id)
        {
            return Top.ListarLicenciaTop20(id);
        }

    }
}