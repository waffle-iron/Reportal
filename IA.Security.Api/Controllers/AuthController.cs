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
using IA.Security.Api.ActionFilters;
using IA.Security.Api.Providers;
using System.Web.Http.Cors;


namespace IA.Security.Api.Controllers
{
    [RoutePrefix("api/Auth")]
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    public class AuthController : ApiController
    {
        private readonly TokenService _tokenServices;
        
        public AuthController()
        {
            _tokenServices = new TokenService();
        }

        /// <summary>
        /// Authenticates user and returns token with expiry.
        /// </summary>
        /// <returns></returns>
        [ApiAuthenticationFilter(true)]
        [HttpPost]
        [Route("authenticate")]        
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
        /// Asegura que los permisos a los recursos del sistema no sean vulnerados.
        /// </summary>
        /// <returns>HttpResponseMessage</returns>
        [ApiAuthenticationFilter(false)]
        [AuthorizationRequired]
        [HttpPost]
        [Route("permission")]
        public HttpResponseMessage Permission()
        {
            string url = ActionContext.Request.Headers.GetValues("Referer").First();
            string token = ActionContext.Request.Headers.GetValues("Token").First();
            return GetUserResource(token, url);
        }



        /// <summary>
        /// Dibuja el menu de usuarios en el sistema
        /// </summary>
        /// <returns>HttpResponseMessage</returns>
        [ApiAuthenticationFilter(false)]
        [AuthorizationRequired]
        [HttpPost]
        [Route("draw-user-resources")]
        public IEnumerable<Recurso> menusUsuario()
        {
            List<Recurso> rc = RecursoDataAccess.MenusDeUsuario(ActionContext.Request.Headers.GetValues("Token").First());
            return Recurso.AsignarDesendencia(rc).Where(x => x.IdRecursoPradre == 0).ToList();
        }


        /// <summary>
        /// Dibuja el menu de usuarios en el sistema
        /// </summary>
        /// <returns>HttpResponseMessage</returns>
        [ApiAuthenticationFilter(false)]
        [AuthorizationRequired]
        [HttpPost]
        [Route("kill")]
        public HttpResponseMessage killAuth()
        {
            return KillToken(ActionContext.Request.Headers.GetValues("Token").First());
        }


        private HttpResponseMessage GetAuthToken(string userId)
        {
            //si en algun momento se necesita validar con ldap de araucana, vamos a ocupar este metodo para trabajarlo
            Token token = _tokenServices.GenerateToken(userId);
            string NombreUsuario = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(UsuarioDataAccess.UsuarioData(userId).Nombres));
            var response = Request.CreateResponse(HttpStatusCode.OK, "Authorized");
            response.Headers.Add("Token", token.AuthToken);
            response.Headers.Add("TokenExpiry", ConfigurationManager.AppSettings["AuthTokenExpiry"]);
            response.Headers.Add("Uname",  NombreUsuario);
            response.Headers.Add("Access-Control-Expose-Headers", "Token,TokenExpiry,Uname");
            return response;
        }
        
        private HttpResponseMessage GetUserResource(string Token, string Resource)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK, "Authorized");

            if (!Resource.Contains(ConfigurationManager.AppSettings["AplicationBaseUrl"]))
            {
                response = Request.CreateResponse(HttpStatusCode.Unauthorized, "UnAuthorized: Request host");
                return response;
            }
            Resource = Resource.Replace(ConfigurationManager.AppSettings["AplicationBaseUrl"], "");
            var MVC_CA = Resource.Split('/');
            if(MVC_CA.Length <= 1 || (MVC_CA.Length == 2 && string.IsNullOrEmpty(MVC_CA[1])))
            {
                Resource = Resource.Replace("/","") + "/Index";
            }
            
            var ResourceList = RecursoDataAccess.MenusDeUsuario(Token);
            List<string> urels = new List<string>(); 
            ResourceList.ForEach(x => {
                if (!string.IsNullOrEmpty(x.Url))
                {
                    urels.Add(x.Url);
                }                    
            });

            if (!urels.Contains(Resource))
            {
                response = Request.CreateResponse(HttpStatusCode.Unauthorized, "UnAuthorized");
            }

            return response;
        }


        private HttpResponseMessage KillToken(string Token)
        {
            _tokenServices.Kill(Token);
            var response = Request.CreateResponse(HttpStatusCode.OK, "Authorized");
            return response;
        }

    }



}