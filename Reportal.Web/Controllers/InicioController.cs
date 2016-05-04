using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reportal.Web.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Index()
        {
            return View();
        }


        // GET: Inicio/Morris
        public ActionResult Morris()
        {
            return View();
        }

        // GET: Inicio/Chartjs
        public ActionResult Chartjs()
        {
            return View();
        }

        // GET: Inicio/Peity
        public ActionResult Peity()
        {
            return View();
        }
        

    }
}