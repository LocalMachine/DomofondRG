using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomofondRG.Models
{
    public class RoomsType
    {
        [Key]
        public int RoomsTypeId { get; set; }
        public string RoomsTypeName { get; set; }

        public virtual ICollection<Ads> Ads { get; set; } // связная коллекция с таблицей объялений
    }
}