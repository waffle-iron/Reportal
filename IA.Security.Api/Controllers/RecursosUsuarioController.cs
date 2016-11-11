using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IA.Security.Api.ActionFilters;

namespace IA.Security.Api.Controllers
{
    [AuthorizationRequired]
    public class RecursosUsuarioController : ApiController
    {
        public string GetString()
        {
            return "hola";
        }
    }
}
