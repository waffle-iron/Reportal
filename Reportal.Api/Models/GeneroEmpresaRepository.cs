using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class GeneroEmpresaRepository
    {
        public List<GeneroEmpresa> ListaGeneroPorEmpresa(int RutEmpresa)
        {
            return GeneroEmpresaDataAccess.ListarGeneroRutEmpresa(RutEmpresa);
        }
    }
}