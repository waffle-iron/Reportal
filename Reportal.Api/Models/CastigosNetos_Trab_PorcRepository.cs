using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class CastigosNetos_Trab_PorcRepository
    {
        public List<CastigosNetos> Listar()
        {
            return CastigosNetos_PorceDataAccess.ListarCastigosNetos_Trab_Porc();
        }

      
    }
}