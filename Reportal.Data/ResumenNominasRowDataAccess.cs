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
    public static class ResumenNominasRowDataAccess
    {
       public static List<RowsCanales> Obtener(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Resumenes_ObtenerRowsCanales", p, ConstructorEntidad);
        }

        private static RowsCanales ConstructorEntidad(DataRow row)
        {
            return new RowsCanales
            {
                Canal = row["Canal"] != DBNull.Value ? row["Canal"].ToString() : string.Empty,
                Cantidad = row["N"] != DBNull.Value ? Convert.ToInt32(row["N"]) : 0,
            };
        }
    }
}
