using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;
namespace Reportal.Api.Models
{
    public class CredCumplimiento_Neto
    {
        public List<Cred_CumplimientoPpto> Listar()
        {
            return Cred_CumplimientoPptoDataAccess.ListarCumplimientoNeto();
        }
    }
}