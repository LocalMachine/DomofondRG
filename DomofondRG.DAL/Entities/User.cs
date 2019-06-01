using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DomofondRG.DAL.Entities
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

        public virtual ICollection<Ads> Ads { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }
    }
}