using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;
namespace Reportal.Api.Models
{
    public class CicloEmpresaRepository
    {

        public List<CicloVidaEmpresa> ListarPorRutEmpresa(int RutEmpresa)
        {
            return CicloVidaEmpresaDataAccess.ListarPorRutEmpresa(RutEmpresa);
        }
    }
}