using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class EmpresaClasif
    {
        public string Periodo { get; set; }
        public int RutEmp { get; set; }
        public string NomEmpresa { get; set; }
        public string TipoEmpresa { get; set; }
        public int NumTrabEmp { get; set; }
        public string Holding { get; set; }
        public string ClasFinal { get; set; }
        public int Interes { get; set; }
        public int CostoPrev { get; set; }


    }
}
