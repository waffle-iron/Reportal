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
    public static class ResumenCanalDataAccess
    {
        public static List<ResumenCanal> ObtenerResumenCanal(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Resumenes_ObtenerResumenCanal", p, ConstructorEntidad);
        }

        private static ResumenCanal ConstructorEntidad(DataRow row)
        {
            return new ResumenCanal
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Canal = row["Canal"] != DBNull.Value ? row["Canal"].ToString() : string.Empty,
                Cantidad = row["Cantidad"] != DBNull.Value ? Convert.ToInt32(row["Cantidad"]) : 0,
            };
        }
    }
}
