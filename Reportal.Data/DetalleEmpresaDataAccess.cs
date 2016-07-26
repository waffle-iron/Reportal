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
        public static IdentidadDetalleEmpresa Obtener(int id)
        {
            Parametro p = new Parametro("@RutEmpresa", id);
            //return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ObtenerDetalleCampania", p, ConstructorEntidad);
            return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ListarMapaEmpresa_1", p, ConstructorEntidad);
        }
       
        private static IdentidadDetalleEmpresa ConstructorEntidad(DataRow row)
        {
            return new IdentidadDetalleEmpresa
            {
                Id = row["RutEmpresa"] != DBNull.Value ? Convert.ToInt32(row["RutEmpresa"]) : 0,
                CVAdultoMayor = row["Adulto_Mayor"] != DBNull.Value ? Convert.ToDecimal(row["Adulto_Mayor"]) : 0,
                CVAdulto = row["Adultos"] != DBNull.Value ? Convert.ToDecimal(row["Adultos"]) : 0,
                CVDesarrollo = row["Desarrollo"] != DBNull.Value ? Convert.ToDecimal(row["Desarrollo"]) : 0,
                CVJovenes = row["Jovenes"] != DBNull.Value ? Convert.ToDecimal(row["Jovenes"]) : 0,
                CVMadurez = row["Madurez"] != DBNull.Value ? Convert.ToDecimal(row["Madurez"]) : 0,
                NS_Abc1 = row["ABC1"] != DBNull.Value ? Convert.ToDecimal(row["ABC1"]) : 0,
                NS_C2 = row["C2"] != DBNull.Value ? Convert.ToDecimal(row["C2"]) : 0,
                NS_C3 = row["C3"] != DBNull.Value ? Convert.ToDecimal(row["C3"]) : 0,
                NS_D = row["D"] != DBNull.Value ? Convert.ToDecimal(row["D"]) : 0,
                NS_E = row["E"] != DBNull.Value ? Convert.ToDecimal(row["E"]) : 0,
                TA_Tramo_A = row["Tramo_A"] != DBNull.Value ? Convert.ToDecimal(row["Tramo_A"]) : 0,
                TA_Tramo_B = row["Tramo_B"] != DBNull.Value ? Convert.ToDecimal(row["Tramo_B"]) : 0,
                TA_Tramo_C = row["Tramo_C"] != DBNull.Value ? Convert.ToDecimal(row["Tramo_C"]) : 0,
                TA_Tramo_D = row["Tramo_D"] != DBNull.Value ? Convert.ToDecimal(row["Tramo_D"]) : 0,
                TramoEtarioDe18a30Anios = row["De 18 a 30 Años"] != DBNull.Value ? Convert.ToDecimal(row["De 18 a 30 Años"]) : 0,
                TramoEtarioDe31a45Anios = row["De 31 a 45 Años"] != DBNull.Value ? Convert.ToDecimal(row["De 31 a 45 Años"]) : 0,
                TramoEtarioDe46a60Anios = row["De 46 a 60 Años"] != DBNull.Value ? Convert.ToDecimal(row["De 46 a 60 Años"]) : 0,
                TramoEtarioDe61a75Anios = row["De 61 a 75 Años"] != DBNull.Value ? Convert.ToDecimal(row["De 61 a 75 Años"]) : 0,
                TramoEtarioDe75aMasAnios = row["De 75 y mas Años"] != DBNull.Value ? Convert.ToDecimal(row["De 75 y mas Años"]) : 0,
                RegimenSaludFonasa = row["Fonasa"] != DBNull.Value ? Convert.ToDecimal(row["Fonasa"]) : 0,
                RegimenSaludIsapre = row["Isapres"] != DBNull.Value ? Convert.ToDecimal(row["Isapres"]) : 0,
                RegimenSaludSinInformacion = row["Sin_Información"] != DBNull.Value ? Convert.ToDecimal(row["Sin_Información"]) : 0,
                SexoFemenino = row["Femenino"] != DBNull.Value ? Convert.ToDecimal(row["Femenino"]) : 0,
                SexoMasculino = row["Masculino"] != DBNull.Value ? Convert.ToDecimal(row["Masculino"]) : 0,
                SexoSinInfo = row["Sin_Info"] != DBNull.Value ? Convert.ToDecimal(row["Sin_Info"]) : 0,
                TC_Si = row["Si"] != DBNull.Value ? Convert.ToDecimal(row["Si"]) : 0,
                TC_No = row["No"] != DBNull.Value ? Convert.ToDecimal(row["No"]) : 0,
                TipoCargaHijo = row["Hijos"] != DBNull.Value ? Convert.ToDecimal(row["Hijos"]) : 0,
                TipoCargaOtros = row["Otros"] != DBNull.Value ? Convert.ToDecimal(row["Otros"]) : 0,
                CargaHijoDe0a2Anios = row["De 0 a 2 Años"] != DBNull.Value ? Convert.ToDecimal(row["De 0 a 2 Años"]) : 0,
                CargaHijoDe3a4Anios = row["De 3 a 4 Años"] != DBNull.Value ? Convert.ToDecimal(row["De 3 a 4 Años"]) : 0,
                CargaHijoDe5a6Anios = row["De 5 a 6 Años"] != DBNull.Value ? Convert.ToDecimal(row["De 5 a 6 Años"]) : 0,
                CargaHijoDe7a14Anios = row["De 7 a 14 Años"] != DBNull.Value ? Convert.ToDecimal(row["De 7 a 14 Años"]) : 0,
                CargaHijoDe15a18Anios = row["De 15 a 18 Años"] != DBNull.Value ? Convert.ToDecimal(row["De 15 a 18 Años"]) : 0,
                CargaHijoDe19MasAnios = row["De 19 y mas Años"] != DBNull.Value ? Convert.ToDecimal(row["De 19 y mas Años"]) : 0,
                TotalTrabajadores = row["TotalTrabajorEmpresa"] != DBNull.Value ? Convert.ToInt32(row["TotalTrabajorEmpresa"]) : 0,
            };
        }
       
    }
}
