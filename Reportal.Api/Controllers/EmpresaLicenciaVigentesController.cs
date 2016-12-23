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
    public class EmpresaLicenciaVigentesController : ApiController
    {
        public ContenedorBaseLicenciaVi Get(int id)
        {
            List<EmpresaLicenciaA> Todos = EmpresaDataAccess.MostrarLicenciaVigentes(id);
            List<string> Encs = Todos.Select(t => t.fInicio).Distinct().ToList();
            List<EmpresaLicenciaA> LicAutorizada = Todos.Where(t => t.Isegmento == 1).ToList();
            List<EmpresaLicenciaA> LicPendientes = Todos.Where(t => t.Isegmento == 2).ToList();
            List<EmpresaLicenciaA> LicSinDerecho = Todos.Where(t => t.Isegmento == 3).ToList();
            List<EmpresaLicenciaA> LicObjetada = Todos.Where(t => t.Isegmento == 4).ToList();
            List<EmpresaLicenciaA> LicRechazada = Todos.Where(t => t.Isegmento == 6).ToList();
            List<EmpresaLicenciaA> LicTotal = Todos.Where(t => t.Isegmento == 7).ToList();
            List<EmpresaLicenciaA> LicPagadas = Todos.Where(t => t.Isegmento == 8).ToList();
            List<EmpresaLicenciaA> LicNoPagadas = Todos.Where(t => t.Isegmento == 9).ToList();

            ContenedorBaseLicenciaVi c = new ContenedorBaseLicenciaVi();
            foreach (string e in Encs)
            {
                EncabezadoLicenciaVi enc = new EncabezadoLicenciaVi
                {
                    Mes = e
                };
                c.EncabezadoLicenciaVi.Add(enc);
            }

            foreach (EmpresaLicenciaA LA in LicAutorizada)
            {
                AuxiliarLicenciaVi LAutoriza = new AuxiliarLicenciaVi
                {
                    Valor = Convert.ToInt32(LA.Valor)
                };
                c.LicAutorizada.Add(LAutoriza);
            }

            foreach (EmpresaLicenciaA LP in LicPendientes)
            {
                AuxiliarLicenciaVi LPendiente = new AuxiliarLicenciaVi
                {
                    Valor = Convert.ToInt32(LP.Valor)
                };
                c.LicPendientes.Add(LPendiente);
            }

            foreach (EmpresaLicenciaA LS in LicSinDerecho)
            {
                AuxiliarLicenciaVi LSDerecho = new AuxiliarLicenciaVi
                {
                    Valor = Convert.ToInt32(LS.Valor)
                };
                c.LicSinDerecho.Add(LSDerecho);
            }
            foreach (EmpresaLicenciaA LO in LicObjetada)
            {
                AuxiliarLicenciaVi LObjetada = new AuxiliarLicenciaVi
                {
                    Valor = Convert.ToInt32(LO.Valor)
                };
                c.LicObjetada.Add(LObjetada);
            }
            foreach (EmpresaLicenciaA LR in LicRechazada)
            {
                AuxiliarLicenciaVi LRechazada = new AuxiliarLicenciaVi
                {
                    Valor = Convert.ToInt32(LR.Valor)
                };
                c.LicRechazada.Add(LRechazada);
            }
            foreach (EmpresaLicenciaA LT in LicTotal)
            {
                AuxiliarLicenciaVi LTotal = new AuxiliarLicenciaVi
                {
                    Valor = Convert.ToInt32(LT.Valor)
                };
                c.LicTotal.Add(LTotal);
            }
            foreach (EmpresaLicenciaA LP in LicPagadas)
            {
                AuxiliarLicenciaVi LPagadas = new AuxiliarLicenciaVi
                {
                    Valor = Convert.ToInt32(LP.Valor)
                };
                c.LicPagadas.Add(LPagadas);
            }
            foreach (EmpresaLicenciaA LNP in LicNoPagadas)
            {
                AuxiliarLicenciaVi LNoPagadas = new AuxiliarLicenciaVi
                {
                    Valor = Convert.ToInt32(LNP.Valor)
                };
                c.LicNoPagadas.Add(LNoPagadas);
            }
            return c;
        }
    }
}