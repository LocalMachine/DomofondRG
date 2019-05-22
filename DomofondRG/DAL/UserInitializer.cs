using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DomofondRG.Models;

namespace DomofondRG.DAL
{
    public class UserInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {

            // добавление ролей
            var Role = new List<Role>
            {
                new Role { RoleId = 1, RoleName = "Администратор"},
                new Role { RoleId = 2, RoleName = "Пользователь"},
                new Role { RoleId = 3, RoleName = "Забанен"}
            };

            Role.ForEach(r => context.Roles.Add(r));
            context.SaveChanges();



            // добавление пользаков
            var User = new List<User>
            {
                new User { UserId = 1, Name = "Admin", Login = "regonda555@mail.ru", Password = "123", RoleId = 1},
                new User { UserId = 1, Name = "User", Login = "test@mail.ru", Password = "123", RoleId = 2},
                new User { UserId = 1, Name = "Banned", Login = "test2@mail.ru", Password = "123", RoleId = 3}
            };

            User.ForEach(u => context.Users.Add(u));
            context.SaveChanges();


            base.Seed(context);

        }
    }
}