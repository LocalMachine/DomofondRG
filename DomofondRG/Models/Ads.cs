using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DomofondRG.Models
{
    public class Ads
    {
        [Key]
        public int Id { get; set; }

        public int RegionId { get; set; } // регион  
        public int CityId { get; set; } // город
        public int AdsTypeId { get; set; } //тип объявления (аренда, продажда)
        public int ObjectTypeId { get; set; } //тип жилья (котедж, дача дом, танхаус, новостройка, вторичка, отель, офис, производство, магазин, склад, общепит)
        public int RoomsTypeId { get; set; } //кол-во комнат (студия, 1, 2, 3, 4+)

        public decimal Price { get; set; } //цена
        public string Description { get; set; } // описание 

        public int StatusTypeId { get; set; } // статус объявления
        public int UserId { get; set; }
        public int PhotoId { get; set; }
        public int? FavoriteId { get; set; }

        public DateTime DatePublication { get; set; } //  дата публикации объявления
        public DateTime? DateUpdatePublication { get; set; } // дата обновлении объявления

        // внешние ключи
        [ForeignKey("RegionId")]
        public virtual Region Region { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        [ForeignKey("AdsTypeId")]
        public virtual AdsType AdsType { get; set; }

        [ForeignKey("ObjectTypeId")]
        public virtual ObjectsType ObjectsType { get; set; }

        [ForeignKey("RoomsTypeId")]
        public virtual RoomsType RoomsType { get; set; }

        [ForeignKey("StatusTypeId")]
        public virtual StatusType StatusType { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("PhotoId")]
        public virtual Photo Photo { get; set; }

        [ForeignKey("FavoriteId")]
        public virtual Favorite Favorite { get; set; }


        //[InverseProperty("Ads")]
        //public virtual ICollection<Photo> PhotoCollection { get; set; }

        //[InverseProperty("Ads")]
        //public virtual ICollection<Favorite> FavoriteCollection { get; set; }
    }
}