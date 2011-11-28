using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PluralSightMVC.Models;

namespace PluralSightMVC.Controllers
{
    public class ReviewController : Controller
    {
        //
        // GET: /Review/
        FoodDb _db = new FoodDb();

        public ActionResult Index()
        {
            var model = _db.getList();
            return View(model);
        }

        //
        // GET: /Review/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Review/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Review/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Review/Edit/5
 
        public ActionResult Edit(int id)
        {
            var review = _db.getById(id);
            return View(review);            
        }

        //
        // POST: /Review/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = new ResturantReview();
            review.id = id;
            review.Name = "FUCKING WORK";


           // review.Name = collection.GetValue("Name");

            _db.addValue(review);

            //UpdateModel(review);
            
            return RedirectToAction("Index");
            /*if (TryUpdateModel(review))
            {
                return RedirectToAction("Index");
            }
            
                return View(review);
            */
        }

        //
        // GET: /Review/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Review/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
