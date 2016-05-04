using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Principal;
using Reportal.Web.Models.Caller;

namespace Reportal.Web.Controllers
{
    
    public class CampañasController : Controller
    {
        private CampCaller cmp;

        public CampañasController()
        {
            cmp = new CampCaller();
        }
        // GET: Campañas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contactabilidad()
        {
            return View();
        }

        public ActionResult DetalleCampania(int id)
        {
            ViewBag.Campania = cmp.Get(id);

            return View();
        }

    }
}