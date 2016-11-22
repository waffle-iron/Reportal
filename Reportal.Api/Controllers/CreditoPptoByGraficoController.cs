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
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    public class CreditoPptoByGraficoController : ApiController
    { 
        private D_CredPptoMensualRepository D_CredRepo;

    public CreditoPptoByGraficoController()
    {
        D_CredRepo = new D_CredPptoMensualRepository();
    }

    public IEnumerable<CrededitoPptoMensual> Get()
    {
        return D_CredRepo.ListarByGrafico();
    }
}
}