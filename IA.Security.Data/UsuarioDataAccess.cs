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
                IdUsuario = row["usr_id"] != DBNull.Value ? row["usr_id"].ToString() : string.Empty,
                Nombres = row["usr_nombres"] != DBNull.Value ? row["usr_nombres"].ToString() : string.Empty,
                ClaveAcceso = row["usr_clave"] != DBNull.Value ? row["usr_clave"].ToString() : string.Empty,
                Estado = row["usr_estado"] != DBNull.Value ? row["usr_estado"].ToString() : string.Empty,
            };
        }
    }
}
