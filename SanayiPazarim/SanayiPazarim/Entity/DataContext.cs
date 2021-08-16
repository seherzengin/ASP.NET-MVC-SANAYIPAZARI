using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SanayiPazarim.Entity
{
    public class DataContext:DbContext
    {
        public DataContext() : base("dataConnection")//veritabanı bağlantısını gerçekleştirdik.
        {
            Database.SetInitializer(new DataInitializer());//DataInitializer'ı devreye sokuyoruz.
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Offer> Offers { get; set; }
    }
}