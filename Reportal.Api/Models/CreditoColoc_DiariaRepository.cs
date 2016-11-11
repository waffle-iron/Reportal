using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class CreditoColoc_DiariaRepository
    {
        public List<CreditoColoc_Diaria> Listar(int periodo)
        {
            return CreditoColoc_DiariaDataAccess.Listar_CredColocDiaria(periodo);
        }

        public CreditoColoc_Diaria OIbtenerDashboard()
        {
            return CreditoColoc_DiariaDataAccess.Obtener_Dashboard();
        }
        public CreditoColoc_Diaria OIbtenerDashboardDiaAnt()
        {
            return CreditoColoc_DiariaDataAccess.Obtener_DashboardDiaAnt();
        }

     
    }
}