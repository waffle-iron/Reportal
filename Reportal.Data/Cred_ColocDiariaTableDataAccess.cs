using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reportal.Domain;
using System.Data;
using CDK.Data;
using CDK.Integration;

namespace Reportal.Data
{
   public static class Cred_ColocDiariaTableDataAccess
    {
        public static List<Cred_ColocDiariaTable> ListarCred_ColocDiariaTable(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Directorio_CredColocDiaria_ListarTable", p,ConstructorEntidad);
        }
        private static Cred_ColocDiariaTable ConstructorEntidad(DataRow row)
        {
            return new Cred_ColocDiariaTable
            {
                id = row["iItem"] != DBNull.Value ? Convert.ToInt32(row["iItem"]) : 0,
                Descripcion = row["Item"] != DBNull.Value ? row["Item"].ToString() : string.Empty,
                Bruta_Table = row["bruta"] != DBNull.Value ? Convert.ToInt32(row["bruta"]) : 0,
                Neta_Table= row["neta"] != DBNull.Value ? Convert.ToInt32(row["neta"]) : 0
            };
        }
    }
}
