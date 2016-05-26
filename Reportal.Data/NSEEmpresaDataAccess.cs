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
        public static List<NSEEmpresa> ListarNSEPorRutempresa(int RutEmpresa)
        {

            Parametro p = new Parametro("@RutEmpresa", RutEmpresa);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_ListarNSEEmpresa", p, ConstructorEntidad);
        }

        public static NSEEmpresa ConstructorEntidad(DataRow row)
        {
            return new NSEEmpresa
            {
                RutEmpresas = row["Detalle_EmpresaRut_NSEE"] != DBNull.Value ? Convert.ToInt32(row["Detalle_EmpresaRut_NSEE"]) : 0,
                NSABC1 = row["ABC1"] != DBNull.Value ? Convert.ToInt32(row["ABC1"]) : 0,
                NSC2 = row["C2"] != DBNull.Value ? Convert.ToInt32(row["C2"]) : 0,
                NSC3 = row["C3"] != DBNull.Value ? Convert.ToInt32(row["C3"]) : 0,
                NSD = row["D"] != DBNull.Value ? Convert.ToInt32(row["D"]) : 0,
                NSE = row["E"] != DBNull.Value ? Convert.ToInt32(row["E"]) : 0,
            };
        }
    }
}
