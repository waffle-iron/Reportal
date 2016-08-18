using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reportal.Domain;
using System.Data;
using CDK.Data;
using CDK.Integration;

namespace Reportal.Data
{
    public static class PensionadoResumenDataAccess
    {
        public static List<PensionadosResumen> ListarPensionadoResumen()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_ListarEmpresas", ConstructorEntidad);
        }
    }
}
