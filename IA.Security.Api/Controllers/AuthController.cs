using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IA.Security.Data;
using IA.Security.Domain;

namespace IA.Security.Api.Controllers
{
    public class AuthController : ApiController
    {
        public IEnumerable<Recurso> Get(string usuario)
        {
            Usuario u = new Usuario(usuario);
            List<Recurso> rc = RecursoDataAccess.MenusDeUsuario(u);
            return Recurso.AsignarDesendencia(rc).Where(x=>x.IdRecursoPradre==0).ToList();
        }
    }
}