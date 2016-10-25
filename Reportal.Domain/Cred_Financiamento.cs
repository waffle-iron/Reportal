using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class Cred_Financiamento
    {
        public string periodo { get; set; }
       // public int fechaEjecucion { get; set; }
        public int iSegmento { get; set; }
        public string segmento { get; set; }
        public string fecha { get; set; }
        public string diaGrafico { get; set; }
        public float tasaPromedio { get; set; }
        public float sPread { get; set; }
        public int plazoPromedio { get; set; }
    }
}
