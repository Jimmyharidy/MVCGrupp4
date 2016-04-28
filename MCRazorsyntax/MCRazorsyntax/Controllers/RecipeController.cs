using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCRazorsyntax.Models;

namespace MCRazorsyntax.Controllers
{
    public class RecipeController : Controller
    {
        // GET: Recipe
        public ActionResult FullDetails()
        {
            var recipe = new RecipeDetailsModel
            {
                Name = "Tigerkaka",
                Ingredients =
                    "Två ägg, 2dl socker. 3dl vetemjöl, 1tsk bakpulver, 1 tsk vaniljsocker, 1msk kakao, 1/2dl vatten, 150gr smör",
                CookingTime = 34,
                Instructions = "Baka den",
                Difficulty = 2
            };
            return View(recipe);
        }
    }
}