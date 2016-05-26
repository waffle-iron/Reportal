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
    public static class CicloVidaEmpresaDataAccess
    {
        public static List<CicloVidaEmpresa> ListarPorRutEmpresa(int RutEmpresa)
        {
            Parametro p = new Parametro("@RutEmpresa", RutEmpresa);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_ListarCicloVidaEmpresa", p, ConstructorEntidad);
        }

        public static CicloVidaEmpresa ConstructorEntidad(DataRow row)
        {
            return new CicloVidaEmpresa
            {
                RutEmpresas= row["RutEmpresas"] != DBNull.Value ? Convert.ToInt32(row["RutEmpresas"]) : 0,
                CVAdultoMayor = row["Adulto Mayor"] != DBNull.Value ? Convert.ToInt32(row["Adultos"]) : 0,
                CVAdultos = row["Adultos"] != DBNull.Value ? Convert.ToInt32(row["Adulto Mayor"]) : 0,
                CVDesarrollo = row["Desarrollo"] != DBNull.Value ? Convert.ToInt32(row["Desarrollo"]) : 0,
                CVJovenes = row["Jovenes"] != DBNull.Value ? Convert.ToInt32(row["Jovenes"]) : 0,
                CVMadurez = row["Madurez"] != DBNull.Value ? Convert.ToInt32(row["Madurez"]) : 0,

            };
        }

    }
}
