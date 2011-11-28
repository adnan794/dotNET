using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PluralSightMVC.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        //[HttpPostAttribute]
        [HttpGet]
        //[ActionName("SearchCuisine")]
        public ActionResult Search(string name = "*")
        {
            //if (name == "*")
            //{
            //    return Json(new { cuisineName = name }, JsonRequestBehavior.AllowGet);

            //    //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            //    //return RedirectToRoute("Cuisine", new { name = "german" });
            //    //return RedirectToAction("Search", "Cuisine", new { name = "french" });
            //}
            ////var name = RouteData.Values["name"];


            name = Server.HtmlEncode(name);
            return Content(name);
        }
    }
}
