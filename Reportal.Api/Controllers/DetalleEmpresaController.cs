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
    public class DetalleEmpresaController : ApiController
    {
        private EmpresaRepository empresarepositorio;

        public DetalleEmpresaController()
        {
            empresarepositorio = new EmpresaRepository();
        }

        public IdentidadDetalleEmpresa Get(int id)
        {

           try
            {
                return empresarepositorio.ObtenerDetalle(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
