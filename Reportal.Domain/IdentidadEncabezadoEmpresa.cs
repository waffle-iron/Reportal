using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Reportal.Domain

{
  public class IdentidadEncabezadoEmpresa
    {
        #region resumentabla
        public int Id { get; set; } //generico para todos

        public string empresaDV { get; set; }
        public string empresaNombre { get; set; }
        public string empresaSectorEconomico { get; set; }
        public string tipoEmpresa { get; set; }
        public string empresaclasificacionComercial { get; set; }
        public string empresaHolding { get; set; }
       // public string empresaSegmentoCredito { get; set; }
        public int empresaAniosAfiliado { get; set; }
        public string empresaRNK { get; set; }
        public int empresaCantidadTrabajadores { get; set; }
        public int empresaTrabajadorMail { get; set; }
        public int empresaTrabajadorCelular { get; set; }
        public int empresaTrabajadorMailCelular { get; set; }
        public int empresaTrabajadorTarjDigital { get; set; }
        public double empresaPromedioRenta { get; set; }
        public int empresaPromedioEdad { get; set; }
        public string empresaSegmento { get; set; }
        public string empresaNSE { get; set; }
        public string Rut_DV { get; set; }
        public string Fecha_Proceso { get; set; }



        #endregion
    }
}
