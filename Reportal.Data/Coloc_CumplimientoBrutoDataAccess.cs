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
   public static class Coloc_CumplimientoBrutoDataAccess
    {
         public static List<Coloc_Cumplimiento> ListarCumplimientobruto()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_ListarTotalCumplimientoBruto", ConstructorEntidad);
        }
        private static Coloc_Cumplimiento ConstructorEntidad(DataRow row)
        {
            return new Coloc_Cumplimiento
            {
                Periodo = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                Item = row["Item"] != DBNull.Value ? row["Item"].ToString() : string.Empty,
                ind =row["indx"] != DBNull.Value ? Convert.ToInt32(row["indx"]) : 0,
                Total = row["Total"] != DBNull.Value ? Convert.ToInt32(row["Total"]) : 0,
            };
        }
    }
}
