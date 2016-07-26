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
    public class ResumenGlobalLicenciaDataAccess
    {


        public static DataTable ObtenerGraficoBarra(int RutEmpresas)
        {
            
            Parametro p = new Parametro("@rut", RutEmpresas);
            return DBHelper.InstanceReporteria.ObtenerDataTable("sp_ObtenerResumenGraficoLicencia", p);
        }


        private static ResumenGlobalLicencia ConstructorEntidad(DataRow row)
        {
            return new ResumenGlobalLicencia
            {

                LicenciaFInicio = row["Licencia_fInicio"] != DBNull.Value ? row["Licencia_fInicio"].ToString() : string.Empty,
                LicenciaFinicioAnio = row["Licencia_fInicio_Año"] != DBNull.Value ? row["Licencia_fInicio_Año"].ToString() : string.Empty,
                CantidadLicencia = row["cantidad"] != DBNull.Value ? Convert.ToInt32(row["cantidad"]) : 0,
                Porcentaje = row["porcentaje"] != DBNull.Value ? Convert.ToInt32(row["porcentaje"]) : 0,
                TotalEmpleado = row["cantidadEmpleado"] != DBNull.Value ? Convert.ToInt32(row["cantidadEmpleado"]) : 0,

            };
        }
    }
}

