using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class SeguimientoVentaCascadaEntity
    {
        public int Periodo { get; set; }
        public string Segmento { get; set; }
        public string Filtro { get; set; }
        public int N { get; set; }
        public decimal Oferta { get; set; }
        public int Compran { get; set; }
        public decimal Neto { get; set; }
        public decimal Bruto { get; set; }
        public decimal WR { get; set; }
    }
}
