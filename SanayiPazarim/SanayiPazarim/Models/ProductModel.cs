using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanayiPazarim.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTimeOffset ProductCreateTime { get; set; }
        public DateTimeOffset ProductFinishedTime { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string SubDescription { get; set; }

        public int CategoryId { get; set; }//Herbir ürünün bir kategorisi olduğunu temsil eder.
    }
}