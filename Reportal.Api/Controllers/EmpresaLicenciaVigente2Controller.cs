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
    public class EmpresaLicenciaVigentes2Controller : ApiController
    {
        public ContenedorBaseLicenciaVi2 Get(int id)
        {
            List<EmpresaLicenciaD> Todos2 = EmpresaDataAccess.MostrarLicenciaVigentesA(id);
            List<string> Encs = Todos2.Select(t => t.fInicio2).Distinct().ToList();
            List<EmpresaLicenciaD> LicAutorizada2 = Todos2.Where(t => t.Isegmento2 == 1).ToList();
            List<EmpresaLicenciaD> LicPendientes2 = Todos2.Where(t => t.Isegmento2 == 2).ToList();
            List<EmpresaLicenciaD> LicSinDerecho2 = Todos2.Where(t => t.Isegmento2 == 3).ToList();
            List<EmpresaLicenciaD> LicObjetada2 = Todos2.Where(t => t.Isegmento2== 4).ToList();
            List<EmpresaLicenciaD> LicRechazada2 = Todos2.Where(t => t.Isegmento2 == 6).ToList();
            List<EmpresaLicenciaD> LicPagadas2 = Todos2.Where(t => t.Isegmento2 == 8).ToList();
            List<EmpresaLicenciaD> LicNoPagadas2 = Todos2.Where(t => t.Isegmento2 == 9).ToList();

            ContenedorBaseLicenciaVi2 c = new ContenedorBaseLicenciaVi2();
            foreach (string e in Encs)
            {
                EncabezadoLicenciaVi2 enc = new EncabezadoLicenciaVi2
                {
                    Mes = e
                };
                c.EncabezadoLicenciaVi2.Add(enc);
            }

            foreach (EmpresaLicenciaD LA in LicAutorizada2)
            {
                AuxiliarLicenciaVi2 LAutoriza2 = new AuxiliarLicenciaVi2
                {
                    Valor = Convert.ToDecimal(LA.Valor2)
                };
                c.LicAutorizada2.Add(LAutoriza2);
            }

            foreach (EmpresaLicenciaD LP in LicPendientes2)
            {
                AuxiliarLicenciaVi2 LPendiente2 = new AuxiliarLicenciaVi2
                {
                    Valor = Convert.ToDecimal(LP.Valor2)
                };
                c.LicPendientes2.Add(LPendiente2);
            }

            foreach (EmpresaLicenciaD LS in LicSinDerecho2)
            {
                AuxiliarLicenciaVi2 LSDerecho2 = new AuxiliarLicenciaVi2
                {
                    Valor = Convert.ToDecimal(LS.Valor2)
                };
                c.LicSinDerecho2.Add(LSDerecho2);
            }
            foreach (EmpresaLicenciaD LO in LicObjetada2)
            {
                AuxiliarLicenciaVi2 LObjetada2 = new AuxiliarLicenciaVi2
                {
                    Valor = Convert.ToDecimal(LO.Valor2)
                };
                c.LicObjetada2.Add(LObjetada2);
            }
            foreach (EmpresaLicenciaD LR in LicRechazada2)
            {
                AuxiliarLicenciaVi2 LRechazada2 = new AuxiliarLicenciaVi2
                {
                    Valor = Convert.ToDecimal(LR.Valor2)
                };
                c.LicRechazada2.Add(LRechazada2);
            }
        
            foreach (EmpresaLicenciaD LP in LicPagadas2)
            {
                AuxiliarLicenciaVi2 LPagadas2 = new AuxiliarLicenciaVi2
                {
                    Valor = Convert.ToDecimal(LP.Valor2)
                };
                c.LicPagadas2.Add(LPagadas2);
            }
            foreach (EmpresaLicenciaD LNP in LicNoPagadas2)
            {
                AuxiliarLicenciaVi2 LNoPagadas2= new AuxiliarLicenciaVi2
                {
                    Valor = Convert.ToDecimal(LNP.Valor2)
                };
                c.LicNoPagadas2.Add(LNoPagadas2);
            }
            return c;
        }
    }
}