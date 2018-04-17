using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret.Models
{
    public class Yorumlar
    {
        public int Id { get; set; }
        public string Yorum { get; set; }
        public DateTime Tarih { get; set; }

        public virtual List<Urunler> Urun { get; set; }
        public virtual Uye UyeId { get; set; }
    }
}