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
    public class CredCumplimiento_BrutoController : ApiController
    {
        // GET: CreditoColoc_Diaria
        private CredCumplimiento_Bruto CumpBruto;

        public CredCumplimiento_BrutoController()
        {
            CumpBruto = new CredCumplimiento_Bruto();
        }

        public IEnumerable<Coloc_Cumplimiento> Get()
        {
            return CumpBruto.Listar();
        }
    }
}
