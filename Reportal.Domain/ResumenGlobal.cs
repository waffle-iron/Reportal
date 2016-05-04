using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class ResumenGlobal
    {
        public int TotalAfiliados { get; set; }
        public int TotalAfiliadosContactables { get; set; }
        public int TotalAfiliadosCorreo { get; set; }
        public int TotalAfiliadosSMS { get; set; }
        public int TotalAfiliadosCall { get; set; }
        public int AfiliadosCorreoPrivados { get; set; }
        public int AfiliadosCorreoPublicos { get; set; }
        public int AfiliadosCorreoPensionados { get; set; }
        public int AfiliadosSMSPrivados { get; set; }
        public int AfiliadosSMSPublicos { get; set; }
        public int AfiliadosSMSPensionados { get; set; }
        public int AfiliadosCallPrivados { get; set; }
        public int AfiliadosCallPublicos { get; set; }
        public int AfiliadosCallPensionados { get; set; }
        public int Periodo { get; set; }


    }
}
