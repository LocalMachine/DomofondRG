using System;
using System.Collections.Generic;
using System.Text;
using DomofondRG.DAL.Entities;
using DomofondRG.DAL.Interfaces;
using DomofondRG.DAL.EF;

namespace DomofondRG.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DataContext db;
        private RegionRepository regionRepository;
        
        public EFUnitOfWork(string connectionString)
        {
            db = new DataContext(connectionString);
        }

        public IRepository<Region> Regions
        {
            get
            {
                if (regionRepository == null)
                    regionRepository = new RegionRepository(db);
                return regionRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
