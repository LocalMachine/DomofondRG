using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DomofondRG.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int? RoleId { get; set; }

        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        //[InverseProperty("User")]
        public virtual ICollection<Ads> Ads { get; set; }

        //[InverseProperty("User")]
        public virtual ICollection<Favorite> Favorites { get; set; }
    }
}