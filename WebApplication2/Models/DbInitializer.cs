using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication7.Controllers;
using WebApplication7.Models;

namespace WebApplication2.Models
{
    public class DbInitializer:CreateDatabaseIfNotExists<SistemDb>
    {
        protected override void Seed(SistemDb context)
        {
            Kullanici kullanici = new Kullanici()
            {
                KullaniciAdi = "admin",
                Sifre = "123"
            };
            context.Kullanicilar.Add(kullanici);
            context.SaveChanges();
            Ogrenci ogrenci = new Ogrenci()
            {
                Ad="Muhammet",
                Soyad="FIRAT",
                OgrenciNo=321,
                FakülteAdi="Mühendislik",
                BölümAdi="Mekatronik Mühendisliği"
            };
            context.Ogreciler.Add(ogrenci);
            context.SaveChanges();
        }
    }
}