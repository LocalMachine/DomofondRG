using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using DomofondRG.BLL.Interfaces;
using DomofondRG.BLL.DTO;
using DomofondRG.Models;
using AutoMapper;
using DomofondRG.BLL.Infrastructure;


namespace DomofondRG.Controllers
{
    public class HomeController : Controller
    {
        IRegionService regionService;
        public HomeController(IRegionService serv)
        {
            regionService = serv;
        }

        public ActionResult Index()
        {
            IEnumerable<RegionDTO> regionDTOs = regionService.GetRegions();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<RegionDTO, RegionViewModel>()).CreateMapper();
            var regions = mapper.Map<IEnumerable<RegionDTO>, List<RegionViewModel>>(regionDTOs);

            return View(regions);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}