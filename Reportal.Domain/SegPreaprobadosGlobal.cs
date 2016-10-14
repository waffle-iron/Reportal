using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class SegPreaprobadosGlobal
    {
        public int Periodo { get; set; }
        public int FechaEjecucion { get; set; }
        public string Segmento { get; set; }
        public string Nomina { get; set; }
        public string Canal { get; set; }
        public string PropensionCompra { get; set; }
        public decimal N_Oferta { get; set; }
        public decimal Oferta { get; set; }
        public decimal Oferta_Promedio { get; set; }
        public decimal N_Compra { get; set; }
        public decimal Neto { get; set; }
        public decimal Neto_Promedio { get; set; }
        public decimal Bruto { get; set; }
        public decimal WR { get; set; }
    }
}
