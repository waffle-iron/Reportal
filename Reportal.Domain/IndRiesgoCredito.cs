using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class IndRiesgoCredito
    {
        public int Periodo { get; set; }
        public string Item { get; set; }
        public int Orden { get; set; }
        public float Operaciones { get; set; }
        public float CapitalEfectivoMM { get; set; }
        public float DistribucionCapital { get; set; }
    }
}
