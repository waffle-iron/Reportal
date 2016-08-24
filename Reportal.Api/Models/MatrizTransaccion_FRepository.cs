using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class MatrizTransaccion_FRepository
    {
        public List<MatrizTransaccion> Listar()
        {
            return MatricesTransaccion_FDataAccess.ListarMatrizTransaccion_F();
        }

      
    }
}