using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reportal.Api.Models
{
    public class ContenedorBaseBeneficio
    {
        public List<EncabezadoBeneficio> EncabezadoBeneficio { get; set; }
        public List<AuxiliarBeneficio> PorcentajeBeneficio { get; set; }

        public ContenedorBaseBeneficio()
        {
            EncabezadoBeneficio = new List<EncabezadoBeneficio>();
            PorcentajeBeneficio = new List<AuxiliarBeneficio>();
        }
    }
    public class EncabezadoBeneficio
    {
        public string Mes { get; set; }
    }
    public class AuxiliarBeneficio
    {
        public decimal PorcentajeBeneficio { get; set; }
    }

}