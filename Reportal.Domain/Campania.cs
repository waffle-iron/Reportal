using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class Campania
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public bool CanalEmail { get; set; }
        public bool CanalSMS { get; set; }
        public bool CanalLlamada { get; set; }
        public string Observacion { get; set; }
        public string Concepto { get; set; }
        public string SubConcepto { get; set; }
        public int CantidadNomina { get; set; }

    }
}
