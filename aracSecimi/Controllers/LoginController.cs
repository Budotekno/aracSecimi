using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using aracSecimi.Models.Siniflar;

namespace aracSecimi.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin a)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.KullaniciAdi == a.KullaniciAdi && x.Sifre == a.Sifre);
            if(bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi, false);
                Session["KullaniciAdi"] = bilgiler.KullaniciAdi.ToString();
                return RedirectToAction("Index", "Admin");

            }
            else 
            {
                ViewBag.yanlıs = "Eksik veya hatalı giriş yaptınız. Lütfen tekrar deneyiniz!";
                return View();

            }
        }



        public ActionResult Cikis()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }


    }
}