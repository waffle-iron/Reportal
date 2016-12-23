using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Reportal.Data;
using Reportal.Domain;
using Reportal.Api.ActionFilters;
using System.IO;
using System.Net.Http.Headers;

namespace Reportal.Api.Controllers
{
    [RoutePrefix("api/resumenes-nominas")]
    [EnableCors(origins: "http://localhost, http://serv-55", headers: "*", methods: "*")]
    [AuthorizationRequired]
    public class ResumenesNominasController : ApiController
    {
        [HttpGet]
        [Route("resumen-cascadas-pensionados")]
        public List<ResumenCascadas> ResumenCascadasPensionados(int periodo)
        {
            return ResumenCascadasDataAccess.ObtenerResumenPensionados(periodo);
        }

        [HttpGet]
        [Route("resumen-cascadas-trabajadores")]
        public List<ResumenCascadas> ResumenCascadasTrabajadores(int periodo)
        {
            return ResumenCascadasDataAccess.ObtenerResumenTrabajadores(periodo);
        }

        [HttpGet]
        [Route("resumen-canales")]
        public List<ResumenCanal> ResumenCanal(int periodo)
        {
            return ResumenCanalDataAccess.ObtenerResumenCanal(periodo);
        }

        [HttpGet]
        [Route("resumen-nominas")]
        public ResumenBase ResumenNominas(int periodo)
        {
            ResumenBase retorno = new ResumenBase();
            retorno.ResumenNominas = ResumenNominasDataAccess.ObtenerResumen(periodo);
            retorno.RowsCanales = ResumenNominasRowDataAccess.Obtener(periodo);
            return retorno;
        }


        [HttpGet]
        [Route("descarga-archivos-zip")]
        public HttpResponseMessage DownLoad(string periodo)
        {
            string rutaSalida = System.Configuration.ConfigurationManager.AppSettings["rutaNominaSalida"]; 
            string path = System.Configuration.ConfigurationManager.AppSettings["rutaNominas"].Replace("{{periodo}}", periodo);
            if (System.IO.File.Exists(rutaSalida))
            {
                System.IO.File.Delete(rutaSalida);
            }

            try
            {
                System.IO.Compression.ZipFile.CreateFromDirectory(path, rutaSalida);
                HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
                var stream = new FileStream(rutaSalida, FileMode.Open);
                result.Content = new StreamContent(stream);
                result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/zip");
                return result;
            }
            catch (DirectoryNotFoundException ex)
            {
                HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.NotFound);
                return result;
            }
        }
    }
}
