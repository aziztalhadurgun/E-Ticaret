using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret.Models
{
    public class Kategoriler
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public virtual List<AltKategori> AltKategoriId { get; set; }
    }
}