using DomofondRG.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomofondRG.BLL.DTO
{
    public class RegionDTO
    {
        public int Id { get; set; }
        public string RegionName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Ads> Ads { get; set; }
    }
}
