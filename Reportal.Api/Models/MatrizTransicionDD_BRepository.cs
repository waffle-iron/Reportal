using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class MatrizTransicionDD_BRepository
    {
        public List<MatrizTransicionDD> Listar()
        {
            return MatrizTransicionDD_BDataAccess.ListarMatrizTransicionDD_B();
        }

      
    }
}