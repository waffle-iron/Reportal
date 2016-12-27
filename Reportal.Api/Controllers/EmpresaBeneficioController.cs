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
    public class EmpresaBeneficioController : ApiController
    {
        public ContenedorBaseBeneficio Get(int id)
        {
            List<EmpresaBeneficio_A> Todos = EmpresaDataAccess.MostrarBeneficio(id);
            List<string> Encs = Todos.Select(t => t.Fecha).Distinct().ToList();
            List<EmpresaBeneficio_A> PorcentajeBeneficio = Todos.Where(t => t.Item == 1).ToList();
            List<EmpresaBeneficio_A> CantidadBenefinicio = Todos.Where(t => t.Item == 1).ToList();

            ContenedorBaseBeneficio cbl = new ContenedorBaseBeneficio();

            foreach (string e in Encs)
            {
                EncabezadoBeneficio enc = new EncabezadoBeneficio
                {
                    Mes = e
                };
                cbl.EncabezadoBeneficio.Add(enc);
            }

            foreach (EmpresaBeneficio_A empBene in PorcentajeBeneficio)
            {
                AuxiliarBeneficio Porc = new AuxiliarBeneficio
                {
                    PorcentajeBeneficio = Convert.ToDecimal(empBene.Porcentaje)
                };
                cbl.PorcentajeBeneficio.Add(Porc);
            }
            foreach (EmpresaBeneficio_A emprBeneCa in CantidadBenefinicio)
            {
                AuxiliarBeneficio CantBenef = new AuxiliarBeneficio
                {
                    CantidadBeneficio = Convert.ToInt32(emprBeneCa.Cantidad)
                };
                cbl.CantidadBeneficio.Add(CantBenef);
            }
            return cbl;
        }
    }
}