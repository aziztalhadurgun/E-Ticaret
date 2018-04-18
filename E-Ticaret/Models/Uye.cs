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
            StringLength(25)]
        public string Adi { get; set; }

        [DisplayName("İsim"),
           StringLength(25)]
        public string Soyadi { get; set; }

        [DisplayName("İsim"),
            StringLength(25), Required(ErrorMessage = "E mail kullanılıyor")]
        public string Email { get; set; }

        [DisplayName("İsim")]
        public string Sifre { get; set; }

        [DisplayName("İsim")]
        public string SifreTekrar { get; set; }


        public Boolean ActiveGuid { get; set; }


        public int TelefonNo { get; set; }

        [DisplayName("İsim")]
        public string Cinsiyet { get; set; }


        public DateTime DogumTarihi { get; set; }

        [DisplayName("İsim")]
        public string Adres { get; set; }

        public virtual List<Yetki> YetkiId { get; set; }
    }
}