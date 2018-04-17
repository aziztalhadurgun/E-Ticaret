using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret.Models
{
    public class Sepet
    {
        public int Id { get; set; }

        public virtual List<Urunler> UrunId { get; set; }
        public virtual Uye Uye { get; set; }
    }
}