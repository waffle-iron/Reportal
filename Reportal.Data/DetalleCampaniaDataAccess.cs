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
                TotalPensionadosCampanados = row["TotalPensionadosCampanados"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosCampanados"]) : 0,
                TotalPensionadosExitosas = row["TotalPensionadosExitosas"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosExitosas"]) : 0,
                TotalTrabajadoresCampanados = row["TotalTrabajadoresCampanados"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresCampanados"]) : 0,
                TotalTrabajadoresExitosas = row["TotalTrabajadoresExitosas"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresExitosas"]) : 0,
                TotalPensionadosCampanadosCall = row["TotalPensionadosCampanadosCall"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosCampanadosCall"]) : 0,
                TotalPensionadosCampanadosEmail = row["TotalPensionadosCampanadosEmail"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosCampanadosEmail"]) : 0,
                TotalPensionadosCampanadosSms = row["TotalPensionadosCampanadosSms"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosCampanadosSms"]) : 0,
                TotalTrabajadoresCampanadosCall = row["TotalTrabajadoresCampanadosCall"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresCampanadosCall"]) : 0,
                TotalTrabajadoresCampanadosEmail = row["TotalTrabajadoresCampanadosEmail"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresCampanadosEmail"]) : 0,
                TotalTrabajadoresCampanadosSms = row["TotalTrabajadoresCampanadosSms"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresCampanadosSms"]) : 0,
                TotalPensionadosExitosasCall = row["TotalPensionadosExitosasCall"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosExitosasCall"]) : 0,
                TotalPensionadosExitosasEmail = row["TotalPensionadosExitosasEmail"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosExitosasEmail"]) : 0,
                TotalPensionadosExitosasSms = row["TotalPensionadosExitosasSms"] != DBNull.Value ? Convert.ToInt32(row["TotalPensionadosExitosasSms"]) : 0,
                TotalTrabajadoresExitosasCall = row["TotalTrabajadoresExitosasCall"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresExitosasCall"]) : 0,
                TotalTrabajadoresExitosasEmail = row["TotalTrabajadoresExitosasEmail"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresExitosasEmail"]) : 0,
                TotalTrabajadoresExitosasSms = row["TotalTrabajadoresExitosasSms"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajadoresExitosasSms"]) : 0,

                TotalVentas = row["TotalVentas"] != DBNull.Value ? Convert.ToInt32(row["TotalVentas"]) : 0,
                TotalVentasPensionadosSMS = row["TotalVentasPensionadosSMS"] != DBNull.Value ? Convert.ToInt32(row["TotalVentasPensionadosSMS"]) : 0,
                TotalVentasTrabajadoresSMS = row["TotalVentasTrabajadoresSMS"] != DBNull.Value ? Convert.ToInt32(row["TotalVentasTrabajadoresSMS"]) : 0,
                TotalVentasPensionadosEmail = row["TotalVentasPensionadosEmail"] != DBNull.Value ? Convert.ToInt32(row["TotalVentasPensionadosEmail"]) : 0,
                TotalVentasTrabajadoresEmail = row["TotalVentasTrabajadoresEmail"] != DBNull.Value ? Convert.ToInt32(row["TotalVentasTrabajadoresEmail"]) : 0,
                TotalVentasPensionados = row["TotalVentasPensionados"] != DBNull.Value ? Convert.ToInt32(row["TotalVentasPensionados"]) : 0,
                TotalVentasTrabajadores = row["TotalVentasTrabajadores"] != DBNull.Value ? Convert.ToInt32(row["TotalVentasTrabajadores"]) : 0,
                TotalVentasPensionadosCall = row["TotalVentasPensionadosCall"] != DBNull.Value ? Convert.ToInt32(row["TotalVentasPensionadosCall"]) : 0,
                TotalVentasTrabajadoreaCall = row["TotalVentasTrabajadoreaCall"] != DBNull.Value ? Convert.ToInt32(row["TotalVentasTrabajadoreaCall"]) : 0,

            };
        }
        #endregion

    }
}
