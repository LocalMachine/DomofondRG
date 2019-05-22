using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomofondRG.Models
{
    public class ObjectsType
    {
        [Key]
        public int ObjectsTypeId { get; set; }
        public string ObjectsTypeName { get; set; }

        public virtual ICollection<Ads> Ads { get; set; } // связная коллекция с таблицей объялений
    }
}