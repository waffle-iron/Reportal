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
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class NSEEmpresaController : ApiController
    {
        private NSEEmpresaRepository nseempresarepositorio;

        public NSEEmpresaController()
        {
            nseempresarepositorio = new NSEEmpresaRepository();
        }

        public List<NSEEmpresa>Get(int id)
        {
            return nseempresarepositorio.ListaNSEEmpresaPorRutEmpresa(id);
        }
    }
}
