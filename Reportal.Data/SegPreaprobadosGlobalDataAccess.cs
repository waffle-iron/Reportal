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
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarBySegmento", p, FormaSegmento);
        }

        public static List<SegPreaprobadosGlobal> ListarByNomina(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarByNomina", p, FormaNomina);
        }

        public static List<SegPreaprobadosFull> ListarByNominayPropension(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarByNominaPropen", p, FormaNominaPropen);
        }

        public static List<SegPreaprobadosGlobal> ListarByCanales(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarByCanales", p, FormaCanales);
        }

        public static List<SegPreaprobadosFull> ListarByCanalesPropension(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarByCanalesPropension", p, FormaCanalesPropen);
        }

        public static List<TotalesUniverso> ListarTotalesUniverso(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarTotalesUniverso", p, FormaTotalesUniverso);
        }

        public static List<UniversoCampagnado> ListarUniversoCampagnado(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarUniversoCampagnado", p, FormaUniversoCampagnado);
        }

        public static List<UniversoGestionable> ListarUniversoGestionable(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarUniversoGestionable", p, FormaUniversoGestionable);
        }

        public static List<UniversoCampagnadoPropension> ListarUniversoCampagnadoPropension(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarUniversoCampagnadoPropension", p, FormaUniversoCampagnadoPropension);
        }

        public static List<UniversoGestionablePropension> ListarUniversoGestionablePropension(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_SegPreaprobados_ListarUniversoGestionablePropension", p, FormaUniversoGestionablePropension);
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
                N_Oferta = row["N_Oferta"] != DBNull.Value ? Convert.ToDecimal(row["N_Oferta"]) : 0,
                Oferta = row["oferta"] != DBNull.Value ? Convert.ToDecimal(row["oferta"]) : 0,
                Oferta_Promedio = row["ofertaPromedio"] != DBNull.Value ? Convert.ToDecimal(row["ofertaPromedio"]) : 0,
                N_Compra = row["N_Compran"] != DBNull.Value ? Convert.ToDecimal(row["N_Compran"]) : 0,
                Neto = row["Neto"] != DBNull.Value ? Convert.ToDecimal(row["Neto"]) : 0,
                Neto_Promedio = row["NetoPromedio"] != DBNull.Value ? Convert.ToDecimal(row["NetoPromedio"]) : 0,
                Bruto = row["bruto"] != DBNull.Value ? Convert.ToDecimal(row["bruto"]) : 0,
                WR = row["WR"] != DBNull.Value ? Convert.ToDecimal(row["WR"]) : 0
            };
        }

        private static SegPreaprobadosGlobal FormaSegmento(DataRow row)
        {
            return new SegPreaprobadosGlobal
            {
                Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                PropensionCompra = row["PrpensionCompra"] != DBNull.Value ? row["PrpensionCompra"].ToString() : string.Empty,
                N_Oferta = row["N_Oferta"] != DBNull.Value ? Convert.ToDecimal(row["N_Oferta"]) : 0,
                Oferta = row["oferta"] != DBNull.Value ? Convert.ToDecimal(row["oferta"]) : 0,
                Oferta_Promedio = row["ofertaPromedio"] != DBNull.Value ? Convert.ToDecimal(row["ofertaPromedio"]) : 0,
                N_Compra = row["N_Compran"] != DBNull.Value ? Convert.ToDecimal(row["N_Compran"]) : 0,
                Neto = row["Neto"] != DBNull.Value ? Convert.ToDecimal(row["Neto"]) : 0,
                Neto_Promedio = row["NetoPromedio"] != DBNull.Value ? Convert.ToDecimal(row["NetoPromedio"]) : 0,
                Bruto = row["bruto"] != DBNull.Value ? Convert.ToDecimal(row["bruto"]) : 0,
                WR = row["WR"] != DBNull.Value ? Convert.ToDecimal(row["WR"]) : 0
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
                WR = row["WR"] != DBNull.Value ? Convert.ToDecimal(row["WR"]) : 0
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

        private static TotalesUniverso FormaTotalesUniverso(DataRow row)
        {
            return new TotalesUniverso
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Item = row["Item"] != DBNull.Value ? row["Item"].ToString() : string.Empty,
                N_Total = row["N_Total"] != DBNull.Value ? Convert.ToInt32(row["N_Total"]) : 0,
                P_Total = row["P_Total"] != DBNull.Value ? Convert.ToInt32(row["P_Total"]) : 0,
                N_Pensionados = row["N_Pensionados"] != DBNull.Value ? Convert.ToInt32(row["N_Pensionados"]) : 0,
                P_Pensionados = row["P_Pensionados"] != DBNull.Value ? Convert.ToInt32(row["P_Pensionados"]) : 0,
                N_Trabajadores = row["N_Trabajadores"] != DBNull.Value ? Convert.ToInt32(row["N_Trabajadores"]) : 0,
                P_Trabajadores = row["P_Trabajadores"] != DBNull.Value ? Convert.ToInt32(row["P_Trabajadores"]) : 0,
            };
        }

        private static UniversoCampagnado FormaUniversoCampagnado(DataRow row)
        {
            return new UniversoCampagnado
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                N_Total = row["N_Total"] != DBNull.Value ? Convert.ToInt32(row["N_Total"]) : 0,
                P_Total = row["P_Total"] != DBNull.Value ? Convert.ToInt32(row["P_Total"]) : 0,
                N_Call = row["N_Call"] != DBNull.Value ? Convert.ToInt32(row["N_Call"]) : 0,
                P_Call = row["P_Call"] != DBNull.Value ? Convert.ToInt32(row["P_Call"]) : 0,
                N_Email = row["N_Email"] != DBNull.Value ? Convert.ToInt32(row["N_Email"]) : 0,
                P_Email = row["P_Email"] != DBNull.Value ? Convert.ToInt32(row["P_Email"]) : 0,
                N_SMS = row["N_SMS"] != DBNull.Value ? Convert.ToInt32(row["N_SMS"]) : 0,
                P_SMS = row["P_SMS"] != DBNull.Value ? Convert.ToInt32(row["P_SMS"]) : 0,
            };
        }

        private static UniversoGestionable FormaUniversoGestionable(DataRow row)
        {
            return new UniversoGestionable
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                N_Afiliados = row["N_Afiliados"] != DBNull.Value ? Convert.ToInt32(row["N_Afiliados"]) : 0,
                N_Celular = row["N_Celular"] != DBNull.Value ? Convert.ToInt32(row["N_Celular"]) : 0,
                P_Celular = row["P_Celular"] != DBNull.Value ? Convert.ToInt32(row["P_Celular"]) : 0,
                N_CelularOFijo = row["N_CelularOFijo"] != DBNull.Value ? Convert.ToInt32(row["N_CelularOFijo"]) : 0,
                P_CelularOFijo = row["P_CelularOFijo"] != DBNull.Value ? Convert.ToInt32(row["P_CelularOFijo"]) : 0,
                N_Email = row["N_Email"] != DBNull.Value ? Convert.ToInt32(row["N_Email"]) : 0,
                P_Email = row["P_Email"] != DBNull.Value ? Convert.ToInt32(row["P_Email"]) : 0,
                N_EmailOFonos = row["N_EmailOFonos"] != DBNull.Value ? Convert.ToInt32(row["N_EmailOFonos"]) : 0,
                P_EmailOFonos = row["P_EmailOFonos"] != DBNull.Value ? Convert.ToInt32(row["P_EmailOFonos"]) : 0,
            };
        }

        private static UniversoCampagnadoPropension FormaUniversoCampagnadoPropension(DataRow row)
        {
            return new UniversoCampagnadoPropension
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                SegmentoCompra = row["SegmentoCompra"] != DBNull.Value ? row["SegmentoCompra"].ToString() : string.Empty,
                N_Total = row["N_Total"] != DBNull.Value ? Convert.ToInt32(row["N_Total"]) : 0,
                P_Total = row["P_Total"] != DBNull.Value ? Convert.ToInt32(row["P_Total"]) : 0,
                N_Call = row["N_Call"] != DBNull.Value ? Convert.ToInt32(row["N_Call"]) : 0,
                P_Call = row["P_Call"] != DBNull.Value ? Convert.ToInt32(row["P_Call"]) : 0,
                N_Email = row["N_Email"] != DBNull.Value ? Convert.ToInt32(row["N_Email"]) : 0,
                P_Email = row["P_Email"] != DBNull.Value ? Convert.ToInt32(row["P_Email"]) : 0,
                N_SMS = row["N_SMS"] != DBNull.Value ? Convert.ToInt32(row["N_SMS"]) : 0,
                P_SMS = row["P_SMS"] != DBNull.Value ? Convert.ToInt32(row["P_SMS"]) : 0,
            };
        }

        private static UniversoGestionablePropension FormaUniversoGestionablePropension(DataRow row)
        {
            return new UniversoGestionablePropension
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                SegmentoCompra = row["SegmentoCompra"] != DBNull.Value ? row["SegmentoCompra"].ToString() : string.Empty,
                N_Afiliados = row["N_Afiliados"] != DBNull.Value ? Convert.ToInt32(row["N_Afiliados"]) : 0,
                N_Celular = row["N_Celular"] != DBNull.Value ? Convert.ToInt32(row["N_Celular"]) : 0,
                P_Celular = row["P_Celular"] != DBNull.Value ? Convert.ToInt32(row["P_Celular"]) : 0,
                N_Fonos = row["N_Fonos"] != DBNull.Value ? Convert.ToInt32(row["N_Fonos"]) : 0,
                P_Fonos = row["P_Fonos"] != DBNull.Value ? Convert.ToInt32(row["P_Fonos"]) : 0,
                N_Email = row["N_Email"] != DBNull.Value ? Convert.ToInt32(row["N_Email"]) : 0,
                P_Email = row["P_Email"] != DBNull.Value ? Convert.ToInt32(row["P_Email"]) : 0,
                N_Alguno = row["N_Alguno"] != DBNull.Value ? Convert.ToInt32(row["N_Alguno"]) : 0,
                P_Alguno = row["P_Alguno"] != DBNull.Value ? Convert.ToInt32(row["P_Alguno"]) : 0,
            };
        }


        #endregion
    }
}
