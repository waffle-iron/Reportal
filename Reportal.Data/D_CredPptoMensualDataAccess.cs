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
    public static class D_CredPptoMensualDataAccess
    {
        public static List<D_CredPptoMensual> ListarD_CredPptoMensual()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Directorio_Cred_Ppto_Mensual_Listar", ConstructorEntidad);
        }
        public static List<CrededitoPptoMensual> ListarByGrafico()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Directorio_Cred_Ppto_MensualByGrafico", ConstructorByTodos);
        }
        public static List<CrededitoPptoMensual> ListarByTodos()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Directorio_Cred_Ppto_MensualByListar", ConstructorByTodos);
        }


        private static D_CredPptoMensual ConstructorEntidad(DataRow row)
        {
            return new D_CredPptoMensual
            {
                Periodo =  row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Item = row["Item"] != DBNull.Value ? row["Item"].ToString() : string.Empty,
                Enero_Bruto = row["Enero_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Enero_Bruto"]) : 0,
                Enero_Neto = row["Enero_Neto"] != DBNull.Value ? Convert.ToInt32(row["Enero_Neto"]) : 0,
                Febrero_Bruto = row["Febrero_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Febrero_Bruto"]) : 0,
                Febrero_Neto = row["Febrero_Neto"] != DBNull.Value ? Convert.ToInt32(row["Febrero_Neto"]) : 0,
                Marzo_Bruto = row["Marzo_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Marzo_Bruto"]) : 0,
                Marzo_Neto = row["Marzo_Neto"] != DBNull.Value ? Convert.ToInt32(row["Marzo_Neto"]) : 0,
                Abril_Bruto = row["Abril_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Abril_Bruto"]) : 0,
                Abril_Neto = row["Abril_Neto"] != DBNull.Value ? Convert.ToInt32(row["Abril_Neto"]) : 0,
                Mayo_Bruto = row["Mayo_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Mayo_Bruto"]) : 0,
                Mayo_Neto = row["Mayo_Neto"] != DBNull.Value ? Convert.ToInt32(row["Mayo_Neto"]) : 0,
                Junio_Bruto = row["Junio_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Junio_Bruto"]) : 0,
                Junio_Neto = row["Junio_Neto"] != DBNull.Value ? Convert.ToInt32(row["Junio_Neto"]) : 0,
                Julio_Bruto = row["Julio_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Julio_Bruto"]) : 0,
                Julio_Neto = row["Julio_Neto"] != DBNull.Value ? Convert.ToInt32(row["Julio_Neto"]) : 0,
                Agosto_Bruto = row["Agosto_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Agosto_Bruto"]) : 0,
                Agosto_Neto = row["Agosto_Neto"] != DBNull.Value ? Convert.ToInt32(row["Agosto_Neto"]) : 0,
                Septiembre_Bruto = row["Septiembre_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Septiembre_Bruto"]) : 0,
                Septiembre_Neto = row["Septiembre_Neto"] != DBNull.Value ? Convert.ToInt32(row["Septiembre_Neto"]) : 0,
                Octubre_Bruto = row["Octubre_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Octubre_Bruto"]) : 0,
                Octubre_Neto = row["Octubre_Neto"] != DBNull.Value ? Convert.ToInt32(row["Octubre_Neto"]) : 0,
                Noviembre_Bruto = row["Noviembre_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Noviembre_Bruto"]) : 0,
                Noviembre_Neto = row["Noviembre_Neto"] != DBNull.Value ? Convert.ToInt32(row["Noviembre_Neto"]) : 0,
                Diciembre_Bruto = row["Diciembre_Bruto"] != DBNull.Value ? Convert.ToInt32(row["Diciembre_Bruto"]) : 0,
                Diciembre_Neto = row["Diciembre_Neto"] != DBNull.Value ? Convert.ToInt32(row["Diciembre_Neto"]) : 0
            };
        }

        private static CrededitoPptoMensual ConstructorByTodos(DataRow row)
        {
            return new CrededitoPptoMensual
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                FecActualizacion = row["FechaActualizacion"] != DBNull.Value ? Convert.ToInt32(row["FechaActualizacion"]) : 0,
                Mes = row["Mes"] != DBNull.Value ? row["Mes"].ToString() : string.Empty,
                iItem= row["iItem"] != DBNull.Value ? Convert.ToInt32(row["iItem"]) : 0,
                Item = row["Item"] != DBNull.Value ? row["Item"].ToString() : string.Empty,
                PptoNeto= row["Neto"] != DBNull.Value ? Convert.ToInt32(row["Neto"]) : 0,
                PptoBruto = row["Bruto"] != DBNull.Value ? Convert.ToInt32(row["Bruto"]) : 0
            };

        }
    }
}
