using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class Empresa
    {
        public int Id { get; set; }
        public string DVEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string SectorEconomicoEmpresa { get; set; }
        public string TipoEmpresa { get; set; }
        public string ClaRiesgoEmpresa { get; set; }
        public string ClaComercialEmpresa { get; set; }
        public string HoldingEmpresa { get; set; }
        public string EmpresaSegmentoCredito { get; set; }
        public int AnosEmpresaAfiliada { get; set; }
        public int Cantidad_Trabajadores { get; set; }
        public int CantidadMail { get; set; }
        public int CantidadCelular { get; set; }
        public int CantidadMailCelular { get; set; }
        public int CantidadTarjetaDigital { get; set; }
        public float PromedioRenta { get; set; }
        public int PromedioEdadEmpresaAfiliado { get; set; }
        public string SegmentoEmpresa { get; set; }
        public string EmpresaNSE { get; set; }
        public string Periodo { get; set; }

    }
}
