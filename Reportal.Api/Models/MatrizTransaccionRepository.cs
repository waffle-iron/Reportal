using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class MatrizTransaccionRepository
    {
        public List<MatrizTransaccion> Listar()
        {
            return MatricesTransaccionDataAccess.ListarMatrizTransaccion_A();
        }

      
    }
}