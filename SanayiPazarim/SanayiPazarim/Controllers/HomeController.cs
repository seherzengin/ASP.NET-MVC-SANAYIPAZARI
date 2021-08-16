using SanayiPazarim.Entity;
using SanayiPazarim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SanayiPazarim.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Products.ToList()
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0,47) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0,47) + "..." : i.Description,//Description 47 karakterden büyükse, sadece 47 karakter alıp sonuna 3 nokta ekleyecek.
                    SubDescription = i.SubDescription.Length > 50 ? i.SubDescription.Substring(0, 47) + "..." : i.SubDescription,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                });

            return View(urunler);//Anasayfada ürünleri listeler.
        }

        public ActionResult Details(int id)//Ürün detay sayfası için.
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }

        public ActionResult List(int? id)
        {
            var urunler = _context.Products.ToList()//card da yazılar için düzenlemeler yaptığımız yer.
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,//Description 47 karakterden büyükse, sadece 47 karakter alıp sonuna 3 nokta ekleyecek.
                    SubDescription = i.SubDescription.Length > 50 ? i.SubDescription.Substring(0, 47) + "..." : i.SubDescription,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }

            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
    }
}