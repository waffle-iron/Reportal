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
    public class EncabezadoEmpresaDataAccess
    {
        public static IdentidadEncabezadoEmpresa ObtenerEncabezado(int id)
        {
            Parametro p = new Parametro("@RutEmpresa", id);
            //return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ObtenerDetalleCampania", p, ConstructorEntidad);
            return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ListarMapaEmpresa_Detalle", p, ContructorEntidadEncabezado);
        }
        private static IdentidadEncabezadoEmpresa ContructorEntidadEncabezado(DataRow row)
        {
            return new IdentidadEncabezadoEmpresa
            {
                Id = row["RutEmpresa"] != DBNull.Value ? Convert.ToInt32(row["RutEmpresa"]) : 0,
                empresaDV = row["DvEmpresa"] != DBNull.Value ? row["DvEmpresa"].ToString() : string.Empty,
                empresaNombre = row["EmpresaNombre"] != DBNull.Value ? row["EmpresaNombre"].ToString() : string.Empty,
                empresaSectorEconomico = row["SectorEconomico"] != DBNull.Value ? row["SectorEconomico"].ToString() : string.Empty,
                tipoEmpresa = row["Tipo_empresa"] != DBNull.Value ? row["Tipo_empresa"].ToString() : string.Empty,
                empresaclasificacionRiesgo = row["ClaRiesgoEmpresa"] != DBNull.Value ? row["ClaRiesgoEmpresa"].ToString() : string.Empty,
                empresaclasificacionComercial = row["ClaComercialEmpresa"] != DBNull.Value ? row["ClaComercialEmpresa"].ToString() : string.Empty,
                empresaHolding = row["Holding"] != DBNull.Value ? row["Holding"].ToString() : string.Empty,
               // empresaSegmentoCredito = row["Empresa_Segmento_credito"] != DBNull.Value ? row["Empresa_Segmento_credito"].ToString() : string.Empty,
                empresaAniosAfiliado = row["Anos_afilida"] != DBNull.Value ? Convert.ToInt32(row["Anos_afilida"]) : 0,
                empresaCantidadTrabajadores = row["Cantidad_Trabajadores"] != DBNull.Value ? Convert.ToInt32(row["Cantidad_Trabajadores"]) : 0,
                empresaTrabajadorMail = row["Trab_Mail"] != DBNull.Value ? Convert.ToInt32(row["Trab_Mail"]) : 0,
                empresaTrabajadorCelular = row["Trab_Celular"] != DBNull.Value ? Convert.ToInt32(row["Trab_Celular"]) : 0,
                empresaTrabajadorMailCelular = row["Trab_Mail_celu"] != DBNull.Value ? Convert.ToInt32(row["Trab_Mail_celu"]) : 0,
                empresaTrabajadorTarjDigital = row["Trab_tarj_digital"] != DBNull.Value ? Convert.ToInt32(row["Trab_tarj_digital"]) : 0,
                empresaPromedioRenta = row["Promedio_renta"] != DBNull.Value ? Convert.ToDouble(row["Promedio_renta"]) : 0,
                empresaPromedioEdad = row["Promedio_edad"] != DBNull.Value ? Convert.ToInt32(row["Promedio_edad"]) : 0,
                empresaSegmento = row["SegmentoEmpresa"] != DBNull.Value ? row["SegmentoEmpresa"].ToString() : string.Empty,
                empresaNSE = row["EmpresaNSE"] != DBNull.Value ? row["EmpresaNSE"].ToString() : string.Empty,
            };
        }
    }
}
