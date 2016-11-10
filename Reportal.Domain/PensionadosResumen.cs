using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class PensionadosResumen
    {
        public int Id_Oficina { get; set; }
        public string Nombre_Oficina { get; set; }
        public string Zona { get; set; }
        public string Periodo { get; set; }

        //Valores  Rojos

        public int pla_Rojo { get; set; }
        public int cla_Rojo { get; set; }
        public int gol_Rojo { get; set; }
        public int total_Rojo { get; set; }
        
        //Valores Amarillo

        public int pla_Amarillo { get; set; }
        public int cla_Amarillo { get; set; }
        public int gol_Amarillo { get; set; }
        public int total_Amarillo { get; set;}
      
        //Valores Verde

        public int pla_Verde { get; set; }
        public int cla_Verde { get; set; }
        public int gol_Verde { get; set; }
        public int total_Verde { get; set; }

        //S_Seg
        public int pla_S_Seg { get; set; }
        public int cla_S_Seg { get; set; }
        public int gol_S_Seg { get; set; }

        //Totales

        public int total_sin { get; set; }
        public int total_Z { get; set; }
    }
}
