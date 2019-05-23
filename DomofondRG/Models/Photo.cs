using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DomofondRG.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Описание фото"), StringLength(60, MinimumLength = 3)]
        public string Title { get; set; } // описание фото

        [Display(Name = "Загрузить фото")]
        public string RelativePath { get; set; } // относительный путь
        public string AbsolutePath { get; set; } // абсолютный путь

        public int AdsId { get; set; }

        [Required]
        public virtual Ads Ads { get; set; }

        //[InverseProperty("Photo")]
        public virtual ICollection<Ads> AdsCollection { get; set; } // определение внешнего ключа для 
    }
}