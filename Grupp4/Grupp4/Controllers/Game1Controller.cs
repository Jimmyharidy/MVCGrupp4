﻿using Grupp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grupp4.Controllers
{
    public class Game1Controller : Controller
    {
        // GET: Game1
        public ActionResult Index()

        {
            var model = new Game1Model();
            model.Start();

            return View(model);
        }
        [HttpPost]

        public ActionResult Index(Game1Model model)

        {
            model.PlayerAddCurrentValue();
            if (model.PlayerIsWinner())

            {

                ViewBag.Result = "You win.";
            }
            model.ComputerAddCurrentValue();
            if (model.ComputerIsWinner())

            {
                ViewBag.Result = "Computer wins.";
                model.CurrentValue = 0;
            }
            ModelState.Remove("CurrentValue");

            return View(model);
        }

       

    }

}