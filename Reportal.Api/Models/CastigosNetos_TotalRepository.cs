using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class CastigosNetos_TotalRepository
    {
        public List<CastigosNetos> Listar()
        {
            return CastigosNetos_TotalDataAccess.ListarCastigosNetos_Total();
        }

      
    }
}