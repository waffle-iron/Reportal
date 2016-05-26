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
    public static class GeneroEmpresaDataAccess
    {
        public static List<GeneroEmpresa> ListarGeneroRutEmpresa(int RutEmpresa)
        {
            Parametro p = new Parametro("RutEmpresa", RutEmpresa);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_ListarGeneroEmpresa",p,ConstructorEntidad);
        }

        public static GeneroEmpresa ConstructorEntidad(DataRow row)
        {
            return new GeneroEmpresa
            {
                Detalle_SexoEmpresa_Rut = row["Detalle_SexoEmpresa_Rut"] != DBNull.Value ? Convert.ToInt32(row["Detalle_SexoEmpresa_Rut"]) : 0,
                GeneroM = row["Masculino"] != DBNull.Value ? Convert.ToInt32(row["Masculino"]) : 0,
                GeneroF= row["Femenino"] != DBNull.Value ? Convert.ToInt32(row["Femenino"]) : 0,
                GeneroSinInfo = row["Sin Información"] != DBNull.Value ? Convert.ToInt32(row["Sin Información"]) : 0,


            };

        }
    }
}
