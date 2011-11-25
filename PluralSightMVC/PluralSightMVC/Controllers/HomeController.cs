using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PluralSightMVC.Models;

namespace PluralSightMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = string.Format("{0}::{1}{2}",
                                RouteData.Values["controller"],
                                RouteData.Values["action"],
                                RouteData.Values["id"]

                                );
                

            var model = new ResturantReview()
            {
                Name = "Iqbal Tikka",
                Rating = 8
            };

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
