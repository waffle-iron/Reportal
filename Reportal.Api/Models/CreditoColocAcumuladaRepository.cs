using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class CreditoColocAcumuladaRepository
    {
        public List<CreditoColocAcumulada> Listar()
        {
            return CreditoColocAcumuladaDataAccess.Listar_CredColocAcumulada();
        }
    }
}