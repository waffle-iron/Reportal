using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class ResultadoUniversos
    {
        public IEnumerable<TotalesUniverso> totalesUniverso { get; set; }
        public IEnumerable<UniversoGestionable> universoGestionable { get; set; }
        public IEnumerable<UniversoCampagnado> universoCampagnado { get; set; }
        public IEnumerable<UniversoGestionablePropension> universoGestionablePropension { get; set; }
        public IEnumerable<UniversoCampagnadoPropension> universoCampagnadoPropension { get; set; }
    }


    public class TotalesUniverso
    {
        public int Periodo { get; set; }
        public string Item { get; set; }
        public int N_Pensionados { get; set; }
        public int N_Trabajadores { get; set; }
        public int N_Total { get; set; }
        public int P_Pensionados { get; set; }
        public int P_Trabajadores { get; set; }
        public int P_Total { get; set; }
    }

    public class UniversoGestionable
    {
        public int Periodo { get; set; }
        public string Segmento { get; set; }
        public int N_Afiliados { get; set; }
        public int N_Email { get; set; }
        public int P_Email { get; set; }
        public int N_Celular { get; set; } 
        public int P_Celular { get; set; }
        public int N_CelularOFijo { get; set; }
        public int P_CelularOFijo { get; set; }
        public int N_EmailOFonos { get; set; }
        public int P_EmailOFonos { get; set; }
    }
    
    public class UniversoCampagnado
    {
        public int Periodo { get; set; }
        public string Segmento { get; set; }
        public int N_Email { get; set; }
        public int P_Email { get; set; }
        public int N_SMS { get; set; }
        public int P_SMS { get; set; }
        public int N_Call { get; set; }
        public int P_Call { get; set; } 
        public int N_Total { get; set; }
        public int P_Total { get; set; }
    }


    public class UniversoGestionablePropension
    {
        public int Periodo { get; set; }
        public string Segmento { get; set; }
        public string SegmentoCompra { get; set; }
        public int N_Afiliados { get; set; }
        public int N_Email { get; set; }
        public int P_Email { get; set; }
        public int N_Celular { get; set; }
        public int P_Celular { get; set; }
        public int N_Fonos { get; set; }
        public int P_Fonos { get; set; }
        public int N_Alguno { get; set; }
        public int P_Alguno { get; set; }
    }

    public class UniversoCampagnadoPropension
    {
        public int Periodo { get; set; }
        public string Segmento { get; set; }
        public string SegmentoCompra { get; set; }
        public int N_Email { get; set; }
        public int P_Email { get; set; }
        public int N_SMS { get; set; }
        public int P_SMS { get; set; }
        public int N_Call { get; set; }
        public int P_Call { get; set; }
        public int N_Total { get; set; }
        public int P_Total { get; set; }
    }
    
}
