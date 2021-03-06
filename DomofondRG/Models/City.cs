﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DomofondRG.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int RegionId { get; set; }

        [ForeignKey("RegionId")] // внешний ключ поля 
        public virtual Region Region { get; set; }
        public virtual ICollection<Ads> Ads { get; set; }
    }
}