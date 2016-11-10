using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class ResumenGlobalLicencia
    {
        public string LicenciaFInicio { get; set; }
        public string LicenciaFinicioAnio { get; set; }
        public int CantidadLicencia { get; set; }
        public int Porcentaje { get; set; } 
        public int TotalEmpleado { get; set; }
    }
}
