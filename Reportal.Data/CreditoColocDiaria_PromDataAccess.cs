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
    public static class CreditoColocDiaria_PromDataAccess
    {
        public static List<CreditoColocDiaria_Prom> Listar_CredColocDiariaPromedio()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Directorio_Cred_Prom_ColocDiaria_Listar", ConstructorEntidad);
        }
        private static CreditoColocDiaria_Prom ConstructorEntidad(DataRow row)
        {
            return new CreditoColocDiaria_Prom
            {
                Fecha = row["Fecha"] != DBNull.Value ? row["Fecha"].ToString() : string.Empty,
                DiaGrafico = row["DiaGrafico"] != DBNull.Value ? row["DiaGrafico"].ToString() : string.Empty,
                NCred = row["NCreditos"] != DBNull.Value ? Convert.ToInt32(row["NCreditos"]) : 0,
                BrutaProm = row["Bruta"] != DBNull.Value ? Convert.ToInt32(row["Bruta"]) : 0,
                NetaProm = row["Neta"] != DBNull.Value ? Convert.ToInt32(row["Neta"]) : 0,
                VRenta = row["VecesRenta"] != DBNull.Value ? Convert.ToSingle(row["VecesRenta"]) : 0
            };
        }

    }
}
