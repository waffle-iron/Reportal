using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class SegPreaprobadosFull
    {
        public string Nomina { get; set;}
        public decimal N_Baja { get; set; }
        public decimal Neto_Baja { get; set; }
        public decimal WR_Baja { get; set; }
        public decimal N_Media { get; set; }
        public decimal Neto_Media { get; set; }
        public decimal WR_Media { get; set; }
        public decimal N_Alta { get; set; }
        public decimal Neto_Alta { get; set; }
        public decimal WR_Alta { get; set; }
        public decimal N_Total { get; set; }
        public decimal Neto_Total { get; set; }
        public decimal WR_Total { get; set; }

    }
}
