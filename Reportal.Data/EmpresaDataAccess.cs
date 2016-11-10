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
                Id = row["Empresa_Rut"] != DBNull.Value ? Convert.ToInt32(row["Empresa_Rut"]) : 0,
                Dv = row["Empresa_Dv"] != DBNull.Value ? row["Empresa_Dv"].ToString() : string.Empty,
                NombreEmpresa = row["EmpresaNombre"] != DBNull.Value ? row["EmpresaNombre"].ToString() : string.Empty,
                HoldingEmpresa = row["Holding"] != DBNull.Value ? row["Holding"].ToString() : string.Empty,
                SectorEcoEmpresa = row["SectorEconomico"] != DBNull.Value ? row["SectorEconomico"].ToString() : string.Empty,
                TipoEntidadEmpresa = row["Tipo_empresa"] != DBNull.Value ? row["Tipo_empresa"].ToString() : string.Empty,
                ClasificacionComercial = row["ClaComercialEmpresa"] != DBNull.Value ? row["ClaComercialEmpresa"].ToString() : string.Empty,
                TotalAfiliados = row["Cantidad_Trabajadores"] != DBNull.Value ? row["Cantidad_Trabajadores"].ToString() : string.Empty,
                Rut_DV = row["Rut_DV"] != DBNull.Value ? row["Rut_DV"].ToString() : string.Empty,
                Fecha_ProcesoEmpresa = row["Fecha_Proceso"] != DBNull.Value ? row["Fecha_Proceso"].ToString() : string.Empty,
                Creditos_Vigentes= row["CreditosVigentes"] != DBNull.Value ? row["CreditosVigentes"].ToString() : string.Empty,
                Credito_Saldo_Vigente= row["Credito_Saldo_Vigente"] != DBNull.Value ? row["Credito_Saldo_Vigente"].ToString() : string.Empty,
                Credito_Mes = row["Credito_Mes"] != DBNull.Value ? row["Credito_Mes"].ToString() : string.Empty,
                Credito_Mes_Saldo = row["Credito_Mes_Saldo"] != DBNull.Value ? row["Credito_Mes_Saldo"].ToString() : string.Empty,
                penetracion = row["penetracion"] != DBNull.Value ? row["penetracion"].ToString():string.Empty
                //Convert.ToDouble(row["penetracion"]):0

            };
        }
    }
}
