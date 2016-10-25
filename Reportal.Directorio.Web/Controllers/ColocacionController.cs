using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Principal;
using Reportal.Directorio.Web.Models.Caller;

namespace Reportal.Directorio.Web.Controllers
{
    public class ColocacionController : Controller
    {
        // GET: Colocacion
        public ActionResult Colocaciones()
        {
            return View();
        }
    }
}