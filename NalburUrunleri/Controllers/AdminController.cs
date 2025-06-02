using NalburUrunleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NalburUrunleri.Controllers
{
    public class AdminController : Controller
    {

        private NalburDBEntities db = new NalburDBEntities();
        // GET: Admin
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            var urunler = db.ProductTable.ToList();

            ViewBag.urunler = urunler;

            return View();
        }

        public ActionResult Edit(int Id)
        {
            var urunler = db.ProductTable.Find(Id);
            ViewBag.urunler = urunler;

            return View();
        }
        [HttpPost]
        public ActionResult Edit(ProductTable model)
        {
            if (ModelState.IsValid)
            {
                var urun = db.ProductTable.Find(model.Id);
                if (urun != null)
                {
                    urun.Name = model.Name;
                    urun.Price = model.Price;

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View();

        }

        public ActionResult Delete(int Id)
        {
            var urun = db.ProductTable.Find(Id);
            ViewBag.urun = urun;
            return View();
        }
        [HttpPost]
        public ActionResult Delete(ProductTable model)
        {
            var urun = db.ProductTable.Find(model.Id);
            if (urun != null)
            {
                db.ProductTable.Remove(urun);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Name, int Price)
        {
            var yeniUrun = new ProductTable
            {
                Name = Name
                ,
                Price = Price
            };
            db.ProductTable.Add(yeniUrun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}