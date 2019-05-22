using DomofondRG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DomofondRG.DAL
{
    public class LocationContext : DbContext
    {
        public LocationContext()
            : base("DomofondConnection") // Вызываем из конструктора базовый конструктор с параметром – именем будущей базы данных.
        {
            Database.SetInitializer(new LocationInitializer());
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}