using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    [Table("Ogrenciler")]
    public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int OgrenciNo { get; set; }
        public string FakülteAdi { get; set; }
        public string BölümAdi { get; set; }
    }
}