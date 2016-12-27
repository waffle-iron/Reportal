﻿using System;
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
    public static class ResumenNominasDataAccess
    {
       public static List<ResumenNominas> ObtenerResumen(int Periodo)
        {
            Parametro p = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_Resumenes_ObtenerResumenNominas", p, ConstructorEntidad);
        }

        private static ResumenNominas ConstructorEntidad(DataRow row)
        {
            return new ResumenNominas
            {
                Periodo = row["Periodo"] != DBNull.Value ? Convert.ToInt32(row["Periodo"]) : 0,
                Canal = row["Canal"] != DBNull.Value ? row["Canal"].ToString() : string.Empty,
                Nomina = row["Nomina"] != DBNull.Value ? row["Nomina"].ToString() : string.Empty,
                Cantidad = row["Cantidad"] != DBNull.Value ? Convert.ToInt32(row["Cantidad"]) : 0,
            };
        }
    }
}