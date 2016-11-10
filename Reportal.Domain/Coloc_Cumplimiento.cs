using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class Coloc_Cumplimiento
    {
        public string Periodo
        {
            get; set;
        }
        public int ind
        {
            get; set;
        }
        public string Item { get; set; }
        public int Total { get; set; }
    }
}
