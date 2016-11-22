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
    [AuthorizationRequired]
    public class DetalleCampaniaController : ApiController
    {
        private CampaniasRepository camprepositorio;

        public DetalleCampaniaController()
        {
            camprepositorio = new CampaniasRepository();
        }

        public IdentidadDetalleCampania Get(int id)
        {
            return camprepositorio.ObtenerDetalle(id);
        }
    }
}
