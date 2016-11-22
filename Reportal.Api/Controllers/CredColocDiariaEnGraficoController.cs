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
    public class CredColocDiariaEnGraficoController : ApiController
    {
        // GET: CredColocDiariaTable
        private Cred_ColocDiariaTableRepositorycs CredProm1;

        public CredColocDiariaEnGraficoController()
        {
            CredProm1 = new Cred_ColocDiariaTableRepositorycs();
        }

        public IEnumerable<Cred_ColocDiariaTable> Get()
        {
            return CredProm1.ListarEnGrafico();
        }
    }
}