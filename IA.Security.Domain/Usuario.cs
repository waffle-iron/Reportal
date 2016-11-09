using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.Security.Domain
{
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string ClaveAcceso { get; set; }
        public string Estado { get; set; }


        public Usuario() { }
        public Usuario(string IdUsuario)
        {
            this.IdUsuario = IdUsuario;
        }
    }
}
