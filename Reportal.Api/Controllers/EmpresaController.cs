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
    public class EmpresaController : ApiController
    {
        private EmpresaRepository emprerepositorio;
                public EmpresaController()
        {
            emprerepositorio = new EmpresaRepository();
        }

        public IEnumerable<Empresa> Get()
        {
            return emprerepositorio.Listar();
        }
        public Empresa Get(int RutEmpresas)
        {
            //  return camprepositorio.Obtener(id);
            return emprerepositorio.Obtener(RutEmpresas);
        }


    }
}
