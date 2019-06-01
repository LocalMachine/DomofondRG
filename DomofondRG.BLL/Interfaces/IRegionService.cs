using System;
using System.Collections.Generic;
using System.Text;
using DomofondRG.BLL.DTO;


namespace DomofondRG.BLL.Interfaces
{
    public interface IRegionService
    {
        void MakeRegion(RegionDTO regionDto);
        RegionDTO GetRegion(int? id);
        IEnumerable<RegionDTO> GetRegions();
        void Dispose();
    }
}
