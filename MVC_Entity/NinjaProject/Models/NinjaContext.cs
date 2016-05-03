using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NinjaProject.Models
{
    public class NinjaContext : DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        public NinjaContext() : base("Ninja")
        {
            Database.SetInitializer<NinjaContext>(new NinjaInitializer());
        }
    }

    public class NinjaInitializer : DropCreateDatabaseAlways<NinjaContext>
    {
        protected override void Seed(NinjaContext context)
        {
            var ninjas = new List<Ninja>()
            {
               new Ninja() {NinjaId = 1, Name = "Peter", Age = 29, Level = "Master"},
               new Ninja() {NinjaId = 2, Name = "Jimmy", Age = 32, Level = "Pro"},
               new Ninja() {NinjaId = 3, Name = "Ivan", Age = 26, Level = "Noobie"},
               new Ninja() {NinjaId = 4, Name = "Sebbe", Age = 25, Level = "Disaster"}
            };
            foreach (var ninja in ninjas)
                context.Ninjas.Add(ninja);
            context.SaveChanges();

            var weapons = new List<Weapon>()
            {
                new Weapon() {WeaponId = 1, Name = "Sword", Range = 2, Weight = 8},
                new Weapon() {WeaponId = 2, Name = "Nunchaku", Range = 1, Weight = 3},
                new Weapon() {WeaponId = 3, Name = "Throwing star", Range = 30, Weight = 0.5},
                new Weapon() {WeaponId = 4, Name = "Sai", Range = 1, Weight = 2},
            };
            foreach (var weapon in weapons)
                context.Weapons.Add(weapon);
            context.SaveChanges();
        }
    }
}