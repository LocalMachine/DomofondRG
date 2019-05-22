using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomofondRG.Models
{
    public class AdsType
    {
        [Key]
        public int AdsTypeId { get; set; }
        public string AdsTypeName { get; set; }

        public virtual ICollection<Ads> Ads { get; set; } // связная коллекция с таблицей объялений
    }
}