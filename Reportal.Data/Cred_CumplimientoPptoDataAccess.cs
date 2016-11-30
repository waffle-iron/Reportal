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
    public static class Cred_CumplimientoPptoDataAccess
    {
        public static List<Cred_CumplimientoPpto> ListarCumplimientoNeto()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Directorio_CredPpto_CumplimientoTotal", ConstructorEntidad);
        }
        private static Cred_CumplimientoPpto ConstructorEntidad(DataRow row)
        {
            return new Cred_CumplimientoPpto
            {
                Item = row["Item"] != DBNull.Value ? row["Item"].ToString() : string.Empty,
                indx = row["iitem"] != DBNull.Value ? Convert.ToInt32(row["iitem"]) : 0,
                TotalNeto = row["TotalNeto"] != DBNull.Value ? Convert.ToInt32(row["TotalNeto"]) : 0,
            };
        }
    }
}
