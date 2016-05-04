using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class CampaniasRepository
    {
        public List<Campania> Listar()
        {
            return CampaniaDataAccess.Listar();
        }

        public Campania Obtener(int id)
        {
            return CampaniaDataAccess.Obtener(id);
        }
    }
}