using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;
namespace Reportal.Api.Models
{
    public class CredCumplimiento_Bruto
    {
        public List<Coloc_Cumplimiento> Listar()
        {
            return Coloc_CumplimientoBrutoDataAccess.ListarCumplimientobruto();
        }
    }
}