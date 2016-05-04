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
    public class CampaniasController : ApiController
    {

        private CampaniasRepository camprepositorio;


        public CampaniasController()
        {
            camprepositorio = new CampaniasRepository();
        }

        // GET: api/Campanias
        public IEnumerable<Campania> Get()
        {
            return camprepositorio.Listar();
        }

        // GET: api/Campanias/5
        public Campania Get(int id)
        {
            return camprepositorio.Obtener(id);
        }

        
    }
}
