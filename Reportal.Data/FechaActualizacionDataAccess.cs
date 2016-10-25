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
    public class FechaActualizacionDataAccess
    {
        public static FechaActualizacion Obtener(string controlador, string accion)
        {
            Parametros para = new Parametros
            {
                new Parametro("@Controlador", controlador),
                new Parametro("@Accion", accion)
            };

            return DBHelper.InstanceReporteria.ObtenerEntidad("sp_General_FechasActualizacion", para ,ConstructorEntidad);
        }

        private static FechaActualizacion ConstructorEntidad(DataRow row)
        {
            return new FechaActualizacion
            {
                ActualizacionFecha = row["ActualizacionFecha"] != DBNull.Value ? Convert.ToDateTime(row["ActualizacionFecha"]) : DateTime.MinValue,
                ActualizacionLeyenda = row["ActualizacionLeyenda"] != DBNull.Value ? row["ActualizacionLeyenda"].ToString() : string.Empty,
            };
        }
    }
}
