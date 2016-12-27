using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Domain;
using Reportal.Api.Models;
using System.Web.Http.Cors;


namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    //[AuthorizationRequired]
    public class EmpresaClasificacionController : ApiController
    {
        private EmpresaRepository emprerepositorio;

        public EmpresaClasificacionController()
        {
            emprerepositorio = new EmpresaRepository();
        }
        public IEnumerable<EmpresaClasif> Get(int id)
        {
            return emprerepositorio.ListarClas(id);
        }
    }
}