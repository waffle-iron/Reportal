using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class ReprogramacionesRepository
    {
        public List<Reprogramaciones> Listar()
        {
            return ReprogramacionesDataAcces.ListarProgramaciones_Trab();
        }


    }
}