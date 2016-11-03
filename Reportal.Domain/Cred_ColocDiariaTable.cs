using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class Cred_ColocDiariaTable
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public int Bruta_Table { get; set; }
        public int Neta_Table { get; set; }

        public int Periodo { get; set; }
    }
}
