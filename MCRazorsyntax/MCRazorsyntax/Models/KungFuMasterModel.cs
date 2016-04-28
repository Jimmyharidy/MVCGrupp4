using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace MCRazorsyntax.Models
{
    public class KungFuMasterModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string KungFuStyle { get; set; }
        public string Level { get; set; }

    }
}