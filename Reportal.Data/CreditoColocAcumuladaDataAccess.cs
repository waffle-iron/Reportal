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
    public static class CreditoColocAcumuladaDataAccess
    {
        public static List<CreditoColocAcumulada> Listar_CredColocAcumulada()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Directorio_ColocAcumulada_Listar", ConstructorEntidad);
        }

        private static CreditoColocAcumulada ConstructorEntidad(DataRow row)
        {
            return new CreditoColocAcumulada
            {
                NCred = row["NCreditos"] != DBNull.Value ? Convert.ToInt32(row["NCreditos"]):0,
                Bruto = row["Bruta"] != DBNull.Value ? Convert.ToInt32(row["Bruta"]) : 0,
                Neto = row["Neta"] != DBNull.Value ? Convert.ToInt32(row["Neta"]) : 0,
                indRepac = row["indRepacta"] != DBNull.Value ? Convert.ToSingle(row["indRepacta"]) : 0
            };
        }
    }
}
