﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;
namespace Reportal.Api.Models
{
    public class EmpresaRepository
    {
     
        public Empresa Obtener(int id)
        {
            //return CampaniaDataAccess.Obtener(id);
            return EmpresaDataAccess.Obtener(id);

        }
        public List<Empresa> Listar()
        {
            return EmpresaDataAccess.ListarEmpresa();
        }

        public IdentidadDetalleEmpresa ObtenerDetalle(int id)
        {
            return DetalleEmpresaDataAccess.Obtener(id);
        }
        
        public IdentidadEncabezadoEmpresa ObtenerEncabezado(int id)
        {
            return EncabezadoEmpresaDataAccess.ObtenerEncabezado(id);
        }

        public List<EmpresaLicenciaC> ListarLicenciaTop20(int RutEmpresa)
        {
            return EmpresaDataAccess.MostrarLicenciaTop20(RutEmpresa);

        }
        public List<EmpresaBeneficio_B> ListarBeneficio2(int RutEmpresa)
        {
            return EmpresaDataAccess.MostrarBeneficioB(RutEmpresa);
        }
        public List<EmpresaClasif> ListarClas(int Periodo)
        {
            return EmpresaDataAccess.ListarEmpresaCla(Periodo);
        }
    }
}