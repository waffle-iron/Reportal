using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Reportal.Domain
{
    public class IdentidadDetalleEmpresa
    {
        public int Id { get; set; } //generico para todos


        public int CVAdultoMayor { get; set; }
        public int CVAdulto { get; set; }
        public int CVDesarrollo { get; set; }
        public int CVJovenes { get; set; }
        public int CVMadurez { get; set; }



        public int NSEABC1 { get; set; }
        public int NSEC2 { get; set; }
        public int NSEC3 { get; set; }
        public int NSED { get; set; }
        public int NSEE { get; set; }



    }
}