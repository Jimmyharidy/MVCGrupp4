using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;

namespace Kiosk.Models
{
    public class Kiosken
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}