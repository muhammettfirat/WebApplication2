using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication7.Controllers;
using WebApplication7.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        SistemDb db = new SistemDb();
        // GET: Home
        public ActionResult Index()
        {
            db.Kullanicilar.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Kullanici kullanici)
        {
            var kullanicidb = db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullanici.KullaniciAdi && x.Sifre == kullanici.Sifre);
            if (kullanicidb != null)
            {
                FormsAuthentication.SetAuthCookie(kullanici.KullaniciAdi, false);
                return RedirectToAction("Index", "Ogrenciler");
            }
            else
            {
               
                return View();
            }
        }
    }
}