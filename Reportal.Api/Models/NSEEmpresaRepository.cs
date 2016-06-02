using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class NSEEmpresaRepository
    {
        public NSEEmpresa ObtenerDetalle(int id)
        {
            return NSEEmpresaDataAccess.Obtener(id);
        }
    }
}