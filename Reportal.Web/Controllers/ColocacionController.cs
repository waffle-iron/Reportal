using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Principal;
using Reportal.Web.Models.Caller;
namespace Reportal.Web.Controllers
{
    public class ColocacionController : Controller
    {
        private ColocCaller col;
        // GET: Colocacion

        public ColocacionController()
        {
            col = new ColocCaller();
        }
        public ActionResult Colocaciones()
        {
            return View();
        }
    }
}