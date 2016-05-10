using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using FiveInRow.Models;

namespace FiveInRow.Controllers
{
    public class FiveController : Controller
    {
        // GET: Five
        public ActionResult Index()
        {
            FiveRow fiveRow = new FiveRow();                        
            this.Session["Five"] = fiveRow;

            return View(fiveRow);
        }

        [HttpPost]
        public ActionResult Index(int? choice)
        {

            
            var fiveRow = (FiveRow)this.Session["Five"];            
            fiveRow.Test1(choice.Value);
            

            return View(fiveRow);
        }
    }
}