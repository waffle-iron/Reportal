using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class EvolucionCamadas_12M_TotalRepository
    {
        public List<EvolucionCamadas_12M> Listar()
        {
            return EvolucionCamadas_12M_TotalDataAccess.ListarEvolucionCamada_12M_Total();
        }

    }
}