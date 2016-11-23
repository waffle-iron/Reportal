using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class CreditoFinanciamentoRepository
    {
        public List<Cred_Financiamento> Listar(int id)
        {
            return CreditoFinanciamentoDataAccess.Listar(id);
        }
        public List<Cred_Financiamento> ListarDashGraf()
        {
            return CreditoFinanciamentoDataAccess.ListarFinanGraf();
        }
        public Cred_Financiamento OIbtenerDashboard()
        {
            return CreditoFinanciamentoDataAccess.Obtener_Dashboard();
        }
        public Cred_Financiamento OIbtenerDashboardAnt()
        {
            return CreditoFinanciamentoDataAccess.Obtener_DashboardAnterior();
        }
    }
}