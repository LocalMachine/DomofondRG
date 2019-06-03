using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using DomofondRG.BLL.Services;
using DomofondRG.BLL.Interfaces;

namespace DomofondRG.Util
{
    public class RegionModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRegionService>().To<RegionService>();
        }
    }
}