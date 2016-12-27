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
    public static class EmpresaDataAccess
    {
        public static Empresa Obtener(int RutEmpresas)
        {
            Parametro p = new Parametro("@RutEmpresa", RutEmpresas);
            return DBHelper.InstanceReporteria.ObtenerEntidad("sp_ObtenerEmpresas", p, ConstructorEntidad);
        }

        public static List<EmpresaLicencia> MostrarLicencia(int RutEmpresa)
        {
            Parametro pp = new Parametro("@rut", RutEmpresa);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_MapaEmpresaLicencia_1", pp, EntidadLicencia);
        }
        public static List<Empresa> ListarEmpresa()
        {
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_ListarEmpresas", ConstructorEntidad);
        }

        public static List<EmpresaLicenciaA> MostrarLicenciaVigentes(int RutEmpresa)
        {
            Parametro ppp = new Parametro("@rut", RutEmpresa);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_MapaEmpresaLicencia_2", ppp, EntidadLicenciaVigente);
        }
        public static List<EmpresaLicenciaB> MostrarLicenciasPagadas(int RutEmpresa)
        {
            Parametro LP = new Parametro("@rut", RutEmpresa);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_MapaEmpresaLicencia_3", LP, EntidadLicenciaPagadas);
        }
        public static List<EmpresaLicenciaC> MostrarLicenciaTop20(int RutEmpresa)
        {
            Parametro Top = new Parametro("@rut", RutEmpresa);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_MapaEmpresaLicencia_4", Top, EntidadLicenciaTop20);
        }
        public static List<EmpresaBeneficio_A> MostrarBeneficio(int RutEmpresa)
        {
            Parametro Bene = new Parametro("@rut", RutEmpresa);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_MapaEmpresaBeneficio_1", Bene, EntidadBeneficio_A);
        }
        public static List<EmpresaBeneficio_B>MostrarBeneficioB(int RutEmpresa)
        {
            Parametro Bene2 = new Parametro("@rut", RutEmpresa);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_MapaEmpresaBeneficio_2", Bene2, EntidadBeneficio_B);
        }
        public static List<EmpresaClasif> ListarEmpresaCla(int Periodo)
        {
            Parametro per = new Parametro("@Periodo", Periodo);
            return DBHelper.InstanceReporteria.ObtenerColeccion("sp_ListarEmpresaClasificacion_Desa", per, ConstructorClasificacion);
        }
        private static Empresa ConstructorEntidad(DataRow row)
        {
            return new Empresa
            {
                Id = row["Empresa_Rut"] != DBNull.Value ? Convert.ToInt32(row["Empresa_Rut"]) : 0,
                Dv = row["Empresa_Dv"] != DBNull.Value ? row["Empresa_Dv"].ToString() : string.Empty,
                NombreEmpresa = row["EmpresaNombre"] != DBNull.Value ? row["EmpresaNombre"].ToString() : string.Empty,
                HoldingEmpresa = row["Holding"] != DBNull.Value ? row["Holding"].ToString() : string.Empty,
                SectorEcoEmpresa = row["SectorEconomico"] != DBNull.Value ? row["SectorEconomico"].ToString() : string.Empty,
                TipoEntidadEmpresa = row["Tipo_empresa"] != DBNull.Value ? row["Tipo_empresa"].ToString() : string.Empty,
                ClasificacionComercial = row["ClaComercialEmpresa"] != DBNull.Value ? row["ClaComercialEmpresa"].ToString() : string.Empty,
                TotalAfiliados = row["Cantidad_Trabajadores"] != DBNull.Value ? row["Cantidad_Trabajadores"].ToString() : string.Empty,
                Rut_DV = row["Rut_DV"] != DBNull.Value ? row["Rut_DV"].ToString() : string.Empty,
                Fecha_ProcesoEmpresa = row["Fecha_Proceso"] != DBNull.Value ? row["Fecha_Proceso"].ToString() : string.Empty,
                Creditos_Vigentes = row["CreditosVigentes"] != DBNull.Value ? row["CreditosVigentes"].ToString() : string.Empty,
                Credito_Saldo_Vigente = row["Credito_Saldo_Vigente"] != DBNull.Value ? row["Credito_Saldo_Vigente"].ToString() : string.Empty,
                Credito_Mes = row["Credito_Mes"] != DBNull.Value ? row["Credito_Mes"].ToString() : string.Empty,
                Credito_Mes_Saldo = row["Credito_Mes_Saldo"] != DBNull.Value ? row["Credito_Mes_Saldo"].ToString() : string.Empty,
                penetracion = row["penetracion"] != DBNull.Value ? row["penetracion"].ToString() : string.Empty
                //Convert.ToDouble(row["penetracion"]):0

            };
        }
        private static EmpresaLicencia EntidadLicencia(DataRow row)
        {
            return new EmpresaLicencia
            {
                Descripcion = row["Descripcion"] != DBNull.Value ? row["Descripcion"].ToString() : string.Empty,
                FecInicio = row["Licencia_fInicio"] != DBNull.Value ? row["Licencia_fInicio"].ToString() : string.Empty,
                FecFinAnio = row["Licencia_fInicio_Año"] != DBNull.Value ? row["Licencia_fInicio_Año"].ToString() : string.Empty,
                Porcentaje = row["porcentaje"] != DBNull.Value ? Convert.ToSingle(row["porcentaje"]) : 0,
                Item = row["Item"] != DBNull.Value ? Convert.ToInt32(row["Item"]) : 0

            };
        }
        private static EmpresaLicenciaA EntidadLicenciaVigente(DataRow row)
        {
            return new EmpresaLicenciaA
            {
                empresaRut = row["Empresa_Rut"] != DBNull.Value ? Convert.ToInt32(row["Empresa_Rut"]) : 0,
                fInicio = row["Licencia_fInicio"] != DBNull.Value ? row["Licencia_fInicio"].ToString() : string.Empty,
                fAnio = row["Licencia_fInicio_Año"] != DBNull.Value ? row["Licencia_fInicio_Año"].ToString() : string.Empty,
                Isegmento = row["iSegmento"] != DBNull.Value ? Convert.ToInt32(row["iSegmento"]) : 0,
                Descripcion = row["Descripcion"] != DBNull.Value ? row["Descripcion"].ToString() : string.Empty,
                Valor = row["Valor"] != DBNull.Value ? Convert.ToInt32(row["Valor"]) : 0
            };
        }
        private static EmpresaLicenciaB EntidadLicenciaPagadas(DataRow row)
        {
            return new EmpresaLicenciaB
            {
                fInicio = row["Licencia_fInicio"] != DBNull.Value ? row["Licencia_fInicio"].ToString() : string.Empty,
                Anio = row["Licencia_fInicio_Año"] != DBNull.Value ? row["Licencia_fInicio_Año"].ToString() : string.Empty,
                Lpagadas = row["Licencias_Pagadas"] != DBNull.Value ? Convert.ToInt32(row["Licencias_Pagadas"]) : 0,
                LNoPagadas = row["Licencias_No_Pagadas"] != DBNull.Value ? Convert.ToInt32(row["Licencias_No_Pagadas"]) : 0
            };
        }
        private static EmpresaLicenciaC EntidadLicenciaTop20(DataRow row)
        {
            return new EmpresaLicenciaC
            {
                Descripcion = row["Licencia_DiagnosticoDesc"] != DBNull.Value ? row["Licencia_DiagnosticoDesc"].ToString() : string.Empty,
                Cantidad = row["Cantidad"] != DBNull.Value ? Convert.ToInt32(row["Cantidad"]) : 0,
                Diagnostico = row["Descripcion"] != DBNull.Value ? row["Descripcion"].ToString() : string.Empty,
            };
        }
        private static EmpresaBeneficio_A EntidadBeneficio_A(DataRow row)
        {
            return new EmpresaBeneficio_A
            {
                Fecha = row["Fecha_Beneficio"] != DBNull.Value ? row["Fecha_Beneficio"].ToString() : string.Empty,
                Descripcion = row["Descripcion"] != DBNull.Value ? row["Descripcion"].ToString() : string.Empty,
                Porcentaje = row["porcentaje"] != DBNull.Value ? Convert.ToSingle(row["porcentaje"]) : 0,
                Cantidad = row["Cantidad"] != DBNull.Value ? Convert.ToInt32(row["Cantidad"]) : 0,
                Item = row["Item"] != DBNull.Value ? Convert.ToInt32(row["Item"]) : 0
            };
        }
        private static EmpresaBeneficio_B EntidadBeneficio_B(DataRow row)
        {
            return new EmpresaBeneficio_B
            {
                total = row["Total"] != DBNull.Value ? Convert.ToInt32(row["Total"]) : 0,
                concepto = row["concepto_CDG"] != DBNull.Value ? row["concepto_CDG"].ToString() : string.Empty,

            };
        }

        private static EmpresaClasif ConstructorClasificacion(DataRow row)
        {
            return new EmpresaClasif
            {
                Periodo = row["Periodo"] != DBNull.Value ? row["Periodo"].ToString() : string.Empty,
                RutEmp = row["RutEmpresa"] != DBNull.Value ? Convert.ToInt32(row["RutEmpresa"]) : 0,
                NomEmpresa = row["NombreEmpresa"] != DBNull.Value ? row["NombreEmpresa"].ToString() : string.Empty,
                TipoEmpresa = row["TipoEmpresa"] != DBNull.Value ? row["TipoEmpresa"].ToString() : string.Empty,
                NumTrabEmp = row["Trabajadores"] != DBNull.Value ? Convert.ToInt32(row["Trabajadores"]) : 0,
                Holding = row["Holding"] != DBNull.Value ? row["Holding"].ToString() : string.Empty,
                ClasFinal = row["Clasificacion_Final"] != DBNull.Value ? row["Clasificacion_Final"].ToString() : string.Empty,
                Interes = row["Interes"] != DBNull.Value ? Convert.ToInt32(row["Interes"]) : 0,
                CostoPrev = row["CostoProvision"] != DBNull.Value ? Convert.ToInt32(row["CostoProvision"]) : 0
            };
        }
    }
}
