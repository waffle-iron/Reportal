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
                RutEmpresa = row["Empresa_Rut"] != DBNull.Value ? Convert.ToInt32(row["Empresa_Rut"]) : 0,
                DVEmpresa = row["Empresa_Dv"] != DBNull.Value ? row["Empresa_Dv"].ToString() : string.Empty,
                NombreEmpresa = row["EmpresaNombre"] != DBNull.Value ? row["EmpresaNombre"].ToString() : string.Empty,
                SegmentoEmpresa = row["SegmentoEmpresa"] != DBNull.Value ? row["SegmentoEmpresa"].ToString() : string.Empty,
                RiesgoEmpresa = row["ClaRiesgoEmpresa"] != DBNull.Value ? row["ClaRiesgoEmpresa"].ToString() : string.Empty,
                CComercialEmpresa = row["ClaComercialEmpresa"] != DBNull.Value ? row["ClaComercialEmpresa"].ToString() : string.Empty,
                EmpresaNSE = row["EmpresaNSE"] != DBNull.Value ? row["EmpresaNSE"].ToString() : string.Empty,

            };
        }
    }
}
