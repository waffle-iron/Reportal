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
    public static class CredColocDiariaPromDataAccess
    {
        public static List<CreditoColoc_Diaria> ListarCreditoProm(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Directorio_Cred_ColocDiariaProm_Listar", p, ConstructorEntidad);

        }

        private static CreditoColoc_Diaria ConstructorEntidad(DataRow row)
        {
            return new CreditoColoc_Diaria
            {
                Fecha = row["Fecha"] != DBNull.Value ? row["Fecha"].ToString() : string.Empty,
                DiaGraf = row["DiaGrafico"] != DBNull.Value ? row["DiaGrafico"].ToString() : string.Empty,
                Bruta = row["Prom_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Prom_Bruto"]) : 0,
                Neta = row["Prom_Neto"] != DBNull.Value ? Convert.ToInt32(row["Prom_Neto"]) : 0,
            };
        }
    }
}
