using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandyMVCProject.Models;

namespace CandyMVCProject.Controllers
{
    public class CandyController : Controller
    {
        // GET: Candy
        public ActionResult CandyDetails()
        {
            var candy = new CandyModel
            {
                Name = "Cola Nappar",
                Flavour = "Cola",
                SugarAmount = "20 gram"
            };
            return View(candy);
        }
    }
}