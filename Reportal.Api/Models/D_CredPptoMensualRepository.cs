using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;
namespace Reportal.Api.Models
{
    public class D_CredPptoMensualRepository
    {
        public List<D_CredPptoMensual> Listar()
        {
            return D_CredPptoMensualDataAccess.ListarD_CredPptoMensual();
        }

        public List<CrededitoPptoMensual> ListarByGrafico()
        {
            return D_CredPptoMensualDataAccess.ListarByGrafico();
        }
    }
}