using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class EvolucionCamadas_3M_PensRepository
    {
        public List<EvolucionCamadas_3M> Listar()
        {
            return EvolucionCamadas_3M_PensDataAccess.ListarEvolucionCamada_3M_Pens();
        }

    }
}