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
    public class D_CredPptoMensualController : ApiController
    {
        private D_CredPptoMensualRepository D_CredRepo;

        public D_CredPptoMensualController()
        {
            D_CredRepo = new D_CredPptoMensualRepository();
        }

        public IEnumerable<D_CredPptoMensual> Get()
        {
            return D_CredRepo.Listar();
        }
    }
}