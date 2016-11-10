using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class EvolucionCamadas_6M_TotalRepository
    {
        public List<EvolucionCamadas_6M> Listar()
        {
            return EvolucionCamadas_6M_TotalDataAccess.ListarEvolucionCamada_6M_Total();
        }

    }
}