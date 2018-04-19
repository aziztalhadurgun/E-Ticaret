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
            List<Uye> login = db.Uyes.ToList();
            Uye log = new Uye();

            return View();
        }
        [HttpPost]
        public ActionResult Login(Uye model)
        {
            DatabaseContext db = new DatabaseContext();
            List<Uye> login = db.Uyes.ToList();
            // yeni hesap için mail kontrolü
            Uye log2 = new Uye();
            log2 = login.Find(x => x.Email == model.Email);
            if (ModelState.IsValid)
            {
                if (log2 != null)
                {
                    ModelState.AddModelError("","Bu kullanıcı adı kullanılıyor.");
                    return View("Login", model);
                }
            }
            


            // login kısmı için 
            Uye log = new Uye();
            log = login.Find(x => x.Email == model.Email && x.Sifre == model.Sifre);
            if (log != null)
            {
                Session["ad"] = log.Adi; // bilgiler doğru ise login gerçekleşir ve Session'a kullanıcı adı atılır.
            }
            if (log != null)
            {
                return View("Index");

            }
            else
            {
                return View("Login");
            }            
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
            Uye uye1 = new Uye();
            uye1 = Uye.Find(x => x.Email == model.Email);
            if (uye1 != null)
            {
                ModelState.AddModelError("Email","bu mail zaten kayıtlı");
                return View("Register");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    if (model.Email != null)
                    {
                        if (uye.Email != model.Email)
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

                        db.Uyes.Add(uye);
                        db.SaveChanges();

                        return View("Login");
                        }
                    }
                }
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