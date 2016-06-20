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
                PeriodoEmpresa = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0
            };
        }
    }
}
