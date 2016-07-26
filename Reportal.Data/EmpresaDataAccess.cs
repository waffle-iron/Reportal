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
    public static class EmpresaDataAccess
    {
        public static Empresa Obtener(int RutEmpresas)
        {
            Parametro p = new Parametro("@RutEmpresa", RutEmpresas);
            return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ObtenerEmpresas", p, ConstructorEntidad);
        }
        public static List<Empresa> ListarEmpresa()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_ListarEmpresas", ConstructorEntidad);
        }
        private static Empresa ConstructorEntidad(DataRow row)
        {
            return new Empresa
            {
                Id = row["Rut"] != DBNull.Value ? Convert.ToInt32(row["Rut"]) : 0,
                NombreEmpresa = row["NombreEmpresa"] != DBNull.Value ? row["NombreEmpresa"].ToString() : string.Empty,
                HoldingEmpresa = row["Holding"] != DBNull.Value ? row["Holding"].ToString() : string.Empty,
                RubroEmpresa = row["RubroEmpresa"] != DBNull.Value ? row["RubroEmpresa"].ToString() : string.Empty,
                TipoEntidadEmpresa = row["TipoEntidad"] != DBNull.Value ? row["TipoEntidad"].ToString() : string.Empty,
                ClasificacionRiegoEmpresa = row["Clasificacion_Riesgo"] != DBNull.Value ? row["Clasificacion_Riesgo"].ToString() : string.Empty,
                ClasificacionComercial = row["Clasificacion_Comercial"] != DBNull.Value ? row["Clasificacion_Comercial"].ToString() : string.Empty,
                TotalAfiliados = row["Total_Afiliados"] != DBNull.Value ? Convert.ToInt32(row["Total_Afiliados"]) : 0,
                TotalAfiliadosCredito = row["Total_Afiliados_Creditos"] != DBNull.Value ? Convert.ToInt32(row["Total_Afiliados_Creditos"]) : 0,

            };
        }
    }
}
