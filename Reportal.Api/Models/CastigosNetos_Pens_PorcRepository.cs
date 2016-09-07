using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class CastigosNetos_Pens_PorcRepository
    {
        public List<CastigosNetos> Listar()
        {
            return CastigosNetos_Pens_PorceDataAccess.ListarCastigosNetos_Pens_Porce();
        }

      
    }
}