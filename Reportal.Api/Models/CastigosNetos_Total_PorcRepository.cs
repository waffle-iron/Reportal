using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class CastigosNetos_Total_PorcRepository
    {
        public List<CastigosNetos> Listar()
        {
            return CastigosNetos_Total_PorceDataAccess.ListarCastigosNetos_Total_Porce();
        }

      
    }
}