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

namespace Reportal.Api.Controllers
{
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class CreditoFinanciamentoController : ApiController
    {
        // GET: CreditoColoc_Diaria
        private CredFinanciamentoTodo CredFinacT;

        public CreditoFinanciamentoController()
        {
            CredFinacT = new CredFinanciamentoTodo();
        }

        public ContenedorBase Get(int id)
        {
            List<Cred_Financiamento> Todos = CreditoFinanciamentoDataAccess.Listar(id);
            List<string> Encs = Todos.Select(t => t.diaGrafico).Distinct().ToList();
            List<Cred_Financiamento> Trabajadores = Todos.Where(t => t.iSegmento == 2).ToList();
            List<Cred_Financiamento> Pensionados = Todos.Where(t => t.iSegmento == 1).ToList();
            List<Cred_Financiamento> Total = Todos.Where(t => t.iSegmento == 3).ToList();


            ContenedorBase c = new ContenedorBase();

            foreach (string e in Encs)
            {
                Encabezado enc = new Encabezado
                {
                    Mes = e
                };

                c.Encabezado.Add(enc);
            }

            foreach (Cred_Financiamento cft in Trabajadores)
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

            return c;

        }
    }
}