using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DomofondRG.Models
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AdsId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("AdsId")]
        public virtual Ads Ads { get; set; }

        //[InverseProperty("Favorite")]
        public virtual ICollection<Ads> AdsCollection { get; set; }
    }
}