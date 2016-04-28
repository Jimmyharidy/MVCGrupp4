using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MCRazorsyntax.Models;

namespace MCRazorsyntax.Controllers
{
    public class KungFuController : Controller
    {
        // GET: KungFu
        public ActionResult FullDetails()
        {
            var masters = new List<KungFuMasterModel>
            {
                new KungFuMasterModel
                {
                    ID = 1,
                    Name = "Keith kekke",
                    Age = 30,
                    KungFuStyle = "KingTsun",
                    Level = "Master of comprehension"
                },
                new KungFuMasterModel
                {
                    ID = 2,
                    Name = "Keith hahaha",
                    Age = 65,
                    KungFuStyle = "TsaoTsun",
                    Level = "Master of comprehension"
                },
                new KungFuMasterModel
                {
                    ID = 3,
                    Name = "Keith tatata",
                    Age = 99,
                    KungFuStyle = "MingTsun",
                    Level = "Master of comprehension"
                },
            };
            return View(masters);

        }

        public ActionResult Stars()
        {
            return View();
        }

        public ActionResult StarsSoCadd()
        {
            return View();
        }
    }

    public static class ExtensionMethods
        {
            public static string RatingStars(this HtmlHelper helper, int numberOfStars)
            {
                StringBuilder oh = new StringBuilder();
                oh.Append("< span style = 'color: orange'>");
                for (int i = 0; i < numberOfStars; i++)
                {
                    oh.Append("*");
                }
                oh.Append("</span>");
                return oh.ToString();
            }
        }
    }
