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
    public static class DetalleCampaniaDataAccess
    {
        public static IdentidadDetalleCampania Obtener(int idCampania)
        {
            Parametro p = new Parametro("@IdCampania", idCampania);
            return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ObtenerDetalleCampania", p, ConstructorEntidad);
        }


        #region constructor
        private static IdentidadDetalleCampania ConstructorEntidad(DataRow row)
        {
            return new IdentidadDetalleCampania
            {
                Id = row["IdCampania"] != DBNull.Value ? Convert.ToInt32(row["IdCampania"]) : 0,
                TotalAFiliadosCampanados = row["TotalAFiliadosCampanados"] != DBNull.Value ? Convert.ToInt32(row["TotalAFiliadosCampanados"]) : 0,
                TotalAFiliadosContactados = row["TotalAFiliadosContactados"] != DBNull.Value ? Convert.ToInt32(row["TotalAFiliadosContactados"]) : 0,
                TotalPrivadosContactados = row["TotalPrivadosContactados"] != DBNull.Value ? Convert.ToInt32(row["TotalPrivadosContactados"]) : 0,
                TotalPrivadosContactadosSms = row["TotalPrivadosContactadosSms"] != DBNull.Value ? Convert.ToInt32(row["TotalPrivadosContactadosSms"]) : 0,
                TotalPrivadosContactadosEmail = row["TotalPrivadosContactadosEmail"] != DBNull.Value ? Convert.ToInt32(row["TotalPrivadosContactadosEmail"]) : 0,
                TotalPrivadosContactadosCall = row["TotalPrivadosContactadosCall"] != DBNull.Value ? Convert.ToInt32(row["TotalPrivadosContactadosCall"]) : 0,
                TotalPublicosContactados = row["TotalPublicosContactados"] != DBNull.Value ? Convert.ToInt32(row["TotalPublicosContactados"]) : 0,
                TotalPublicosContactadosSms = row["TotalPublicosContactadosSms"] != DBNull.Value ? Convert.ToInt32(row["TotalPublicosContactadosSms"]) : 0,
                TotalPublicosContactadosEmail = row["TotalPublicosContactadosEmail"] != DBNull.Value ? Convert.ToInt32(row["TotalPublicosContactadosEmail"]) : 0,
                TotalPublicosContactadosCall = row["TotalPublicosContactadosCall"] != DBNull.Value ? Convert.ToInt32(row["TotalPublicosContactadosCall"]) : 0,
                TotalPensionadosContactados = row["TotalPensionadosContactados"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosContactados"]) : 0,
                TotalPensionadosContactadosEmail = row["TotalPensionadosContactadosEmail"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosContactadosEmail"]) : 0,
                TotalPensionadosContactadosSms = row["TotalPensionadosContactadosSms"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosContactadosSms"]) : 0,
                TotalPensionadosContactadosCall = row["TotalPensionadosContactadosCall"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosContactadosCall"]) : 0,
                TotalComunicacionesExitosas = row["TotalComunicacionesExitosas"] != DBNull.Value ? Convert.ToInt32(row["TotalComunicacionesExitosas"]) : 0,
                TotalTrabajadoresContactados = row["TotalTrabajadoresContactados"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresContactados"]) : 0,
                TotalTrabajadoresContactadosCall = row["TotalTrabajadoresContactadosCall"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresContactadosCall"]) : 0,
                TotalTrabajadoresContactadosEmail = row["TotalTrabajadoresContactadosEmail"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresContactadosEmail"]) : 0,
                TotalTrabajadoresContactadosSms = row["TotalTrabajadoresContactadosSms"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresContactadosSms"]) : 0,
            };
        }
        #endregion

    }
}
