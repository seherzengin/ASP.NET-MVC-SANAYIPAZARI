using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SanayiPazarim.Entity
{
    public class Offer
    {
        public int Id { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Fiyat")]
        public int Price { get; set; }

        [DisplayName("Teklif Oluşturulma Tarihi")]
        public DateTime OfferCreateTime { get; set; }

        public int? ProductId { get; set; }//Ürünün teklif alma zorunluluğu yok.
    }
}