using System;
using System.Collections.Generic;
using System.Text;
using DomofondRG.BLL.DTO;
using DomofondRG.BLL.Interfaces;
using DomofondRG.BLL.Infrastructure;
using DomofondRG.DAL.Entities;
using DomofondRG.DAL.Interfaces;
using AutoMapper;



namespace DomofondRG.BLL.Services
{
    public class RegionService : IRegionService
    {
        IUnitOfWork Database { get; set; }

        public RegionService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void MakeRegion(RegionDTO regionDto) // получает объект для сохранения с  уровня представления и создает по нему обхект Region и сохраняет его в бд
        {
            Region region = Database.Regions.Get(regionDto.Id);

            //валидация
            if (region == null)
                throw new ValidationException("Регион не найден", "");

            //применение скидки или другой БЛ (в данном случае не надо)

        }

        public IEnumerable<RegionDTO> GetRegions() //получает все регионы и с помощью автомаппера преобразует их в RegionDTO и передает на уровень представления.
        {
            //применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Region, RegionDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Region>, List<RegionDTO>>(Database.Regions.GetAll());
        }

        public RegionDTO GetRegion(int? id)// передает отдельный регион на уровень представления
        {
            if (id == null)
                throw new ValidationException("Не установлено id региона", "");
            var region = Database.Regions.Get(id.Value);
            if (region == null)
                throw new ValidationException("Регион не найден", "");

            return new RegionDTO { Id = region.Id, RegionName = region.RegionName};
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
