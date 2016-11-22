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
    public class CreditoPresupuestoController : ApiController
    {
        private CredFinanciamentoTodo CredFinacT;

        public CreditoPresupuestoController()
        {
            CredFinacT = new CredFinanciamentoTodo();
        }

        public ContenedorBasePpto Get()
        {
            List<CrededitoPptoMensual> Todos = D_CredPptoMensualDataAccess.ListarByTodos();
            List<string> Encs = Todos.Select(t => t.Mes).Distinct().ToList();
            List<CrededitoPptoMensual> PresupuestoPpto = Todos.Where(t => t.iItem == 1).ToList();
            List<CrededitoPptoMensual> RealPpto = Todos.Where(t => t.iItem == 2).ToList();
            List<CrededitoPptoMensual> GapPpto = Todos.Where(t => t.iItem == 3).ToList();
            List<CrededitoPptoMensual> CumplimientoPpto = Todos.Where(t => t.iItem == 4).ToList();





            ContenedorBasePpto c = new ContenedorBasePpto();

            foreach (string e in Encs)
            {
                EncabezadoPpto enc = new EncabezadoPpto
                {
                    Mes = e
                };

                c.EncabezadoPpto.Add(enc);
            }

            foreach (CrededitoPptoMensual pto in PresupuestoPpto)
            {
                AuxiliarPpto Presu = new AuxiliarPpto
                {
                  PptoBruto = Convert.ToInt32(pto.PptoBruto),
                  PptoNeto = Convert.ToInt32(pto.PptoNeto)

                };
                c.PresupuestoPpto.Add(Presu);
            }
            foreach (CrededitoPptoMensual real in RealPpto)
            {
                AuxiliarPpto Real = new AuxiliarPpto
                {
                    PptoBruto = Convert.ToInt32(real.PptoBruto),
                    PptoNeto = Convert.ToInt32(real.PptoNeto)

                };
                c.RealPpto.Add(Real);
            }
            foreach (CrededitoPptoMensual gap in GapPpto)
            {
                AuxiliarPpto Gap = new AuxiliarPpto
                {
                    PptoBruto = Convert.ToInt32(gap.PptoBruto),
                    PptoNeto = Convert.ToInt32(gap.PptoNeto)

                };
                c.GapPpto.Add(Gap);
            }
            foreach (CrededitoPptoMensual cum in CumplimientoPpto)
            {
                AuxiliarPpto Cumppto = new AuxiliarPpto
                {
                    PptoBruto = Convert.ToInt32(cum.PptoBruto),
                    PptoNeto = Convert.ToInt32(cum.PptoNeto)

                };
                c.CumplimientoPpto.Add(Cumppto);
            }

            return c;

        }
    }
}