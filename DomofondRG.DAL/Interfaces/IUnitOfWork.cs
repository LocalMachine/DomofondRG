using System;
using System.Collections.Generic;
using System.Text;
using DomofondRG.DAL.Entities;

namespace DomofondRG.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //IRepository<Ads> Ads { get; }
        //IRepository<AdsType> AdsTypes { get; }

        IRepository<Region> Regions { get; }

        //IRepository<City> Cities { get; }
        //IRepository<Favorite> Favorites { get; }
        //IRepository<ObjectsType> ObjectsTypes { get; }
        //IRepository<Photo> Photos { get; }
        //IRepository<Role> Roles { get; }
        //IRepository<RoomsType> RoomsTypes { get; }
        //IRepository<StatusType> StatusTypes { get; }
        //IRepository<User> Users { get; }

        void Save();
    }
}
