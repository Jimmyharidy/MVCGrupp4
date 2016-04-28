using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OvningMVC.Models;

namespace OvningMVC.Controllers
{
    public class AbbreviationController : Controller
    {
        // GET: Abbreviation
        public ActionResult SingleAbbreviation()
        {
            var abbreviation = new Abbreviations
            {
                Abbr = "Soc",
                Title = "Separation Of Concern"

            };

            return View(abbreviation);
        }

        public ActionResult AbbreviationList()
        {
            var mylist = new List<Abbreviations>
            {
                new Abbreviations() {Abbr = "CRUD", Title = "Create Read Update Delete"},
                new Abbreviations() {Abbr = "RTFM", Title = "Read The Fucking Manual"},
                new Abbreviations() {Abbr = "IP", Title = "Ivan Prgomet"}
            };
            return View(mylist);
        }
        public ActionResult AbbreviationList2()
        {
            var mylist = new List<Abbreviations>
            {
                new Abbreviations() {Abbr = "CRUD", Title = "Create Read Update Delete"},
                new Abbreviations() {Abbr = "RTFM", Title = "Read The Fucking Manual"},
                new Abbreviations() {Abbr = "IP", Title = "Ivan Prgomet"}
            };
            return View(mylist);
        }
    }
}