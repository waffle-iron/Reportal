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
    public static class BenchmarkDataAccess
    {
        public static List<Benchmark> Obtener(int Periodo, string Item)
        {
            Parametros pram = new Parametros
            {
                new Parametro("@Periodo", Periodo),
                new Parametro("@Item",Item),
            };
           
            return DBHelper.InstanceSecurity.ObtenerColeccion("sp_Reportal_Obtener_BenchMark", pram, ConstructorEntidad);
        }
        
        private static Benchmark ConstructorEntidad(DataRow row)
        {
            return new Benchmark
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Item = row["Item"] != DBNull.Value ? row["Item"].ToString() : string.Empty,
                OrdenVisual = row["OrdenVisual"] != DBNull.Value ? Convert.ToInt32(row["OrdenVisual"]) : 0,
                Caja = row["Caja"] != DBNull.Value ? row["Caja"].ToString() : string.Empty,
                ValorTasa = row["ValorTasa"] != DBNull.Value ? Convert.ToSingle(row["ValorTasa"]) : 0,
            };
        }
    }
}