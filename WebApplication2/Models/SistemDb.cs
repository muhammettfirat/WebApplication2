using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class SistemDb:DbContext
    {
        public DbSet<Ogrenci> Ogreciler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public SistemDb()
        {
            Database.SetInitializer(new DbInitializer());      
        }
       
    }
}