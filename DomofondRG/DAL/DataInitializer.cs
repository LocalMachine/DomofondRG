using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DomofondRG.Models;

namespace DomofondRG.DAL
{
    public class DataInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            // добавление регионов
            var Region = new List<Region>
            {
                new Region { Id = 1, RegionName = "Волгоградская область" }
            };

            Region.ForEach(r => context.Regions.Add(r));
            context.SaveChanges();


            // добавление городов
            var City = new List<City>
            {
                new City { Id = 1, CityName = "Волгоград", RegionId = 1 }
            };

            City.ForEach(c => context.Cities.Add(c));
            context.SaveChanges();

            var Role = new List<Role>
            {
                new Role { Id = 1, RoleName = "Администратор"},
                new Role { Id = 2, RoleName = "Пользователь"},
                new Role { Id = 3, RoleName = "Забанен"}
            };

            Role.ForEach(r => context.Roles.Add(r));
            context.SaveChanges();



            // добавление пользаков
            var User = new List<User>
            {
                new User { Id = 1, Name = "Admin", Login = "regonda555@mail.ru", Password = "123", RoleId = 1},
                new User { Id = 1, Name = "User", Login = "test@mail.ru", Password = "123", RoleId = 2},
                new User { Id = 1, Name = "Banned", Login = "test2@mail.ru", Password = "123", RoleId = 3}
            };

            User.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            base.Seed(context);

        }
    }
}