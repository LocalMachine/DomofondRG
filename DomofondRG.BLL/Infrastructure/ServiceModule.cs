using System;
using System.Collections.Generic;
using System.Text;
using DomofondRG.DAL.Interfaces;
using DomofondRG.DAL.Repositories;
using Ninject.Modules;

namespace DomofondRG.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
