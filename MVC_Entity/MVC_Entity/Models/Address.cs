using System.Collections.Generic;

namespace MVC_Entity.Models
{
    public class Address
    {


        public Address()
        {

        }
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public List<Person> Persons { get; set; }

    }
}