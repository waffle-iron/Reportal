using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class EvolucionCamadas_12M_PensRepository
    {
        public List<EvolucionCamadas_12M> Listar()
        {
            return EvolucionCamadas_12M_PensDataAccess.ListarEvolucionCamada_12M_Pens();
        }

    }
}