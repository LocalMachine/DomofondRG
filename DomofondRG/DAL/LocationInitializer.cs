using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DomofondRG.Models;

namespace DomofondRG.DAL
{
    public class LocationInitializer : DropCreateDatabaseAlways<LocationContext>
    {
        protected override void Seed(LocationContext context)
        {
            // добавление регионов
            var Region = new List<Region>
            {
                new Region { RegionId = 1, RegionName = "Волгоградская область" }
            };

            Region.ForEach(r => context.Regions.Add(r));
            context.SaveChanges();


            // добавление городов
            var City = new List<City>
            {
                new City { CityId = 1, CityName = "Волгоград", RegionId = 1 }
            };

            City.ForEach(c => context.Cities.Add(c));
            context.SaveChanges();

            base.Seed(context);

        }
    }
}