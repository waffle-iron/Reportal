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
        
        /*Totales Globales*/
        public int TotalAFiliadosCampanados { get; set; }

        public int TotalAFiliadosContactados { get; set; }
        public int TotalComunicacionesExitosas { get; set; }

        /*Totales de trabajadores*/
        public int TotalTrabajadoresCampanados { get; set; }
        public int TotalTrabajadoresContactados { get; set; }
        public int TotalTrabajadoresContactadosSms { get; set; }
        public int TotalTrabajadoresContactadosEmail { get; set; }
        public int TotalTrabajadoresContactadosCall { get; set; }
        public int TotalTrabajadoresExitosas { get; set; }

        /*Desglose de trabajadores*/
        public int TotalPrivadosContactados { get; set; }
        public int TotalPrivadosContactadosSms { get; set; }
        public int TotalPrivadosContactadosEmail { get; set; }
        public int TotalPrivadosContactadosCall { get; set; }

        public int TotalPublicosContactados { get; set; }
        public int TotalPublicosContactadosSms { get; set; }
        public int TotalPublicosContactadosEmail { get; set; }
        public int TotalPublicosContactadosCall { get; set; }

        /*Pensionados*/
        public int TotalPensionadosCampanados { get; set; }
        public int TotalPensionadosContactados { get; set; }
        public int TotalPensionadosContactadosEmail { get; set; }
        public int TotalPensionadosContactadosSms { get; set; }
        public int TotalPensionadosContactadosCall { get; set; }
        public int TotalPensionadosExitosas { get; set; }

        /*Nuevos campos*/
        public int TotalTrabajadoresCampanadosEmail { get; set; }
        public int TotalTrabajadoresCampanadosSms { get; set; }
        public int TotalTrabajadoresCampanadosCall { get; set; }

        public int TotalPensionadosCampanadosEmail { get; set; }
        public int TotalPensionadosCampanadosSms { get; set; }
        public int TotalPensionadosCampanadosCall { get; set; }

        public int TotalTrabajadoresExitosasEmail { get; set; }
        public int TotalTrabajadoresExitosasSms { get; set; }
        public int TotalTrabajadoresExitosasCall { get; set; }

        public int TotalPensionadosExitosasEmail { get; set; }
        public int TotalPensionadosExitosasSms { get; set; }
        public int TotalPensionadosExitosasCall { get; set; }

        /*Ventas*/
        public int TotalVentas { get; set; }
        public int TotalVentasPensionadosSMS { get; set; }
        public int TotalVentasTrabajadoresSMS { get; set; }
        public int TotalVentasPensionadosEmail { get; set; }
        public int TotalVentasTrabajadoresEmail { get; set; }
        public int TotalVentasPensionados { get; set; }
        public int TotalVentasTrabajadores { get; set; }
        public int TotalVentasPensionadosCall { get; set; }
        public int TotalVentasTrabajadoreaCall { get; set; }

    }
}