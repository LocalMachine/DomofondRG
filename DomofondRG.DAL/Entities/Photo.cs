using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DomofondRG.DAL.Entities
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Описание фото")]
        public string Title { get; set; } // описание фото

        [Display(Name = "Загрузить фото")]
        public string RelativePath { get; set; } // относительный путь
        public string AbsolutePath { get; set; } // абсолютный путь

        public int? AdsId { get; set; }
        public int? UserId { get; set; }
        

        [ForeignKey("AdsId")]
        public virtual Ads Ads { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}