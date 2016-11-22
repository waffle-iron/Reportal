using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Reportal.Api.Models
{
    public class ContenedorBasePpto
    {
        public List<EncabezadoPpto> EncabezadoPpto { get; set; }
        public List<AuxiliarPpto> PresupuestoPpto { get; set; }
        public List<AuxiliarPpto> RealPpto { get; set; }
        public List<AuxiliarPpto> GapPpto { get; set; }
        public List<AuxiliarPpto> CumplimientoPpto { get; set; }

        public ContenedorBasePpto()
        {
            EncabezadoPpto = new List<EncabezadoPpto>();
            PresupuestoPpto = new List<AuxiliarPpto>();
            RealPpto = new List<AuxiliarPpto>();
            GapPpto = new List<AuxiliarPpto>();
            CumplimientoPpto = new List<AuxiliarPpto>();
        }
    }
    public class EncabezadoPpto
    {
        public string Mes { get; set; }
    }

    public class AuxiliarPpto
    {
        public int PptoBruto { get; set; }
        public int PptoNeto { get; set; }

    }

}