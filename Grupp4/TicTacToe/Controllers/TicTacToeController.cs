using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicTacToe.Models;

namespace TicTacToe.Controllers
{
    public class TicTacToeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            var ticModel = new TicTacToeModel();
            Session["Tic"] = ticModel;
            return View(ticModel);
        }

        // POST: Index
        [HttpPost]
        public ActionResult Index(int choice)
        {
            if (choice == 10)
            {
                var ticModelreset = new TicTacToeModel();
                Session["Tic"] = ticModelreset;
                return View(ticModelreset);
            }
            var ticModel = (TicTacToeModel)Session["Tic"];
            ticModel.Human(choice);
            Session["Tic"] = ticModel;
            return View(ticModel);
        }


    }
}