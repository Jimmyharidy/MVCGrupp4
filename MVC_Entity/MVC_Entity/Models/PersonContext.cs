using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace MVC_Entity.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("PersonDataBase")
        {
            Database.SetInitializer<PersonContext>(new PersonInitializer());

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }

    public class PersonInitializer : DropCreateDatabaseAlways<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var persons = new List<Person>()
            {
                new Person() {PersonId = 1, Name = "Kalle Hansson", DateOfBirth = new DateTime(1984,4,28), Height = 176.00M, Weight = 75.00M},
                new Person() {PersonId = 2, Name = "Jimmy Haridy",  DateOfBirth = new DateTime(1985,3,20), Height = 180.00M, Weight = 85.00M},
                new Person() {PersonId = 3, Name = "Peter Svantesson",  DateOfBirth = new DateTime(1958,12,30), Height = 186.00M, Weight = 98.00M}
            };
            foreach (var person in persons)
            {
                context.Persons.Add(person);
            }
            context.SaveChanges();

            var addresses = new List<Address>()
            {
                new Address() {AddressId = 1, City = "Helsingborg", Street = "Lutandevägen 7C", Zip = "25247"},
                new Address() {AddressId = 1, City = "Göteborg", Street = "Kallevägen 7C", Zip = "25789"},
                new Address() {AddressId = 1, City = "Malmö", Street = "Lundavägen 85", Zip = "26384"}
            };
            foreach (var address in addresses)
            {
                context.Addresses.Add(address);
            }
            context.SaveChanges();

        }

    }

}