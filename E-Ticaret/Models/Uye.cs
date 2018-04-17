using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret.Models
{
    public class Uye
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string SifreTekrar { get; set; }
        public Boolean ActiveGuid { get; set; }
        public int TelefonNo { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Adres { get; set; }

        public virtual List<Yetki> YetkiId { get; set; }
    }
}