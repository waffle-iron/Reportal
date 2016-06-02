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
    public static class NSEEmpresaDataAccess
    {
        public static NSEEmpresa Obtener(int id)
        {

            Parametro p = new Parametro("@RutEmpresa", id);
            return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ListarNSEEmpresa", p, ConstructorEntidad);
        }

        public static NSEEmpresa ConstructorEntidad(DataRow row)
        {
            return new NSEEmpresa
            {
                Id = row["RutEmpresa"] != DBNull.Value ? Convert.ToInt32(row["RutEmpresa"]) : 0,
                NSEABC1 = row["ABC1"] != DBNull.Value ? Convert.ToInt32(row["ABC1"]) : 0,
                NSEC2 = row["C2"] != DBNull.Value ? Convert.ToInt32(row["C2"]) : 0,
                NSEC3 = row["C3"] != DBNull.Value ? Convert.ToInt32(row["C3"]) : 0,
                NSED = row["D"] != DBNull.Value ? Convert.ToInt32(row["D"]) : 0,
                NSEE = row["E"] != DBNull.Value ? Convert.ToInt32(row["E"]) : 0,
            };
        }
    }
}
