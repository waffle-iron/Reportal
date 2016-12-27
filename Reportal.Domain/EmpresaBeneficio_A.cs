using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
   public class EmpresaBeneficio_A
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public float Porcentaje { get; set; }
        public int Cantidad { get; set; }
        public int Item { get; set; }
    }
}
