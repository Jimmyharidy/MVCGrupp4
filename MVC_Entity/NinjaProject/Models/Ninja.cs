using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjaProject.Models
{
    public class Ninja
    {
        public int NinjaId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Level { get; set; }
        public  List<Weapon> Weapons { get; set; }
    }
}