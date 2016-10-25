using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
   public class CreditoColocDiaria_Prom
    {
        public string Fecha { get; set; }
        public string DiaGrafico { get; set; }
        public int NCred { get; set; }
        public int BrutaProm { get; set; }
        public int NetaProm { get; set; }
        public float VRenta { get; set; }


    }
}
