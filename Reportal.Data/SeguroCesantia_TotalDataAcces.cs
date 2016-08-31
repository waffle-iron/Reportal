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
    public static class SeguroCesantia_TotalDataAcces
    {
        public static List<SeguroCesantia> ListarSeguro_Total()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_IndCredito_SeguroCesantia_Total", ConstructorEntidad);
        }

        private static SeguroCesantia ConstructorEntidad(DataRow row)
        {
            return new SeguroCesantia
            {
                OrdenSegmento = row["OrdenSegmento"] != DBNull.Value ? Convert.ToInt32(row["OrdenSegmento"]) : 0,
                OrdenItem = row["OrdenItem"] != DBNull.Value ? Convert.ToInt32(row["OrdenItem"]) : 0,
                Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                item = row["Item"] != DBNull.Value ? row["Item"].ToString() : string.Empty,
                Jun16 = row["Jun16"] != DBNull.Value ? Convert.ToSingle(row["Jun16"]) : 0,
                Jul16 = row["Jul16"] != DBNull.Value ? Convert.ToSingle(row["Jul16"]) : 0
            };
        }
    }
}
