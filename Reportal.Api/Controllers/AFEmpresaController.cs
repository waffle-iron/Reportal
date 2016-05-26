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

    public class AFEmpresaController : ApiController
    {
        private AFEmpresaRepository afempresarepository;

        public AFEmpresaController()
        {
            afempresarepository = new AFEmpresaRepository();
        }
        public List<AFEmpresa> Get(int id)
        {
            //RutEmpresa = id
            return afempresarepository.ListarAFEmpresaPorRut(id);
        }
    }
}
