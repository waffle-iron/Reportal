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
    public class SeguroCesantia_TotalController : ApiController
    {

        private SeguroCesantia_TotalRepository evolucionRepo;

        public SeguroCesantia_TotalController()
        {
            evolucionRepo = new SeguroCesantia_TotalRepository();
        }

        public IEnumerable<SeguroCesantia> Get()
        {
            return evolucionRepo.Listar();
        }


    }
}