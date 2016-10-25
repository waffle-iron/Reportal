using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
   public class CreditoColoc_Diaria
    {
        public string Fecha { get; set; }
        public string DiaGraf { get; set; }
        public int NCred { get; set; }
        public int Bruta { get; set; }
        public int Neta { get; set; }
        public int indRepac { get; set; }
    }
}
