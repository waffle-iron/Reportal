using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class IdentidadDetalleCampania
    {
        public int Id { get; set; }
        public int TotalAFiliadosCampanados { get; set; }
        public int TotalAFiliadosContactados { get; set; }
        public int TotalPrivadosContactados { get; set; }
        public int TotalPrivadosContactadosSms { get; set; }
        public int TotalPrivadosContactadosEmail { get; set; }
        public int TotalPrivadosContactadosCall { get; set; }
        public int TotalPublicosContactados { get; set; }
        public int TotalPublicosContactadosSms { get; set; }
        public int TotalPublicosContactadosEmail { get; set; }
        public int TotalPublicosContactadosCall { get; set; }
        public int TotalPensionadosContactados { get; set; }
        public int TotalPensionadosContactadosEmail { get; set; }
        public int TotalPensionadosContactadosSms { get; set; }
        public int TotalPensionadosContactadosCall { get; set; }
    }
}