using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class RiesgoCreditoRepository
    {
        public List<IndRiesgoCredito> Obtener(int Periodo)
        {
            return IndRiesgoCreditoDataAccess.Obtener(Periodo);
        }

        public List<int> ObtenerPeriodos()
        {
            return IndRiesgoCreditoDataAccess.ObtenerPeriodos();
        }
    }
}