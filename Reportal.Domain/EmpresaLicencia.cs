using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class EmpresaLicencia
    {
        public int Id { get; set; }
        public string FecInicio { get; set; }
        public string FecFinAnio { get; set; }
        public int Cantitdad { get; set; }
        public float Porcentaje { get; set; }
        public string Descripcion { get; set; }
        public int Item { get; set; }
    }
}
