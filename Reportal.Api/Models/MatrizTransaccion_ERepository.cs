using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class MatrizTransaccion_ERepository
    {
        public List<MatrizTransaccion> Listar()
        {
            return MatricesTransaccion_EDataAccess.ListarMatrizTransaccion_E();
        }

      
    }
}