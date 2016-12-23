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

    }
}