using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using aracSecimi.Models.Siniflar;

namespace aracSecimi.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin

        [Authorize]
        public ActionResult Index( int sayfa =1)
        {
            var degerler = c.Aracs.OrderByDescending(x=>x.Id).ToList().ToPagedList(sayfa,10);
            return View(degerler);
        }

        [Authorize]
        public ActionResult Iletisim()
        {
            var degerler = c.Iletisims.ToList();
            return View(degerler);
        }

        [Authorize]
        public ActionResult IletisimMesajSil(int id)
        {
            var deger = c.Iletisims.Find(id);
            c.Iletisims.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Iletisim");
        }

        [Authorize]
        public ActionResult Hakkimizda()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }

        [Authorize]
        public ActionResult HakkimizdaGuncelle(Hakkimizda h)
        {
   
            var degerler = c.Hakkimizdas.Find(1);
            degerler.Baslik = h.Baslik;
            degerler.HakkimizdaYazi = h.HakkimizdaYazi;
            degerler.FotoUrl = h.FotoUrl;
            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }

        [Authorize]
        public ActionResult Admin()
        {
            var degerler = c.Admins.ToList();
            return View(degerler);
        }

        [Authorize]
        public ActionResult YeniKullaniciEkle(Admin a)
        {
            c.Admins.Add(a);
            c.SaveChanges();
            return RedirectToAction("Admin");
        }


        [Authorize]
        public ActionResult AdminSil(int id)
        {
            var deger = c.Admins.Find(id);
            c.Admins.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Admin");

        }


        [Authorize]
        public ActionResult AdminGüncelleId(int id)
        {
            var deger = c.Admins.Find(id);
            return View(deger);
        }


        [Authorize]
        public ActionResult AdminGuncelle(Admin a)
        {
            var degerler = c.Admins.Find(a.Id);
            degerler.KullaniciAdi = a.KullaniciAdi;
            degerler.Sifre = a.Sifre;
            c.SaveChanges();
            return RedirectToAction("Admin");

        }

        [Authorize]
        public ActionResult AracSecimi()
        {
            return View();
        }

        [Authorize]
        public ActionResult AracEkle(Arac a)
        {
            c.Aracs.Add(a);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult AracSil(int id)
        {
            var deger = c.Aracs.Find(id);
            c.Aracs.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        [Authorize]
        public ActionResult AracGuncelleId(int id)
        {
            var deger = c.Aracs.Find(id);
            return View(deger);
        }

        [Authorize]
        public ActionResult AracGuncelle(Arac a)
        {
            var degerler = c.Aracs.Find(a.Id);

            degerler.Fiyat = a.Fiyat;
            degerler.Marka = a.Marka;
            degerler.Seri = a.Seri;
            degerler.Model = a.Model;
            degerler.Renk = a.Renk;
            degerler.UretimYili = a.UretimYili;
            degerler.Yakit = a.Yakit;
            degerler.Vites = a.Vites;
            degerler.AracKm = a.AracKm;
            degerler.KasaTipi = a.KasaTipi;
            degerler.MotorGucu = a.MotorGucu;
            degerler.MotorHacmi = a.MotorHacmi;
            degerler.Cekis = a.Cekis;
            degerler.YakitTuketimi = a.YakitTuketimi;
            degerler.SehirIci = a.SehirIci;
            degerler.OrtalamaTuketim = a.OrtalamaTuketim;
            degerler.DepoHacmi = a.DepoHacmi;
            degerler.Hizlanma0_100 = a.Hizlanma0_100;
            degerler.AzamiSurat = a.AzamiSurat;
            degerler.MaxTork = a.MaxTork;
            degerler.FotoUrl = a.FotoUrl;
            degerler.FotoUrl2 = a.FotoUrl2;
            degerler.FotoUrl3= a.FotoUrl3;
            degerler.FotoUrl4 = a.FotoUrl4;
            degerler.FotoUrl5 = a.FotoUrl5;
            c.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}