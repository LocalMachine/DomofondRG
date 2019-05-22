using DomofondRG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DomofondRG.DAL
{
    public class UserContext : DbContext
    {
        public UserContext()
           : base("DomofondConnection") // Вызываем из конструктора базовый конструктор с параметром – именем будущей базы данных.
        {
            Database.SetInitializer(new UserInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}