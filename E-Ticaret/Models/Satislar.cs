using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret.Models
{
    public class Satislar
    {
        public int Id { get; set; }

        public virtual List<Urunler> UrunId { get; set; }
        public virtual Sepet SepetId { get; set; }
    }
}