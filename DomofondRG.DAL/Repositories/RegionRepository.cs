using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using DomofondRG.DAL.Entities;
using DomofondRG.DAL.Interfaces;
using System.Data.Entity;
using DomofondRG.DAL.EF;

namespace DomofondRG.DAL.Repositories
{
    public class RegionRepository : IRepository<Region>
    {
        private DataContext db;

        public RegionRepository(DataContext context)
        {
            this.db = context;
        }

        public IEnumerable<Region> GetAll()
        {
            return db.Regions;
        }

        public Region Get(int id)
        {
            return db.Regions.Find(id);
        }

        public void Create(Region region)
        {
            db.Regions.Add(region);
        }

        public void Update(Region region)
        {
            db.Entry(region).State = EntityState.Modified;
        }

        public IEnumerable<Region> Find(Func<Region, Boolean> predicate)
        {
            return db.Regions.Where(predicate).ToList();
        }

        public void Delete (int id)
        {
            Region region = db.Regions.Find(id);
            if (region != null)
                db.Regions.Remove(region);
        }
    }
}
