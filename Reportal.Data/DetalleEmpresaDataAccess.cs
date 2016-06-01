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
    public static class DetalleEmpresaDataAccess
    {
        public static IdentidadDetalleEmpresa Obtener(int rutEmpresa)
        {
            Parametro p = new Parametro("@RutEmpresa", rutEmpresa);
            //return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ObtenerDetalleCampania", p, ConstructorEntidad);
            return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ListarCicloVidaEmpresa", p, ConstructorEntidad);
        }
        private static IdentidadDetalleEmpresa ConstructorEntidad(DataRow row)
        {
            return new IdentidadDetalleEmpresa
            {
                RutEmpresa = row["RutEmpresa"] != DBNull.Value ? Convert.ToInt32(row["RutEmpresa"]) : 0,
                CVAdultoMayor = row["Adulto Mayor"] != DBNull.Value ? Convert.ToInt32(row["Adulto Mayor"]) : 0,
                CVAdulto = row["Adultos"] != DBNull.Value ? Convert.ToInt32(row["Adultos"]) : 0,
                CVDesarrollo = row["Desarrollo"] != DBNull.Value ? Convert.ToInt32(row["Desarrollo"]) : 0,
                CVJovenes = row["Jovenes"] != DBNull.Value ? Convert.ToInt32(row["Jovenes"]) : 0,
                CVMadurez = row["Madurez"] != DBNull.Value ? Convert.ToInt32(row["Madurez"]) : 0,

            };
        }
    }
}
