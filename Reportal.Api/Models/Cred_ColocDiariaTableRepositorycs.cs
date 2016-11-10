using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class Cred_ColocDiariaTableRepositorycs
    {
        public List<Cred_ColocDiariaTable> Listar(int Periodo)
        {
            return Cred_ColocDiariaTableDataAccess.ListarCred_ColocDiariaTable(Periodo);
        }

    }
}