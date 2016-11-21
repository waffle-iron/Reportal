using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class DirectorioDashboard
    {
        public int Periodo { get; set; }
        public string Fecha { get; set; }
        public string DiaGraf { get; set; }
        public int RealBruta { get; set; }
        public int RealNeta { get; set; }
        public int PptBruta { get; set; }
        public int PptNeta { get; set; }
    }
}
