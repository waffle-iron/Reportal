using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reportal.Domain;
using Reportal.Api.Models;
using Reportal.Data;
using System.Web.Http.Cors;
using Reportal.Api.ActionFilters;
namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    //[AuthorizationRequired]
    public class EmpresaLicenciaController : ApiController
    {

        public ContenedorBaseLicencia Get(int id)
        {
            List<EmpresaLicencia> Todos = EmpresaDataAccess.MostrarLicencia(id);
            List<string> Encs = Todos.Select(t => t.FecInicio).Distinct().ToList();
            List<EmpresaLicencia> PorcentajeEmp = Todos.Where(t => t.Item == 1).ToList();

            ContenedorBaseLicencia cbl = new ContenedorBaseLicencia();

            foreach (string e in Encs)
            {
                EncabezadoLicencia enc = new EncabezadoLicencia
                {
                    Mes = e
                };

                cbl.EncabezadoLicencia.Add(enc);
            }

            foreach (EmpresaLicencia empLic in PorcentajeEmp)
            {
                AuxiliarLicencia Porc = new AuxiliarLicencia
                {
                    PorcentajeLicencia = Convert.ToDecimal(empLic.Porcentaje)
                };
                cbl.PorcentajeLicencia.Add(Porc);
            }
            return cbl;

        }
    }
}