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
    public static class ResumenGlobalDataAccess
    {
        public static ResumenGlobal Obtener()
        {
            return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ObtenerResumenes", ConstructorEntidad);
        }

        public static List<ResumenGlobal> Listar()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_ListarResumenes", ConstructorEntidad);
        }

        public static DataTable ObtenerGraficoBarra()
        {
            return DBHelper.InstanceReporteria.ObtenerDataTable("sp_ResumeneGraficoBarras");
        }


        #region constructor
        private static ResumenGlobal ConstructorEntidad(DataRow row)
        {
            return new ResumenGlobal
            {
                AfiliadosCallPrivados = row["AfiliadosCallPrivados"] != DBNull.Value ? Convert.ToInt32(row["AfiliadosCallPrivados"]) : 0,
                AfiliadosCallPublicos = row["AfiliadosCallPublicos"] != DBNull.Value ? Convert.ToInt32(row["AfiliadosCallPublicos"]) : 0,
                AfiliadosCallPensionados = row["AfiliadosCallPensionados"] != DBNull.Value ? Convert.ToInt32(row["AfiliadosCallPensionados"]) : 0,
                AfiliadosCorreoPensionados = row["AfiliadosCorreoPensionados"] != DBNull.Value ? Convert.ToInt32(row["AfiliadosCorreoPensionados"]) : 0,
                AfiliadosCorreoPrivados = row["AfiliadosCorreoPrivados"] != DBNull.Value ? Convert.ToInt32(row["AfiliadosCorreoPrivados"]) : 0,
                AfiliadosCorreoPublicos = row["AfiliadosCorreoPublicos"] != DBNull.Value ? Convert.ToInt32(row["AfiliadosCorreoPublicos"]) : 0,
                AfiliadosSMSPensionados = row["AfiliadosSMSPensionados"] != DBNull.Value ? Convert.ToInt32(row["AfiliadosSMSPensionados"]) : 0,
                AfiliadosSMSPrivados = row["AfiliadosSMSPrivados"] != DBNull.Value ? Convert.ToInt32(row["AfiliadosSMSPrivados"]) : 0,
                AfiliadosSMSPublicos = row["AfiliadosSMSPublicos"] != DBNull.Value ? Convert.ToInt32(row["AfiliadosSMSPublicos"]) : 0,
                TotalAfiliados = row["TotalAfiliados"] != DBNull.Value ? Convert.ToInt32(row["TotalAfiliados"]) : 0,
                TotalAfiliadosCall = row["TotalAfiliadosCall"] != DBNull.Value ? Convert.ToInt32(row["TotalAfiliadosCall"]) : 0,
                TotalAfiliadosContactables = row["TotalAfiliadosContactables"] != DBNull.Value ? Convert.ToInt32(row["TotalAfiliadosContactables"]) : 0,
                TotalAfiliadosCorreo = row["TotalAfiliadosCorreo"] != DBNull.Value ? Convert.ToInt32(row["TotalAfiliadosCorreo"]) : 0,
                TotalAfiliadosSMS = row["TotalAfiliadosSMS"] != DBNull.Value ? Convert.ToInt32(row["TotalAfiliadosSMS"]) : 0,
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,

            };
        }
        #endregion

    }
}
