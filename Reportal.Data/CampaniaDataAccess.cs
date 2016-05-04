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
    public static class CampaniaDataAccess
    {
        public static Campania Obtener(int idCampania)
        {
            Parametro p = new Parametro("@IdCampania", idCampania);
            return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ObtenerCampania", p, ConstructorEntidad);
        }

        public static List<Campania> Listar()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_ListarCampanias", ConstructorEntidad);
        }

        #region constructor
        private static Campania ConstructorEntidad(DataRow row)
        {
            return new Campania
            {
                Id = row["cmp_id"] != DBNull.Value ? Convert.ToInt32(row["cmp_id"]) : 0,
                Nombre = row["cmp_nombre"] != DBNull.Value ? row["cmp_nombre"].ToString() : string.Empty,
                CanalEmail = row["cmp_canal_mail"] != DBNull.Value ? Convert.ToBoolean(row["cmp_canal_mail"]) : false,
                CanalLlamada = row["cmp_canal_call"] != DBNull.Value ? Convert.ToBoolean(row["cmp_canal_call"]) : false,
                CanalSMS = row["cmp_canal_sms"] != DBNull.Value ? Convert.ToBoolean(row["cmp_canal_sms"]) : false,
                CantidadNomina = row["cmp_cant_nomina"] != DBNull.Value ? Convert.ToInt32(row["cmp_cant_nomina"]) : 0,
                Concepto = row["cmp_concepto"] != DBNull.Value ? row["cmp_concepto"].ToString() : string.Empty,
                SubConcepto = row["cmp_sub_concepto"] != DBNull.Value ? row["cmp_sub_concepto"].ToString() : string.Empty,
                Observacion = row["cmp_observacion"] != DBNull.Value ? row["cmp_observacion"].ToString() : string.Empty,
                FechaInicio = row["cmp_fecha_inicio"] != DBNull.Value ? Convert.ToDateTime(row["cmp_fecha_inicio"]) : DateTime.MinValue,
                FechaTermino = row["cmp_fecha_termino"] != DBNull.Value ? Convert.ToDateTime(row["cmp_fecha_termino"]) : DateTime.MinValue,

            };
        }
        #endregion

    }
}
