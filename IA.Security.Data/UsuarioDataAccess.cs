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
<<<<<<< HEAD
            //return DBHelper.InstanceSecurity.ObtenerColeccion("sp_Reportal_Obtener_BenchMark", ConstructorEntidad);
            return new List<Usuario>();
=======
            return DBHelper.InstanceSecurity.ObtenerColeccion("sp_SCA_ListarUsuarios", ConstructorEntidad);
        }

        public static Usuario UsuarioData(string IdUsuario)
        {
            Parametro p = new Parametro("@IdUsuario", IdUsuario);            
            return DBHelper.InstanceSecurity.ObtenerEntidad("sp_SCA_ObtenerUsuario", p, ConstructorEntidad);
        }

        public static void InsertUsuario(Usuario usuario)
        {
            Parametros pEntrada = new Parametros()
            {
                new Parametro("IdUsuario",usuario.IdUsuario),
                new Parametro("IdUsuario",usuario.Nombres),
                new Parametro("IdUsuario",usuario.ClaveAcceso),
                new Parametro("IdUsuario",usuario.Estado)
            };

            DBHelper.InstanceSecurity.EjecutarProcedimiento("sp_SCA_InsetaUsuario", pEntrada);
        }

        private static Usuario ConstructorEntidad(DataRow row)
        {
            return new Usuario
            {
                IdUsuario = row["IdUsuario"] != DBNull.Value ? row["IdUsuario"].ToString() : string.Empty,
                Nombres = row["IdUsuario"] != DBNull.Value ? row["IdUsuario"].ToString() : string.Empty,
                ClaveAcceso = row["IdUsuario"] != DBNull.Value ? row["IdUsuario"].ToString() : string.Empty,
                Estado = row["IdUsuario"] != DBNull.Value ? row["IdUsuario"].ToString() : string.Empty,
            };
>>>>>>> 2c3a650d4a2c8ee9baf2829c290395fbdc8a1bec
        }
    }
}
