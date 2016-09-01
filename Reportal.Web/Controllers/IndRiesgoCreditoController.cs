using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using SelectPdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
using iTextSharp.tool.xml;
using iTextSharp.tool.xml.pipeline.html;
using iTextSharp.tool.xml.pipeline.css;
using iTextSharp.tool.xml.html;
using System.Text;
using iTextSharp.tool.xml.pipeline.end;
using iTextSharp.tool.xml.parser;

namespace Reportal.Web.Controllers
{
    public class IndRiesgoCreditoController : Controller
    {
        // GET: IndRiesgoCredito
        public ActionResult Index()
        {
            return View();
        }


        // GET: IndRiesgoCredito/GeneraPdf
        //[HttpPost]
        [ValidateInput(false)]
        public ActionResult GeneraPdf(string contenido_pdf)
        {
            //contenido_pdf = contenido_pdf.Replace("<table", @"<table style=""border: 1px solid black""").Replace("<td", @"<td style=""border: 1px solid black""");

            //contenido_pdf = contenido_pdf.Replace("<table", @"<table border=""1"" style=""border-collapse:collapse;""");
            ViewBag.contenido_pdf = contenido_pdf;

            var output = new MemoryStream();

            var input = new MemoryStream(Encoding.UTF8.GetBytes(contenido_pdf));

            var document = new Document(PageSize.LEGAL, 5, 5, 5, 5);
            var writer = PdfWriter.GetInstance(document, output);
            writer.CloseStream = false;

            document.Open();
            var htmlContext = new HtmlPipelineContext(null);
            htmlContext.SetTagFactory(Tags.GetHtmlTagProcessorFactory());

            ICSSResolver cssResolver = XMLWorkerHelper.GetInstance().GetDefaultCssResolver(false);
            cssResolver.AddCssFile(System.Web.HttpContext.Current.Server.MapPath("~/assets/css/bootstrap.min.css"), true);
            cssResolver.AddCssFile(System.Web.HttpContext.Current.Server.MapPath("~/assets/css/core.css"), true);

            var pipeline = new CssResolverPipeline(cssResolver, new HtmlPipeline(htmlContext, new PdfWriterPipeline(document, writer)));
            var worker = new XMLWorker(pipeline, true);
            var p = new XMLParser(worker);
            p.Parse(input);
            document.Close();
            output.Position = 0;

            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", string.Format("attachment;filename=Salida-{0}.pdf", "CharLee"));
            Response.BinaryWrite(output.ToArray());


            return View();
        }
    }
}