using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class Cred_ColocDashboard
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public float Bruta_Table { get; set; }
        public float Neta_Table { get; set; }
        public int Iitem { get; set; }
        public int Periodo { get; set; }
    }
}
