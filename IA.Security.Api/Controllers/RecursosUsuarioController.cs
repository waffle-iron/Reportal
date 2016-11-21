using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IA.Security.Api.ActionFilters;
using System.Web.Http.Cors;
using IA.Security.Data;
using IA.Security.Domain;
using IA.Security.Api.Filters;

namespace IA.Security.Api.Controllers
{
    [RoutePrefix("api/Resources")]
    [AuthorizationRequired]
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class RecursosUsuarioController : ApiController
    {
        [HttpGet]
        [Route("draw-user-resources")]
        public IEnumerable<Recurso> menusUsuario()
        {
            if (System.Threading.Thread.CurrentPrincipal != null && System.Threading.Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                if (System.Threading.Thread.CurrentPrincipal != null && System.Threading.Thread.CurrentPrincipal.Identity.IsAuthenticated)
                {
                    var basicAuthenticationIdentity = System.Threading.Thread.CurrentPrincipal.Identity as BasicAuthenticationIdentity;
                    if (basicAuthenticationIdentity != null)
                    {
                        List<Recurso> rc = RecursoDataAccess.MenusDeUsuario("");
                        return Recurso.AsignarDesendencia(rc).Where(x => x.IdRecursoPradre == 0).ToList();
                    }
                }
            }
            return null;       
        }

    }
}
