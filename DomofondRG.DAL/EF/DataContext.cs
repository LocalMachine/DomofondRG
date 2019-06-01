using DomofondRG.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DomofondRG.DAL.EF
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<Ads> Ads { get; set; }
        public DbSet<AdsType> AdsTypes { get; set; }
        public DbSet<ObjectsType> ObjectsTypes { get; set; }
        public DbSet<RoomsType> RoomsTypes { get; set; }
        public DbSet<StatusType> StatusTypes { get; set; }

        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Photo> Photos { get; set; }


        public DataContext()
            : base("DomofondConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DataContext(string connectionString)
            : base(connectionString)
        {

        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Favorite>()
        //        .HasRequired<User>(u => u.User)
        //        .WithMany(f => f.Favorites)
        //        .WillCascadeOnDelete(true);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}