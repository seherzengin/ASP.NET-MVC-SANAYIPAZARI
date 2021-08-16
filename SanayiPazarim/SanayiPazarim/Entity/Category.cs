using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanayiPazarim.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]//Burda gerçekleştirdiğimiz olay DataAnnotasion olarak nitelendirilir.Kullanıcının görmesini istediğimiz değişken ismini yazarız.
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }//Category ve product arasındaki ilişkiyi kurduk.Bir category seçtiğimizde o kategoriye ait ürünleri listeler.
    }
}