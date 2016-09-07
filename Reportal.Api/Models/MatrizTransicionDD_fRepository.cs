using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class MatrizTransicionDD_FRepository
    {
        public List<MatrizTransicionDD> Listar()
        {
            return MatrizTransicionDD_FDataAccess.ListarMatrizTransicionDD_F();
        }

      
    }
}