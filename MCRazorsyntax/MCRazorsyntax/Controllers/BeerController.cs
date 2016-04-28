using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCRazorsyntax.Models;

namespace MCRazorsyntax.Controllers
{
    public class BeerController : Controller
    {
        // GET: Beer
        public ActionResult List()
        {
            return View(beers);
        }

        private static List<BeerDetailsModel> beers = new List<BeerDetailsModel>
        {
            new BeerDetailsModel {ID=1, Name="Eric", Description = "Soft and smooth", AlcoholVolume = 3.5M},
            new BeerDetailsModel {ID=1, Name="Devel", Description = "Soft and smoky", AlcoholVolume = 3.5M},
            new BeerDetailsModel {ID=1, Name="Mariastad", Description = "Hard and smooth", AlcoholVolume = 3.5M}
        };
    }
}