using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret.Models
{
    public class AltKategori
    {
        public int Id { get; set; }
        public string AltKategoriAdi { get; set; }

        public virtual Kategoriler Kategoriler { get; set; }
    }
}