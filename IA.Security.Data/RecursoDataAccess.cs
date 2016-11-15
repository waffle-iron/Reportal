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

        public static List<Recurso> MenusDeUsuario(string Token)
        {
            Parametro p = new Parametro("@AuthToken", Token);
            return DBHelper.InstanceSecurity.ObtenerColeccion("sp_SCA_ListarRecursosDeUsuario", p, ConstructorEntidad);
        }
        
        private static Recurso ConstructorEntidad(DataRow row)
        {
            return new Recurso
            {
                IdRecurso = row["rec_id"] != DBNull.Value ? Convert.ToInt32(row["rec_id"]) : 0,
                IdRecursoPradre = row["rec_id_padre"] != DBNull.Value ? Convert.ToInt32(row["rec_id_padre"]) : 0,
                Nombre = row["rec_nombre"] != DBNull.Value ? row["rec_nombre"].ToString() : string.Empty,
                Tipo = row["rec_tipo"] != DBNull.Value ? row["rec_tipo"].ToString() : string.Empty,
                Url = row["rec_url"] != DBNull.Value ? row["rec_url"].ToString() : string.Empty,
                Icono = row["rec_icono"] != DBNull.Value ? row["rec_icono"].ToString() : string.Empty,
            };
        }
    }
}
