using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aracSecimi.Models.Siniflar;

namespace aracSecimi.Controllers
{
    public class AracSecimiController : Controller
    {
        Context c = new Context();

        // GET: AracSecimi
        public ActionResult Index(int id = 11)
        {

            var bulunanId = c.AracSorus.Find(id);

            ViewBag.Soru = bulunanId.Soru;
            ViewBag.A = bulunanId.A;
            ViewBag.B = bulunanId.B;
            ViewBag.C = bulunanId.C;
            ViewBag.D = bulunanId.D;

            ViewBag.AId = bulunanId.AId;
            ViewBag.BId = bulunanId.BId;
            ViewBag.CId = bulunanId.CId;
            ViewBag.DId = bulunanId.DId;

            ViewBag.AracId = bulunanId.AracId;
            return View();
        }

        public ActionResult AracSonuc(int id)
        {
            var deger = c.Aracs.Find(id);

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
            return View();
        }


      
    }
}