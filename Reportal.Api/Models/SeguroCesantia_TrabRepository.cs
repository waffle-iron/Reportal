using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class SeguroCesantia_TrabRepository
    {
        public List<SeguroCesantia> Listar()
        {
            return SeguroCesantia_TrabDataAcces.ListarSeguro_Trab();
        }


    }
}