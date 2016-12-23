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
    [AuthorizationRequired]
    public class CredFinanciamentoTodoController : ApiController
    {
        // GET: CreditoColoc_Diaria
        private CredFinanciamentoTodo CredFinacT;

        public CredFinanciamentoTodoController()
        {
            CredFinacT = new CredFinanciamentoTodo();
        }

        public ContenedorBase Get()
        {
            List<Cred_Financiamento> Todos = CreditoFinanciamentoDataAccess.ListarByTodos();
            List<string> Encs = Todos.Select(t => t.diaGrafico).Distinct().ToList();
            List<Cred_Financiamento> Trabajadores = Todos.Where(t => t.iSegmento == 2).ToList();
            List<Cred_Financiamento> Pensionados = Todos.Where(t => t.iSegmento == 1).ToList();
            List<Cred_Financiamento> Total = Todos.Where(t => t.iSegmento == 4).ToList();
            List<Cred_Financiamento> DDirecto = Todos.Where(t => t.iSegmento == 3).ToList();


            ContenedorBase c = new ContenedorBase();
            
            foreach(string e in Encs)
            {
                Encabezado enc = new Encabezado
                {
                    Mes = e
                };

                c.Encabezado.Add(enc);
            }

            foreach(Cred_Financiamento cft in Trabajadores)
            {
                Auxiliar Trab = new Auxiliar
                {
                    Spred = Convert.ToDecimal(cft.sPread),
                    Tasa = Convert.ToDecimal(cft.tasaPromedio),
                    Pplazo = Convert.ToInt32(cft.plazoPromedio)
                };
                c.Trabajador.Add(Trab);
            }


            foreach (Cred_Financiamento cfp in Pensionados)
            {
                Auxiliar Pens = new Auxiliar
                {
                    Spred = Convert.ToDecimal(cfp.sPread),
                    Tasa = Convert.ToDecimal(cfp.tasaPromedio),
                    Pplazo = Convert.ToInt32(cfp.plazoPromedio)
                };
                c.Pensionado.Add(Pens);
            }


            foreach (Cred_Financiamento cftot in Total)
            {
                Auxiliar Totales = new Auxiliar
                {
                    Spred = Convert.ToDecimal(cftot.sPread),
                    Tasa = Convert.ToDecimal(cftot.tasaPromedio),
                    Pplazo = Convert.ToInt32(cftot.plazoPromedio)
                };
                c.Total.Add(Totales);
            }
            foreach(Cred_Financiamento cfdd in DDirecto)
            {
                Auxiliar DedudorDir = new Auxiliar
                {
                    Spred = Convert.ToDecimal(cfdd.sPread),
                    Tasa = Convert.ToDecimal(cfdd.tasaPromedio),
                    Pplazo = Convert.ToInt32(cfdd.plazoPromedio)
                };
                c.DDirecto.Add(DedudorDir);
            }

            return c;

        }
    }
}

