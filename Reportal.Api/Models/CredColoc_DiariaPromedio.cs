using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;


namespace Reportal.Api.Models
{
    public class CredColoc_DiariaPromedio
    {
        public List<CreditoColoc_Diaria> Listar(int periodo)
        {
           
            return CredColocDiariaPromDataAccess.ListarCreditoProm(periodo);
        }
    }
}