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
    public static class IndRiesgoCreditoDataAccess
    {
        public static List<IndRiesgoCredito> Obtener(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_IndCredito_ObtenerRiesgoCredito", p, ConstructorEntidad);
        }

        public static List<IndRiesgoCredito> Listar()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_IndCredito_ListarRiesgoCredito", ConstructorEntidad);
        }

        public static List<int> ObtenerPeriodos()
        {
            return Listar().Select(s => s.Periodo).Distinct().ToList();
        }

        private static IndRiesgoCredito ConstructorEntidad(DataRow row)
        {
            return new IndRiesgoCredito
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Item = row["Item"] != DBNull.Value ? row["Item"].ToString() : string.Empty,
                Orden = row["Orden"] != DBNull.Value ? Convert.ToInt32(row["Orden"]) : 0,
                Operaciones = row["Operaciones"] != DBNull.Value ? Convert.ToSingle(row["Operaciones"]) : 0,
                CapitalEfectivoMM = row["CapitalEfectivoMM"] != DBNull.Value ? Convert.ToSingle(row["CapitalEfectivoMM"]) : 0,
                DistribucionCapital = row["DistribucionCapital"] != DBNull.Value ? Convert.ToSingle(row["DistribucionCapital"]) : 0,
            };
        }
    }
}