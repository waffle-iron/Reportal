using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.Security.Domain
{
    public class Usuario
    {
<<<<<<< HEAD
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string ClaveAcceso { get; set; }
        public string Estado { get; set; }
=======
        public string IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string ClaveAcceso { get; set; }
        public string Estado { get; set; }


        public Usuario() { }
        public Usuario(string IdUsuario)
        {
            this.IdUsuario = IdUsuario;
        }
>>>>>>> 2c3a650d4a2c8ee9baf2829c290395fbdc8a1bec
    }
}
