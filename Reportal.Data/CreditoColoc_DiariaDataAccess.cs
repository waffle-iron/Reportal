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
    public static class CreditoColoc_DiariaDataAccess
    {
        public static List<CreditoColoc_Diaria> Listar_CredColocDiaria()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Directorio_Cred_ColocDiaria_Listar", ConstructorEntidad);
        }
        private static CreditoColoc_Diaria ConstructorEntidad(DataRow row)
        {
            return new CreditoColoc_Diaria
            {
                Fecha= row["Fecha"] != DBNull.Value ? row["Fecha"].ToString() : string.Empty,
                DiaGraf = row["DiaGrafico"] != DBNull.Value ? row["DiaGrafico"].ToString() : string.Empty,
                Bruta = row["Bruta"] != DBNull.Value ? Convert.ToInt32(row["Bruta"]) : 0,
                Neta = row["Neta"] != DBNull.Value ? Convert.ToInt32(row["Neta"]) : 0,
                indRepac = row["indRepacta"] != DBNull.Value ? Convert.ToInt32(row["indRepacta"]) : 0
            };
        }

    }
}
