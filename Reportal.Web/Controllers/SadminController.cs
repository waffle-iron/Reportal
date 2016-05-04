using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CDK.Json;

namespace Reportal.Web.Controllers
{
    public class SadminController : Controller
    {

        public SadminController()
        {

        }

        // GET: Sadmin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sadmin/Menus
        public ActionResult Menus()
        {

            Reportal.Web.Models.Json.MenuActions mna = new Models.Json.MenuActions();
            ViewBag.json_data = mna.ListMenus();

            return View();
        }

        [HttpPost]
        public JsonResult Guardarmenu(string jsonOfdt, string opcion)
        {
            JsonProcessResult res = JsonProcessResult.Instance;
            try
            {
                string datojson = Convert.ToString(jsonOfdt);
                
                Reportal.Web.Models.Json.MenuActions mn = new Models.Json.MenuActions();

                if (opcion.Equals("publicar"))
                {
                    mn.SaveJsonFile(datojson);
                    mn.PublicJsonFile(datojson);
                    res.Title = "Publicación Correcta";
                    res.Message = "Cambios publicados con éxito!!";
                }
                else
                {
                    mn.SaveJsonFile(datojson);
                    res.Title = "Guardado Correcto";
                    res.Message = "Cambios guardados con éxito!!";
                }
                /*Resultado OK*/
                res.Result = ResultType.OK;
            }
            catch(Exception ex)
            {
                /*Resultado Con Excepccion, despliega mensaje de error [hay que clasificar los errores para la base de conocimientos]*/
                res.Message = "Detalle Error: " + ex.Message;
                res.Result = ResultType.ERR;
            }

            return Json(res,JsonRequestBehavior.AllowGet);
        }

    }
}