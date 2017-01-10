using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Principal;
using Reportal.Web.Models.Caller;

namespace Reportal.Directorio.Web.Controllers
{
    public class EmpresasController : Controller
    {
        private EmpCaller emp;
        // GET: Empresas

        public EmpresasController()
        {
            emp = new EmpCaller();
        }


        public ActionResult MapaEmpresas()
        {
            return View();
        }

        public ActionResult DetalleMapaEmpresa(int id)
        {
            //ViewBag.Campania = emp.Get(id);
            ViewBag.Empresa = emp.Get(id);
            return View();
        }

        public ActionResult ClasificacionEmpresa()
        {

            return View();
        }

    }
}