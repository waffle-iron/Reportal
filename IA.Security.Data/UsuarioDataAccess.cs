using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IA.Security.Domain;
using System.Data;
using CDK.Data;
using CDK.Integration;

namespace IA.Security.Data
{
    public static class UsuarioDataAccess
    {
        public static List<Usuario> ListarUsuarios()
        {
            //return DBHelper.InstanceSecurity.ObtenerColeccion("sp_Reportal_Obtener_BenchMark", ConstructorEntidad);
            return new List<Usuario>();
        }
    }
}
