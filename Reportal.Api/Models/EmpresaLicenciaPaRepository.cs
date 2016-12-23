using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;
namespace Reportal.Api.Models
{
    public class EmpresaLicenciaPaRepository
    {
        public List<EmpresaLicenciaB> ListarLicenciaPagadas(int RutEmpresa)
        {
            return EmpresaDataAccess.MostrarLicenciasPagadas(RutEmpresa);

        }

    }
}