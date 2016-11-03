using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class CreditoColocAcumulada
    {
        public int NCred { get; set; }
        public int Bruto { get; set; }
        public int Neto { get; set; }
        public float indRepac { get; set; }
        public int Periodo { get; set; }
    }
}
