using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationExercise.Models;

namespace ValidationExercise.Controllers
{
    public class ReviewController : Controller
    {
        // GET: Review
        public ActionResult Add()
        {
            return View(new ReviewModel());
        }
        [HttpPost]
        public ActionResult Add(ReviewModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Added");
            }
            return View(model);
        }
        
    }
}