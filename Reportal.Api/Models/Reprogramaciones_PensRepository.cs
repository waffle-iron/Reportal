using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class Reprogramaciones_PensRepository
    {
        public List<Reprogramaciones> Listar()
        {
            return Reprogramaciones_PensDataAcces.ListarProgramaciones_Pens();
        }


    }
}