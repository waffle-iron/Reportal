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
<<<<<<< HEAD
        public List<Cred_Financiamento> Listar(int Periodo, int iSegmento)
        {
            return CreditoFinanciamentoDataAccess.Listar(Periodo,iSegmento);
=======
        public List<Cred_Financiamento> Listar(int id)
        {
            return CreditoFinanciamentoDataAccess.Listar(id);
>>>>>>> 2c3a650d4a2c8ee9baf2829c290395fbdc8a1bec
        }
    }
}