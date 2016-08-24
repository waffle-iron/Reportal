using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class EvolucionCamadas_6MRepository
    {
        public List<EvolucionCamadas_6M> Listar()
        {
            return EvolucionCamadas_6MDataAccess.ListarEvolucionCamada_6M();
        }

      
    }
}