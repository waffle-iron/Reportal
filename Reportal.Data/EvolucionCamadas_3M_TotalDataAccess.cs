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
    public static class EvolucionCamadas_3M_TotalDataAccess
    {
        public static List<EvolucionCamadas_3M> ListarEvolucionCamada_3M_Total()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_IndCredito_EvoCamadas_3M_Total", ConstructorEntidad);
        }

        private static EvolucionCamadas_3M ConstructorEntidad(DataRow row)
        {
            return new EvolucionCamadas_3M
            {
                OrdenSegmento= row["OrdenSegmento"] != DBNull.Value ? Convert.ToInt32(row["OrdenSegmento"]):0,
                OrdenItem = row["OrdenItem"] != DBNull.Value ? Convert.ToInt32(row["OrdenItem"]) : 0,
                Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                item = row["Item"] != DBNull.Value ? row["Item"].ToString() : string.Empty,
                Dic15 = row["Dic15"] != DBNull.Value ? Convert.ToSingle(row["Dic15"]) : 0,
                Ene16 = row["Ene16"] != DBNull.Value ? Convert.ToSingle(row["Ene16"]) : 0,
                Feb16 = row["Feb16"] != DBNull.Value ? Convert.ToSingle(row["Feb16"]) : 0,
                Mar16 = row["Mar16"] != DBNull.Value ? Convert.ToSingle(row["Mar16"]) : 0,
                Abr16 = row["Abr16"] != DBNull.Value ? Convert.ToSingle(row["Abr16"]) : 0,
                May16 = row["May16"] != DBNull.Value ? Convert.ToSingle(row["May16"]) : 0,
                Jun16 = row["Jun16"] != DBNull.Value ? Convert.ToSingle(row["Jun16"]) : 0,
                Jul16 = row["Jul16"] != DBNull.Value ? Convert.ToSingle(row["Jul16"]) : 0
            };
        }
    }
}
