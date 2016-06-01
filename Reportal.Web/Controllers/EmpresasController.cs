using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reportal.Web.Controllers
{
    public class EmpresasController : Controller
    {
        // GET: Empresas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MapaEmpresas()
        {
            return View();
        }

        public ActionResult DetalleMapaEmpresa(int id)
        {
            return View();
        }
    }
}