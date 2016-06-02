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
    public static class AFEmpresaDataAccess
    {
        public static List<AFEmpresa> ListarAFEmpresa(int RutEmpresa)
        {
            Parametro p = new Parametro("@RutEmpresa",RutEmpresa);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_ListarAsignacionFamiliarEmpresa",p,ConstructorEntidad);
        }

        public static AFEmpresa ConstructorEntidad(DataRow row)
        {
            return new AFEmpresa
            {
                RutEmpresas = row["Detalle_AFE_EmpresaRut"] != DBNull.Value ? Convert.ToInt32(row["Detalle_AFE_EmpresaRut"]) : 0,
                AFTramoA = row["Tramo A"] != DBNull.Value ? Convert.ToInt32(row["Tramo A"]) : 0,
                AFTramoB = row["Tramo B"] != DBNull.Value ? Convert.ToInt32(row["Tramo B"]) : 0,
                AFTramoC = row["Tramo C"] != DBNull.Value ? Convert.ToInt32(row["Tramo C"]) : 0,
                AFTramoD= row["Tramo D"] != DBNull.Value ? Convert.ToInt32(row["Tramo D"]) : 0,
            };
        }
    }
}
