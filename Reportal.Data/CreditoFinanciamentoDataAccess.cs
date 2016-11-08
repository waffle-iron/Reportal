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
    public static class CreditoFinanciamentoDataAccess
    {
        public static List<Cred_Financiamento> Listar(int Periodo)
        {
            Parametros pp = new Parametros
            {
                new Parametro("@Periodo",Periodo)
               // new Parametro("@segmento",iSegmento)
            };


            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Directorio_Cred_FinanciamientoListar", pp, ConstructorEntidad);
        }


        public static List<Cred_Financiamento> ListarByTodos()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Directorio_Cred_FinanciamientoListarTodo",  FinanciamentoTodos);
        }

        private static Cred_Financiamento ConstructorEntidad(DataRow row)
        {
            return new Cred_Financiamento
            {
                periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                //fechaEjecucion = row["FECHA_EJECUCION"] != DBNull.Value ? Convert.ToInt32(row["FECHA_EJECUCION"]) : 0,
                iSegmento = row["iSegmento"] != DBNull.Value ? Convert.ToInt32(row["iSegmento"]) : 0,
               // segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                fecha = row["Fecha"] != DBNull.Value ? row["Fecha"].ToString() : string.Empty,
                diaGrafico= row["DiaGrafico"] != DBNull.Value ? row["DiaGrafico"].ToString() : string.Empty,
                tasaPromedio   = row["TasaPromedio"] != DBNull.Value ? Convert.ToSingle(row["TasaPromedio"]) : 0,
                sPread= row["Spread"] != DBNull.Value ? Convert.ToSingle(row["Spread"]) : 0,
                plazoPromedio = row["Plazo_Promedio"] != DBNull.Value ? Convert.ToInt32(row["Plazo_Promedio"]) : 0
            };
        }

        private static Cred_Financiamento FinanciamentoTodos(DataRow row)
        {
            return new Cred_Financiamento
            {
                periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                fechaEjecucion = row["Fecha_ejecucion"] != DBNull.Value ? Convert.ToInt32(row["Fecha_ejecucion"]) : 0,
                diaGrafico = row["Mes"] != DBNull.Value ? row["Mes"].ToString() : string.Empty,
                iSegmento = row["iSegmento"] != DBNull.Value ? Convert.ToInt32(row["iSegmento"]) : 0,
                segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                tasaPromedio = row["TasaPromedio"] != DBNull.Value ? Convert.ToSingle(row["TasaPromedio"]) : 0,
                sPread = row["Spread"] != DBNull.Value ? Convert.ToSingle(row["Spread"]) : 0,
                plazoPromedio = row["Plazo_Promedio"] != DBNull.Value ? Convert.ToInt32(row["Plazo_Promedio"]) : 0
            };
        }

    }
}
