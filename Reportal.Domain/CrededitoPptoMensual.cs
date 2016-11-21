using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
   public class CrededitoPptoMensual
    {
        public int Periodo { get; set; }
        public int FecActualizacion { get; set; }
        public string Mes { get; set; }
        public int iItem { get; set; }
        public string Item { get; set; }
        public int PptoBruto { get; set; }
        public int PptoNeto { get; set; }
    }
}
