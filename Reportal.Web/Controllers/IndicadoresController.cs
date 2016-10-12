using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Principal;
using Reportal.Web.Models.Caller;

namespace Reportal.Web.Controllers
{
    public class IndicadoresController : Controller
    {

        // GET: Indicadores
        public ActionResult Index()
        {
            return View();
        }
    }
}