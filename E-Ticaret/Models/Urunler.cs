using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret.Models
{
    public class Urunler
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public string Stok { get; set; }
        public int LikeCount { get; set; }
        public int UnLikeCount { get; set; }
        public string Foto { get; set; }
        public string Fiyat { get; set; }

        public virtual AltKategori AltKategoriId { get; set; }
    }
}