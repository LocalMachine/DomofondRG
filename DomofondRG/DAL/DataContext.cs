using DomofondRG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DomofondRG.DAL
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DomofondConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<City>()
        //        .HasRequired<Region>(c => c.Region)
        //        .WithMany(r => r.Cities)
        //        .HasForeignKey<int>(s => s.RegionId);

        //    base.OnModelCreating(modelBuilder);
        //}


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
    }
}