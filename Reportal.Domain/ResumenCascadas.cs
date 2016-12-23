using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class ResumenCascadas
    {
        public int Periodo { get; set; }
        public string Segmento { get; set; }
        public string Filtro { get; set; }
        public int Pasan { get; set; }
        public int Caen { get; set; }
    }

    public class ResumenCanal
    {
        public int Periodo { get; set; }
        public string Canal { get; set; }
        public int Cantidad { get; set; }
    }

    public class ResumenNominas
    {
        public int Periodo { get; set; }
        public string Canal { get; set; }
        public string Nomina { get; set; }
        public int Cantidad { get; set; }
    }

    public class RowsCanales
    {
        public string Canal { get; set; }
        public int Cantidad { get; set; }
    }

    public class ResumenBase
    {
        public List<ResumenNominas> ResumenNominas { get; set; }
        public List<RowsCanales> RowsCanales { get; set; }

    }
}
