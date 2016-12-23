using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reportal.Api.Models
{
    public class ContenedorBaseLicenciaVi
    {
        public List<EncabezadoLicenciaVi> EncabezadoLicenciaVi { get; set; }
        public List<AuxiliarLicenciaVi> LicAutorizada { get; set; }
        public List <AuxiliarLicenciaVi> LicPendientes { get; set; }
        public List<AuxiliarLicenciaVi> LicSinDerecho { get; set; }
        public List<AuxiliarLicenciaVi> LicObjetada { get; set; }
        public List<AuxiliarLicenciaVi> LicRechazada { get; set; }
        public List<AuxiliarLicenciaVi> LicTotal { get; set; }
        public List<AuxiliarLicenciaVi> LicPagadas { get; set; }
        public List<AuxiliarLicenciaVi> LicNoPagadas { get; set; }
        public ContenedorBaseLicenciaVi()
        {
            EncabezadoLicenciaVi = new List<EncabezadoLicenciaVi>();
            LicAutorizada = new List<AuxiliarLicenciaVi>();
            LicPendientes = new List<AuxiliarLicenciaVi>();
            LicSinDerecho = new List<AuxiliarLicenciaVi>();
            LicObjetada = new List<AuxiliarLicenciaVi>();
            LicRechazada = new List<AuxiliarLicenciaVi>();
            LicTotal = new List<AuxiliarLicenciaVi>();
            LicPagadas = new List<AuxiliarLicenciaVi>();
            LicNoPagadas = new List<AuxiliarLicenciaVi>();
        }
    }

    public class EncabezadoLicenciaVi
    {
        public string Mes { get; set; }
    }

    public class AuxiliarLicenciaVi
    {
        public int Valor { get; set; }
    }
}