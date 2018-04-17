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