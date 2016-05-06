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
