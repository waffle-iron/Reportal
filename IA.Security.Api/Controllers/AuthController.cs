using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Configuration;
using System.Net.Http;
using System.Web.Http;
using IA.Security.Data;
using IA.Security.Domain;
using IA.Security.Api.Filters;
using IA.Security.Api.Providers;
//using AttributeRouting.Web.Mvc;


namespace IA.Security.Api.Controllers
{
    [RoutePrefix("api/Auth")]
    [ApiAuthenticationFilter]
    public class AuthController : ApiController
    {
        //public IEnumerable<Recurso> Get(string usuario)
        //{
        //    Usuario u = new Usuario(usuario);
        //    List<Recurso> rc = RecursoDataAccess.MenusDeUsuario(u);
        //    return Recurso.AsignarDesendencia(rc).Where(x=>x.IdRecursoPradre==0).ToList();
        //}
        private readonly TokenService _tokenServices;


        public AuthController()
        {
            _tokenServices = new TokenService();
        }


        /// <summary>
        /// Authenticates user and returns token with expiry.
        /// </summary>
        /// <returns></returns>
        //[POST("login")]
        //[POST("authenticate")]
        //[POST("get/token")]
        [Route("authnticate")]
        public HttpResponseMessage Authenticate()
        {
            if (System.Threading.Thread.CurrentPrincipal != null && System.Threading.Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                var basicAuthenticationIdentity = System.Threading.Thread.CurrentPrincipal.Identity as BasicAuthenticationIdentity;
                if (basicAuthenticationIdentity != null)
                {
                    var userId = basicAuthenticationIdentity.UserName;
                    return GetAuthToken(userId);
                }
            }
            return null;
        }
        /// <summary>
        /// Authenticates user and returns token with expiry.
        /// </summary>
        /// <returns></returns>
        //[POST("permision")]
        //[POST("get/permision")]
        [Route("permission")]
        public HttpResponseMessage Permission()
        {
            if (System.Threading.Thread.CurrentPrincipal != null && System.Threading.Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                var basicAuthenticationIdentity = System.Threading.Thread.CurrentPrincipal.Identity as BasicAuthenticationIdentity;
                if (basicAuthenticationIdentity != null)
                {
                    var userId = basicAuthenticationIdentity.UserName;
                    return GetUserResource(userId);
                }
            }
            return null;
        }

        private HttpResponseMessage GetAuthToken(string userId)
        {
            Token token = _tokenServices.GenerateToken(userId);
            var response = Request.CreateResponse(HttpStatusCode.OK, "Authorized");
            response.Headers.Add("Token", token.AuthToken);
            response.Headers.Add("TokenExpiry", ConfigurationManager.AppSettings["AuthTokenExpiry"]);
            response.Headers.Add("Access-Control-Expose-Headers", "Token,TokenExpiry");
            return response;
        }

        private HttpResponseMessage GetUserResource(string userId)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK, "Authorized");
            return response;
        }

    }



}