using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class Benchmark
    {
        public int Periodo { get; set; }
        public string Caja { get; set; }
        public string Item { get; set; }
        public float ValorTasa { get; set; }
        public int OrdenVisual { get; set; }
    }
}
