using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomofondRG.Models
{
    public class StatusType
    {
        [Key]
        public int StatusTypeId { get; set; }
        public string StatusTypeName { get; set; }

        public virtual ICollection<Ads> Ads { get; set; } // связная коллекция с таблицей объялений
    }
}