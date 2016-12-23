using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reportal.Api.Models
{
    public class ContenedorBase
    {
        public List<Encabezado> Encabezado { get; set; }
        public List<Auxiliar> Trabajador { get; set; }
        public List<Auxiliar> Pensionado { get; set; }
        public List<Auxiliar> DDirecto { get; set; }
        public List<Auxiliar> Total { get; set; }


        public ContenedorBase()
        {
            Encabezado = new List<Encabezado>();
            Trabajador = new List<Auxiliar>();
            Pensionado = new List<Auxiliar>();
            DDirecto = new List<Auxiliar>();
            Total = new List<Auxiliar>();
        }
    }

    public class Encabezado
    {
        public string Mes { get; set; }
    }
    public class Auxiliar
    {
        public decimal Tasa { get; set; }
        public decimal Spred { get; set; }
        public int Pplazo { get; set; }

    }   
}