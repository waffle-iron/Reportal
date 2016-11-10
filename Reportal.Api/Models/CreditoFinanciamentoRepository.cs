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
    }
}