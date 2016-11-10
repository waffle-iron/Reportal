using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class MatrizTransaccion_BRepository
    {
        public List<MatrizTransaccion> Listar()
        {
            return MatricesTransaccion_BDataAccess.ListarMatrizTransaccion_B();
        }

      
    }
}