using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.Security.Domain
{
    public class Recurso
    {
        public int IdRecurso { get; set; }
        public int IdRecursoPradre { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }
        public string Icono { get; set; }
        public List<Recurso> Hijos { get; set; }

        public Recurso()
        {
            Hijos = new List<Recurso>();
        }

        private static List<Recurso> Recursivo(Recurso r, List<Recurso> lr)
        {
            return lr.Where(x => x.IdRecursoPradre == r.IdRecurso).ToList();
        }

        public static List<Recurso> AsignarDesendencia(List<Recurso> recursos)
        {
            recursos.ForEach(x => {
                x.Hijos.AddRange(Recursivo(x, recursos));
            });

            return recursos;
        }
    }
}
