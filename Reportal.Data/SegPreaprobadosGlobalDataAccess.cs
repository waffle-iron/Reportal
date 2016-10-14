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
    public class SegPreaprobadosGlobalDataAccess
    {
        public static List<SegPreaprobadosGlobal> Listar(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarGlobal", p, FormaGlobal);
        }

        public static List<SegPreaprobadosGlobal> ListarBySegment(int Periodo)
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarBySegmento", FormaSegmento);
        }

        public static List<SegPreaprobadosGlobal> ListarByNomina(int Periodo)
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarByNomina", FormaNomina);
        }

        public static List<SegPreaprobadosFull> ListarByNominayPropension(int Periodo)
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarByNominaPropen", FormaNominaPropen);
        }

        public static List<SegPreaprobadosGlobal> ListarByCanales(int Periodo)
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarByCanales", FormaCanales);
        }

        public static List<SegPreaprobadosFull> ListarByCanalesPropension(int Periodo)
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarByCanalesPropension", FormaCanalesPropen);
        }

        #region Formas de salida
        private static SegPreaprobadosGlobal FormaGlobal(DataRow row)
        {
            return new SegPreaprobadosGlobal
            {
                //Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                //FechaEjecucion = row["FechaEjecucion"] != DBNull.Value ? Convert.ToInt32(row["FechaEjecucion"]) : 0,
                //Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                PropensionCompra = row["PrpensionCompra"] != DBNull.Value ? row["PrpensionCompra"].ToString() : string.Empty,
                N_Oferta = row["N_Oferta"] != DBNull.Value ? Convert.ToInt64(row["N_Oferta"]) : 0,
                Oferta = row["oferta"] != DBNull.Value ? Convert.ToInt64(row["oferta"]) : 0,
                Oferta_Promedio = row["ofertaPromedio"] != DBNull.Value ? Convert.ToInt64(row["ofertaPromedio"]) : 0,
                N_Compra = row["N_Compran"] != DBNull.Value ? Convert.ToInt64(row["N_Compran"]) : 0,
                Neto = row["Neto"] != DBNull.Value ? Convert.ToInt64(row["Neto"]) : 0,
                Neto_Promedio = row["NetoPromedio"] != DBNull.Value ? Convert.ToInt64(row["NetoPromedio"]) : 0,
                Bruto = row["bruto"] != DBNull.Value ? Convert.ToInt64(row["bruto"]) : 0,
                WR = (row["N_Compran"] != DBNull.Value ? Convert.ToInt64(row["N_Compran"]) : 0) / (row["N_Oferta"] != DBNull.Value ? Convert.ToInt64(row["N_Oferta"]) : 0)
            };
        }

        private static SegPreaprobadosGlobal FormaSegmento(DataRow row)
        {
            return new SegPreaprobadosGlobal
            {
                Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                PropensionCompra = row["PrpensionCompra"] != DBNull.Value ? row["PrpensionCompra"].ToString() : string.Empty,
                N_Oferta = row["N_Oferta"] != DBNull.Value ? Convert.ToInt64(row["N_Oferta"]) : 0,
                Oferta = row["oferta"] != DBNull.Value ? Convert.ToInt64(row["oferta"]) : 0,
                Oferta_Promedio = row["ofertaPromedio"] != DBNull.Value ? Convert.ToInt64(row["ofertaPromedio"]) : 0,
                N_Compra = row["N_Compran"] != DBNull.Value ? Convert.ToInt64(row["N_Compran"]) : 0,
                Neto = row["Neto"] != DBNull.Value ? Convert.ToInt64(row["Neto"]) : 0,
                Neto_Promedio = row["NetoPromedio"] != DBNull.Value ? Convert.ToInt64(row["NetoPromedio"]) : 0,
                Bruto = row["bruto"] != DBNull.Value ? Convert.ToInt64(row["bruto"]) : 0,
                WR = (row["N_Compran"] != DBNull.Value ? Convert.ToInt64(row["N_Compran"]) : 0) / (row["N_Oferta"] != DBNull.Value ? Convert.ToInt64(row["N_Oferta"]) : 0)
            };
        }

        private static SegPreaprobadosGlobal FormaNomina(DataRow row)
        {
            return new SegPreaprobadosGlobal
            {
                Nomina = row["Nomina_Titulo"] != DBNull.Value ? row["Nomina_Titulo"].ToString() : string.Empty,
                //Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                //PropensionCompra = row["PrpensionCompra"] != DBNull.Value ? row["PrpensionCompra"].ToString() : string.Empty,
                N_Oferta = row["N_Oferta"] != DBNull.Value ? Convert.ToDecimal(row["N_Oferta"]) : 0,
                Oferta = row["oferta"] != DBNull.Value ? Convert.ToDecimal(row["oferta"]) : 0,
                Oferta_Promedio = row["ofertaPromedio"] != DBNull.Value ? Convert.ToDecimal(row["ofertaPromedio"]) : 0,
                N_Compra = row["N_Compran"] != DBNull.Value ? Convert.ToDecimal(row["N_Compran"]) : 0,
                Neto = row["Neto"] != DBNull.Value ? Convert.ToDecimal(row["Neto"]) : 0,
                Neto_Promedio = row["NetoPromedio"] != DBNull.Value ? Convert.ToDecimal(row["NetoPromedio"]) : 0,
                Bruto = row["bruto"] != DBNull.Value ? Convert.ToDecimal(row["bruto"]) : 0,
                WR = (row["N_Compran"] != DBNull.Value ? Convert.ToDecimal(row["N_Compran"]) : 0) / (row["N_Oferta"] != DBNull.Value ? Convert.ToDecimal(row["N_Oferta"]) : 0)
            };
        }

        private static SegPreaprobadosFull FormaNominaPropen(DataRow row)
        {
            return new SegPreaprobadosFull
            {
                Nomina = row["Nomina"] != DBNull.Value ? row["Nomina"].ToString() : string.Empty,
                N_Baja = row["N_Baja"] != DBNull.Value ? Convert.ToDecimal(row["N_Baja"]) : 0,
                Neto_Baja = row["Neto_Baja"] != DBNull.Value ? Convert.ToDecimal(row["Neto_Baja"]) : 0,
                WR_Baja = row["WR_Baja"] != DBNull.Value ? Convert.ToDecimal(row["WR_Baja"]) : 0,
                N_Media = row["N_Media"] != DBNull.Value ? Convert.ToDecimal(row["N_Media"]) : 0,
                Neto_Media = row["Neto_Media"] != DBNull.Value ? Convert.ToDecimal(row["Neto_Media"]) : 0,
                WR_Media = row["WR_Media"] != DBNull.Value ? Convert.ToDecimal(row["WR_Media"]) : 0,
                N_Alta = row["N_Alta"] != DBNull.Value ? Convert.ToDecimal(row["N_Alta"]) : 0,
                Neto_Alta = row["Neto_Alta"] != DBNull.Value ? Convert.ToDecimal(row["Neto_Alta"]) : 0,
                WR_Alta = row["WR_Alta"] != DBNull.Value ? Convert.ToDecimal(row["WR_Alta"]) : 0,
                N_Total = row["N_Total"] != DBNull.Value ? Convert.ToDecimal(row["N_Total"]) : 0,
                Neto_Total = row["Neto_Total"] != DBNull.Value ? Convert.ToDecimal(row["Neto_Total"]) : 0,
                WR_Total = row["WR_Total"] != DBNull.Value ? Convert.ToDecimal(row["WR_Total"]) : 0,
            };
        }

        private static SegPreaprobadosGlobal FormaCanales(DataRow row)
        {
            return new SegPreaprobadosGlobal
            {
                Canal = row["Canal"] != DBNull.Value ? row["Canal"].ToString() : string.Empty,
                N_Oferta = row["N_Oferta"] != DBNull.Value ? Convert.ToDecimal(row["N_Oferta"]) : 0,
                Oferta = row["Oferta"] != DBNull.Value ? Convert.ToDecimal(row["Oferta"]) : 0,
                N_Compra = row["N_Compra"] != DBNull.Value ? Convert.ToDecimal(row["N_Compra"]) : 0,
                Neto = row["Neto"] != DBNull.Value ? Convert.ToDecimal(row["Neto"]) : 0,
                Bruto = row["Bruto"] != DBNull.Value ? Convert.ToDecimal(row["Bruto"]) : 0,
                WR = row["WR"] != DBNull.Value ? Convert.ToDecimal(row["WR"]) : 0
            };
        }



        private static SegPreaprobadosFull FormaCanalesPropen(DataRow row)
        {
            return new SegPreaprobadosFull
            {
                Nomina = row["Canal"] != DBNull.Value ? row["Canal"].ToString() : string.Empty,
                N_Baja = row["N_Baja"] != DBNull.Value ? Convert.ToDecimal(row["N_Baja"]) : 0,
                
                WR_Baja = row["WR_Baja"] != DBNull.Value ? Convert.ToDecimal(row["WR_Baja"]) : 0,
                N_Media = row["N_Media"] != DBNull.Value ? Convert.ToDecimal(row["N_Media"]) : 0,
                
                WR_Media = row["WR_Media"] != DBNull.Value ? Convert.ToDecimal(row["WR_Media"]) : 0,
                N_Alta = row["N_Alta"] != DBNull.Value ? Convert.ToDecimal(row["N_Alta"]) : 0,
                
                WR_Alta = row["WR_Alta"] != DBNull.Value ? Convert.ToDecimal(row["WR_Alta"]) : 0,
                N_Total = row["N_Total"] != DBNull.Value ? Convert.ToDecimal(row["N_Total"]) : 0,
                
                WR_Total = row["WR_Total"] != DBNull.Value ? Convert.ToDecimal(row["WR_Total"]) : 0,
            };
        }

        #endregion
    }
}
