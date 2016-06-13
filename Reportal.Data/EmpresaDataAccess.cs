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
                DVEmpresa = row["Empresa_Dv"] != DBNull.Value ? row["Empresa_Dv"].ToString() : string.Empty,
                NombreEmpresa = row["EmpresaNombre"] != DBNull.Value ? row["EmpresaNombre"].ToString() : string.Empty,
                SectorEconomicoEmpresa = row["SectorEconomico"] != DBNull.Value ? row["SectorEconomico"].ToString() : string.Empty,
                TipoEmpresa = row["Tipo_empresa"] != DBNull.Value ? row["Tipo_empresa"].ToString() : string.Empty,
                ClaRiesgoEmpresa = row["ClaRiesgoEmpresa"] != DBNull.Value ? row["ClaRiesgoEmpresa"].ToString() : string.Empty,
                ClaComercialEmpresa = row["ClaComercialEmpresa"] != DBNull.Value ? row["ClaComercialEmpresa"].ToString() : string.Empty,
                HoldingEmpresa = row["Holding"] != DBNull.Value ? row["Holding"].ToString() : string.Empty,
                EmpresaSegmentoCredito = row["Empresa_Segmento_credito"] != DBNull.Value ? row["Empresa_Segmento_credito"].ToString() : string.Empty,
                AnosEmpresaAfiliada = row["Anos_afilida"] != DBNull.Value ? Convert.ToInt32(row["Anos_afilida"]) : 0,
                Cantidad_Trabajadores = row["Cantidad_Trabajadores"] != DBNull.Value ? Convert.ToInt32(row["Cantidad_Trabajadores"]) : 0,
                CantidadMail =  row["Trab_Mail"] != DBNull.Value ? Convert.ToInt32(row["Trab_Mail"]) : 0,
                CantidadCelular= row["Trab_Celular"] != DBNull.Value ? Convert.ToInt32(row["Trab_Celular"]) : 0,
                CantidadMailCelular = row["Trab_Mail_celu"] != DBNull.Value ? Convert.ToInt32(row["Trab_Mail_celu"]) : 0,
                CantidadTarjetaDigital = row["Trab_tarj_digital"] != DBNull.Value ? Convert.ToInt32(row["Trab_tarj_digital"]) : 0,
                PromedioRenta = row["Promedio_renta"] != DBNull.Value ? Convert.ToInt32(row["Promedio_renta"]) : 0,
                PromedioEdadEmpresaAfiliado = row["Promedio_edad"] != DBNull.Value ? Convert.ToInt32(row["Promedio_edad"]) : 0,
                SegmentoEmpresa = row["SegmentoEmpresa"] != DBNull.Value ? row["SegmentoEmpresa"].ToString() : string.Empty,
                EmpresaNSE = row["EmpresaNSE"] != DBNull.Value ? row["EmpresaNSE"].ToString() : string.Empty,
                Periodo = row["periodo"] != DBNull.Value ? row["periodo"].ToString() : string.Empty,
            };
        }
    }
}
