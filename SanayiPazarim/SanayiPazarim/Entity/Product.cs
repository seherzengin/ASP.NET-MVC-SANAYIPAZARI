using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SanayiPazarim.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [DisplayName("Başlangıç Tarihi")]
        public DateTimeOffset ProductCreateTime { get; set; }

        [DisplayName("Bitiş Tarihi")]
        public DateTimeOffset ProductFinishedTime { get; set; }

        [DisplayName("Resim")]
        public string Image { get; set; }

        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }

        [DisplayName("Ürün Alt Açıklaması")]
        public string SubDescription { get; set; }

        public bool IsHome { get; set; }//true ise ürün anasayfada gözükecek.

        public bool IsApproved { get; set; }//ürünün onaylı olmadığını kontrol eder.

        public int CategoryId { get; set; }//Herbir ürünün bir kategorisi olduğunu temsil eder.

        public Category Category { get; set; }

    }
}