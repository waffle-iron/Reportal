using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;
namespace Reportal.Api.Models
{
    public class CreditoColocDiaria_PromRepository
    {
        public List<CreditoColocDiaria_Prom> Listar(int periodo)
        {
            return CreditoColocDiaria_PromDataAccess.Listar_CredColocDiariaPromedio(periodo);
        }
    }
}