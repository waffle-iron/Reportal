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
    public static class SeguimientoVentaCascadaDataAccess
    {
        public static List<SeguimientoVentaCascadaEntity> ListarByPeriodo(int pPeriodo)
        {
            Parametro p = new Parametro("@Periodo", pPeriodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SeguimientoVentaCascada_ListarByPeriodo", p ,ConstructorEntidad);
        }

        private static SeguimientoVentaCascadaEntity ConstructorEntidad(DataRow row)
        {
            return new SeguimientoVentaCascadaEntity
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                Filtro = row["Filtro"] != DBNull.Value ? row["Filtro"].ToString() : string.Empty,
                N = row["N"] != DBNull.Value ? Convert.ToInt32(row["N"]) : 0,
                Oferta = row["Oferta"] != DBNull.Value ? Convert.ToDecimal(row["Oferta"]) : 0,
                Compran = row["Compran"] != DBNull.Value ? Convert.ToInt32(row["Compran"]) : 0,
                Neto = row["Neto"] != DBNull.Value ? Convert.ToDecimal(row["Neto"]) : 0,
                Bruto = row["Bruto"] != DBNull.Value ? Convert.ToDecimal(row["Bruto"]) : 0,
                WR = row["WR"] != DBNull.Value ? Convert.ToDecimal(row["WR"]) : 0,
            };
        }
    }
}
