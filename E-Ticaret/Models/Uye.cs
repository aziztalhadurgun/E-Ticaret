using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace E_Ticaret.Models
{
    [Table("Üyeler")]
    public class Uye
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("İsim"),
            StringLength(25),Required(ErrorMessage ="Lütfen {0} giriniz.")]
        public string Adi { get; set; }

        [DisplayName("Soy isim"),
           StringLength(25),Required(ErrorMessage = "Lütfen {0} giriniz.")]
        public string Soyadi { get; set; }

        [DisplayName("E-mail"),
            StringLength(25), Required(ErrorMessage = "Lütfen E-mail adresinizi giriniz.")]
        public string Email { get; set; }

        [DisplayName("Şifre"), Required(ErrorMessage = "Lütfen {0} giriniz.")]
        public string Sifre { get; set; }

        [DisplayName("Şifre Tekrar"),Compare("Sifre"), Required(ErrorMessage = "Lütfen {0} giriniz.")]
        public string SifreTekrar { get; set; }


        public Boolean ActiveGuid { get; set; }


        public int TelefonNo { get; set; }

        [DisplayName("Cinsiyet"), Required(ErrorMessage = "Lütfen {0} giriniz.")]
        public string Cinsiyet { get; set; }

        [DisplayName("Doğum Tarihi"), Required(ErrorMessage = "Lütfen {0} giriniz.")]
        public DateTime DogumTarihi { get; set; }

        [DisplayName("Adres"), Required(ErrorMessage = "Lütfen {0} giriniz.")]
        public string Adres { get; set; }

        public virtual List<Yetki> YetkiId { get; set; }
    }
}