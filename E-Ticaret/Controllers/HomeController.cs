using E_Ticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Compair()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Faq()
        {
            return View();
        }
        public ActionResult ForgetPass()
        {
            return View();
        }
        public ActionResult LegalNotice()
        {
            return View();
        }
        public ActionResult Login()
        {
            DatabaseContext db = new DatabaseContext();
            db.Database.CreateIfNotExists();
            List<Kategoriler> login = db.Kategorilers.ToList();
            Kategoriler log = new Kategoriler();

            return View(log);
        }
        [HttpPost]
        public ActionResult Login(string text)
        {
            DatabaseContext db = new DatabaseContext();
            //List<Login> login = db.Logins.ToList();
            //Login log = new Login();

            Session["ad"] = text;

            //log = login.Find(x => x.KullaniciAdi == mail && x.Sifre == pass);
            return View();
        }
        public ActionResult Normal()
        {
            return View();
        }
        public ActionResult ProductDetails()
        {
            return View();
        }
        public ActionResult ProductSummary()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Uye model)
        {
            DatabaseContext db = new DatabaseContext();
            List<Uye> Uye = db.Uyes.ToList();
            Uye uye = new Uye();
            //uye = Uye.Find(x => x.Email == model.Email);


            if (ModelState.IsValid)
            {
                if (uye != null)
                {
                    if (uye.Email == model.Email)
                    {
                        ModelState.AddModelError("mail", "Bu mail zaten kayıtlı");
                        return View("Login");
                    }
                }
                
                    if (model.Email != null)
                    {
                        uye.Adi = model.Adi;
                        uye.Soyadi = model.Soyadi;
                        uye.Email = model.Email;
                        uye.Sifre = model.Sifre;
                        uye.SifreTekrar = model.SifreTekrar;
                        uye.ActiveGuid = false;
                        uye.TelefonNo = model.TelefonNo;
                        uye.Cinsiyet = model.Cinsiyet;
                        uye.DogumTarihi = model.DogumTarihi;
                        uye.Adres = model.Adres;

                    }
                    db.Uyes.Add(uye);
                    db.SaveChanges();

                    return View("Login");
                
            }
            return View(model);
        }
        public ActionResult SpecialOffer()
        {
            return View();
        }
        public ActionResult Tac()
        {
            return View();
        }
    }
}