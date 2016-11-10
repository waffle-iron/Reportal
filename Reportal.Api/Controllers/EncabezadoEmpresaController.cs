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
    public class EncabezadoEmpresaController : ApiController
    {
        private EmpresaRepository empresarepositorio;

        public EncabezadoEmpresaController()
        {
            empresarepositorio = new EmpresaRepository();
        }

        public IdentidadEncabezadoEmpresa Get(int id)
        {

            try
            {
                return empresarepositorio.ObtenerEncabezado(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
