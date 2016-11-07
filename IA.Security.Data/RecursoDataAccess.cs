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
    public static class RecursoDataAccess
    {
        public static List<Recurso> ListarRecursos()
        {
            return DBHelper.InstanceSecurity.ObtenerColeccion("sp_SCA_ListarRecursos", ConstructorEntidad);
        }

        public static List<Recurso> MenusDeUsuario(Usuario usuario)
        {
            Parametro p = new Parametro("@IdUsuario", usuario.IdUsuario);
            return DBHelper.InstanceSecurity.ObtenerColeccion("sp_SCA_ListarRecursosDeUsuario", p, ConstructorEntidad);
        }
        
        private static Recurso ConstructorEntidad(DataRow row)
        {
            return new Recurso
            {
                IdRecurso = row["IdRecurso"] != DBNull.Value ? Convert.ToInt32(row["IdRecurso"]) : 0,
                IdRecursoPradre = row["IdRecursoPradre"] != DBNull.Value ? Convert.ToInt32(row["IdRecursoPradre"]) : 0,
                Nombre = row["Nombre"] != DBNull.Value ? row["Nombre"].ToString() : string.Empty,
                Tipo = row["Tipo"] != DBNull.Value ? row["Tipo"].ToString() : string.Empty,
                Url = row["Url"] != DBNull.Value ? row["Url"].ToString() : string.Empty,
                Icono = row["Icono"] != DBNull.Value ? row["Icono"].ToString() : string.Empty,
            };
        }
    }
}
