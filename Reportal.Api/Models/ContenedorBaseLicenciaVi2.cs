using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reportal.Api.Models
{
    public class ContenedorBaseLicenciaVi2
    {
        public List<EncabezadoLicenciaVi2> EncabezadoLicenciaVi2 { get; set; }
        public List<AuxiliarLicenciaVi2> LicAutorizada2 { get; set; }
        public List<AuxiliarLicenciaVi2> LicPendientes2 { get; set; }
        public List<AuxiliarLicenciaVi2> LicSinDerecho2 { get; set; }
        public List<AuxiliarLicenciaVi2> LicObjetada2 { get; set; }
        public List<AuxiliarLicenciaVi2> LicRechazada2 { get; set; }
        public List<AuxiliarLicenciaVi2> LicTotal2 { get; set; }
        public List<AuxiliarLicenciaVi2> LicPagadas2 { get; set; }
        public List<AuxiliarLicenciaVi2> LicNoPagadas2 { get; set; }
        public ContenedorBaseLicenciaVi2()
        {
            EncabezadoLicenciaVi2 = new List<EncabezadoLicenciaVi2>();
            LicAutorizada2 = new List<AuxiliarLicenciaVi2>();
            LicPendientes2 = new List<AuxiliarLicenciaVi2>();
            LicSinDerecho2 = new List<AuxiliarLicenciaVi2>();
            LicObjetada2 = new List<AuxiliarLicenciaVi2>();
            LicRechazada2 = new List<AuxiliarLicenciaVi2>();
            LicTotal2 = new List<AuxiliarLicenciaVi2>();
            LicPagadas2 = new List<AuxiliarLicenciaVi2>();
            LicNoPagadas2 = new List<AuxiliarLicenciaVi2>();
        }
    }

    public class EncabezadoLicenciaVi2
    {
        public string Mes { get; set; }
    }

    public class AuxiliarLicenciaVi2
    {
        public decimal Valor { get; set; }
    }
}