using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class SegPreaprobadosRepository
    {
        public List<SegPreaprobadosGlobal> ListarGlobal(int periodo)
        {
            return SegPreaprobadosGlobalDataAccess.Listar(periodo);
        }
    }
}