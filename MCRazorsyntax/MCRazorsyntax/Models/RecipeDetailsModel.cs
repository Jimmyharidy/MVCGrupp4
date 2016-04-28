using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCRazorsyntax.Models
{
    public class RecipeDetailsModel
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public int CookingTime { get; set; }
        public string Instructions { get; set; }
        public int Difficulty { get; set; }
    }
}