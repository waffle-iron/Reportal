using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class AFEmpresaRepository
    {
        public List<AFEmpresa> ListarAFEmpresaPorRut(int RutEmpresa)
        {
            return AFEmpresaDataAccess.ListarAFEmpresa(RutEmpresa);
        }
    }
}