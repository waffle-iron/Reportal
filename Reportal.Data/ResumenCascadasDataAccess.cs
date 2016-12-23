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
    public static class ResumenCascadasDataAccess
    {
        public static List<ResumenCascadas> ObtenerResumenPensionados(int Periodo)
        {

            Parametros p = new Parametros(){
                new Parametro("@Periodo", Periodo),
                new Parametro("@Segmento","Pensionados")
            };
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Resumenes_ObtenerResumenCascadas", p, ConstructorEntidad);
        }

        public static List<ResumenCascadas> ObtenerResumenTrabajadores(int Periodo)
        {

            Parametros p = new Parametros(){
                new Parametro("@Periodo", Periodo),
                new Parametro("@Segmento","Trabajadores")
            };
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Resumenes_ObtenerResumenCascadas", p, ConstructorEntidad);
        }



        private static ResumenCascadas ConstructorEntidad(DataRow row)
        {
            return new ResumenCascadas
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Segmento = row["Segmento"] != DBNull.Value ? row["Segmento"].ToString() : string.Empty,
                Filtro = row["Filtro"] != DBNull.Value ? row["Filtro"].ToString() : string.Empty,
                Caen = row["Caen"] != DBNull.Value ? Convert.ToInt32(row["Caen"]) : 0,
                Pasan = row["Pasan"] != DBNull.Value ? Convert.ToInt32(row["Pasan"]) : 0,
            };
        }
    }
}
