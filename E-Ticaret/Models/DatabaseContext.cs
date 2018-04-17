using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Ticaret.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<AltKategori> AltKategoris { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Satislar> Satislars { get; set; }
        public DbSet<Sepet> Sepets { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Uye> Uyes { get; set; }
        public DbSet<Yetki> Yetkis { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
    }
}