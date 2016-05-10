using System.Web.Mvc;
using Game21V2.Models;

namespace Game21V2.Controllers
{
    public class Game21Controller : Controller
    {
        // GET: Game21
        public ActionResult Index()
        {
            var game21 = new GameOf21();
            this.Session["game21"] = game21;

            return View(game21);
        }

        [HttpPost]
        public ActionResult Index(int? add)
        {
            var game21 = (GameOf21)this.Session["game21"];
            game21.AddNr(add.Value);
            return View(game21);
        }

    }
}