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
        // GET: TicTacToe
        public ActionResult Index()
        {
            var ticModel = new TicTacToeModel();
            this.Session["Tic"] = ticModel;
            return View(ticModel);

        }
        [HttpPost]
        public ActionResult Index(int? choice)
        {
            var ticModel = (TicTacToeModel) this.Session["Tic"];
            ticModel.Test(choice.Value);
            return View(ticModel);
        }
    }
}