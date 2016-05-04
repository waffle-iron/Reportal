using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 

namespace Reportal.Web.Models.Json
{    
    public class Menu
    {
        public string titulo { get; set; }
        public string url { get; set; }
        public string icono { get; set; }
        public List<Menu> children { get; set; }
        public bool selected { get; set; }
    }

    public class ListMenu : List<Menu>
    {

    }

    public class MenuActions
    {

        private List<Menu> resursiveTree(System.Web.Helpers.DynamicJsonArray s)
        {
            //System.Collections.Specialized.data
            //Menu mn = new Menu();
            List<Menu> ret = new List<Menu>();
            if(s != null)
            {
                foreach (dynamic e in s)
                {
                    Menu mn = new Menu();
                    mn.icono = e.icono;
                    mn.titulo = e.titulo;
                    mn.url = e.url;
                    mn.children = e.children != null ? this.resursiveTree(e.children) : null;

                    ret.Add(mn);
                }
            }

            return ret;
        }

        public List<Menu> ListMenus()
        {
            string path = HttpContext.Current.Server.MapPath("~/App_Conf/temporal/menu_izquierdo.json");
            string texto_json = System.IO.File.ReadAllText(path);
            var ajson = System.Web.Helpers.Json.Decode(texto_json);

            List<Menu> ls = this.resursiveTree(ajson);
            return ls;
        }

        public List<Menu> ListMenusPublicado()
        {
            string path = HttpContext.Current.Server.MapPath("~/App_Conf/publicado/menu_izquierdo.json");
            string texto_json = System.IO.File.ReadAllText(path);
            var ajson = System.Web.Helpers.Json.Decode(texto_json);

            List<Menu> ls = this.resursiveTree(ajson);
            return ls;
        }

        public void SaveJsonFile(string jsonText)
        {

            if (string.IsNullOrEmpty(jsonText))
            {
                throw new Exception("JSON de entrada no puede ser vacío");
            }

            string path = HttpContext.Current.Server.MapPath("~/App_Conf/temporal/menu_izquierdo.json");
            System.IO.File.WriteAllText(path, jsonText);
        }

        public void PublicJsonFile(string jsonText)
        {
            if (string.IsNullOrEmpty(jsonText))
            {
                throw new Exception("JSON de entrada no puede ser vacío");
            }

            string path = HttpContext.Current.Server.MapPath("~/App_Conf/publicado/menu_izquierdo.json");
            string pathRespaldo = HttpContext.Current.Server.MapPath("~/App_Conf/historico/menu_izquierdo["+DateTime.Now.ToString("yyyyMMddHHmmss") +"].json");

            /*Respaldo actual y publico nuevo*/
            System.IO.File.Copy(path, pathRespaldo);
            System.IO.File.WriteAllText(path, jsonText);
        }

    }
    

}