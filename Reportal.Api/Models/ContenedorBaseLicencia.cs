using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reportal.Api.Models
{
    public class ContenedorBaseLicencia
    {
        public List<EncabezadoLicencia> EncabezadoLicencia { get; set; }
        public List<AuxiliarLicencia> PorcentajeLicencia { get; set; }

        public ContenedorBaseLicencia()
        {
            EncabezadoLicencia = new List<EncabezadoLicencia>();
            PorcentajeLicencia = new List<AuxiliarLicencia>();
        }
     
    }
    public class EncabezadoLicencia
    {
        public string Mes { get; set; }
    }

    public class AuxiliarLicencia
    {
        public decimal PorcentajeLicencia { get; set; }
    }
}