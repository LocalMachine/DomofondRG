using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomofondRG.Models
{
    public class Region
    {
        [Key]
        public int RegionId { get; set; }
        public string RegionName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Ads> Ads { get; set; }
    }
}