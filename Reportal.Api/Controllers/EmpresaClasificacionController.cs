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
    public class EmpresaClasificacionController : ApiController
    {
        // GET: EmpresaClasificacion
        private EmpresaRepository emprerepositorio;

        public EmpresaClasificacionController()
        {
            emprerepositorio = new EmpresaRepository();
        }
        public IEnumerable<EmpresaClasif> Get()
        {
            return emprerepositorio.ListarClas();
        }
    }
}