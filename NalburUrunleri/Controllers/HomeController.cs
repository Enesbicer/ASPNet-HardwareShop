using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NalburUrunleri.Models;

namespace NalburUrunleri.Controllers
{
    public class HomeController : Controller
    {
        private NalburDBEntities db = new NalburDBEntities();
        public ActionResult Index()
        {

            var resim = db.ImageTable.Select(x => x.IMAGEURL).Take(3).ToList();
            // Veritabanından ilk 3 ürünü çek
            var ilkUcUrun = db.ProductTable
                               .OrderBy(p => p.Id)   
                               .Take(3)
                               .ToList();

            // ViewBag.Products’a yerleştir
            ViewBag.Products = ilkUcUrun;

            return View(resim);

        }

        [Authorize]
        public ActionResult Product()
        {
            var urunler = db.ProductTable.ToList();
            return View(urunler);
        }


        [Authorize]
        public ActionResult About()
        {
            
            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {

            return View();
        }


    }
}