using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using IA.Security.Data;
using IA.Security.Domain;

namespace Reportal.Api.ActionFilters
{
    public class TokenService
    {

        

        /// <summary>
        /// Method to validate token against expiry and existence in database.
        /// </summary>
        /// <param name="tokenId"></param>
        /// <returns></returns>
        public bool ValidateToken(string tokenId)
        {
            Token token = TokenDataAccess.Obtener(tokenId).FirstOrDefault(x => x.ExpiresOn > DateTime.Now);
            if (token != null && !(DateTime.Now > token.ExpiresOn))
            {
                token.ExpiresOn = token.ExpiresOn.AddSeconds(Convert.ToDouble(ConfigurationManager.AppSettings["AuthTokenExpiry"]));
                TokenDataAccess.Actualizar(token);
                return true;
            }
            return false;
        }

        
    }
}