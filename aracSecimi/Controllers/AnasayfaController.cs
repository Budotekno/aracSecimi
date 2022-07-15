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
    public class AnasayfaController : Controller
    {
        Context c = new Context();

        // GET: Anasayfa
        public ActionResult Index(int sayfa=1)
        {
            //var degerler = c.Aracs.ToList();
            var degerler = c.Aracs.OrderByDescending(x=>x.Id).ToList().ToPagedList(sayfa,15);
            return View(degerler);
        }

        public ActionResult AracDetay(Arac a)
        {
            var deger = c.Aracs.Find(a.Id);
            ViewBag.Id = deger.Id;
            ViewBag.FotoUrl = deger.FotoUrl;
            ViewBag.FotoUrl2 = deger.FotoUrl2;
            ViewBag.FotoUrl3 = deger.FotoUrl3;
            ViewBag.FotoUrl4 = deger.FotoUrl4;
            ViewBag.FotoUrl5 = deger.FotoUrl5;
            ViewBag.Fiyat = deger.Fiyat;
            ViewBag.Marka = deger.Marka;
            ViewBag.Seri = deger.Seri;
            ViewBag.Model = deger.Model;
            ViewBag.UretimYili = deger.UretimYili;
            ViewBag.Yakit = deger.Yakit;
            ViewBag.Vites = deger.Vites;
            ViewBag.AracKm = deger.AracKm;
            ViewBag.KasaTipi = deger.KasaTipi;
            ViewBag.MotorGucu = deger.MotorGucu;
            ViewBag.MotorHacmi = deger.MotorHacmi;
            ViewBag.Cekis = deger.Cekis;
            ViewBag.Renk = deger.Renk;
            ViewBag.YakitTuketimi = deger.YakitTuketimi;
            ViewBag.SehirIci = deger.SehirIci;
            ViewBag.OrtalamaTuketim = deger.OrtalamaTuketim;
            ViewBag.Hizlanma0_100 = deger.Hizlanma0_100;
            ViewBag.AzamiSurat = deger.AzamiSurat;
            ViewBag.MaxTork = deger.MaxTork;
            ViewBag.DepoHacmi = deger.DepoHacmi;
           
            return View(deger);
        }


    }
}