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
    public class CicloVidaEmpresaController : ApiController
    {
        private CicloEmpresaRepository ciclovidarepositorio;

        
        public CicloVidaEmpresaController()
        {
            ciclovidarepositorio = new CicloEmpresaRepository();
        }
      
        public List<CicloVidaEmpresa> Get(int id)
        {
            //RutEmpresa = id
            return ciclovidarepositorio.ListarPorRutEmpresa(id);
        }


    }
}
