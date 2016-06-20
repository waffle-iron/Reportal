using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Reportal.Domain
{
    public class IdentidadDetalleEmpresa
    {
        public int Id { get; set; } //generico para todos

        #region resumentabla
        public string empresaDV { get; set; } 
        public string empresaNombre { get; set; }
        public string empresaSectorEconomico{ get; set; }
        public string tipoEmpresa { get; set; }
        public string empresaclasificacionRiesgo{ get; set; }
        public string empresaclasificacionComercial{ get; set; }   
        public string empresaHolding { get; set; }    
        public string empresaSegmentoCredito { get; set; }
        public  int empresaAniosAfiliado{ get; set; }
        public string empresaRNK { get; set; }
        public int empresaCantidadTrabajadores { get; set; }
        public int empresaTrabajadorMail { get; set; }
        public int empresaTrabajadorCelular { get; set; }
        public int empresaTrabajadorMailCelular { get; set; }
        public int empresaTrabajadorTarjDigital { get; set;}
        public double empresaPromedioRenta { get; set; }
        public int empresaPromedioEdad { get; set; }
        public string empresaSegmento { get; set; }
        public string empresaNSE { get; set; }



        #endregion

        #region CicloVida
        public decimal CVAdultoMayor { get; set; }
        public decimal CVAdulto { get; set; }
        public decimal CVDesarrollo { get; set; }
        public decimal CVJovenes { get; set; }
        public decimal CVMadurez { get; set; }
        #endregion

        #region NivelSocioeconomico
        public decimal NS_Abc1 { get; set; }
        public decimal NS_C2 { get; set; }
        public decimal NS_C3 { get; set; }
        public decimal NS_D { get; set; }
        public decimal NS_E { get; set; }
        #endregion

        #region TramoAsignacionFamiliar
        public decimal TA_Tramo_A { get; set; }
        public decimal TA_Tramo_B { get; set; }
        public decimal TA_Tramo_C { get; set; }
        public decimal TA_Tramo_D { get; set; }
        #endregion

        #region TramoEtarioAfiliados
        public decimal TramoEtarioDe75aMasAnios { get; set; }
        public decimal TramoEtarioDe18a30Anios { get; set; }
        public decimal TramoEtarioDe31a45Anios { get; set; }
        public decimal TramoEtarioDe46a60Anios { get; set; }
        public decimal TramoEtarioDe61a75Anios { get; set; }
        #endregion

        #region RegimenSalud
        public decimal RegimenSaludIsapre { get; set; }
        public decimal RegimenSaludFonasa { get; set; }
        public decimal RegimenSaludSinInformacion { get; set; }
        #endregion  

        #region genero

        public decimal SexoFemenino { get; set; }
        public decimal SexoMasculino { get; set; }
        public decimal SexoSinInfo { get; set; }
        #endregion

        #region TenenciaCarga
        public decimal TC_Si { get; set; }
        public decimal TC_No { get; set; }
        #endregion

        #region TipoCarga
        public decimal TipoCargaHijo { get; set; }
        public decimal TipoCargaOtros { get; set; }
        #endregion

        #region DistribucionCargaHijosPorEdad
        public decimal CargaHijoDe0a2Anios { get; set; }
        public decimal CargaHijoDe3a4Anios { get; set; }
        public decimal CargaHijoDe5a6Anios { get; set; }
        public decimal CargaHijoDe7a14Anios { get; set; }
        public decimal CargaHijoDe15a18Anios { get; set; }
        public decimal CargaHijoDe19MasAnios { get; set; }
        #endregion

        #region totalTrabajadores
        public int TotalTrabajadores { get; set; }
        #endregion


    }
}