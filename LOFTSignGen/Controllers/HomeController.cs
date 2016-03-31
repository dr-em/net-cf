using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LOFTSignGen.Models;
using System.IO;

namespace LOFTSignGen.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Generator()
        {
            return View();
        }

        public ActionResult Generate(InfoViewModel vm)
        {
            if (!ModelState.IsValid)
                return View("Generator");
            else
            {
                byte[] bArray = System.Text.Encoding.UTF8.GetBytes(RenderRazorViewToString("_Template", vm));
                return File(bArray, "text/html", string.Format("Signature_LOFT_{0}.html", vm.Name.Replace(" ","_")));
            }
        }

        public string RenderRazorViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext,
                                                                         viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View,
                                             ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}