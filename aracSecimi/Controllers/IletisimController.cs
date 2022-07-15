using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aracSecimi.Models;
using aracSecimi.Models.Siniflar;

namespace aracSecimi.Controllers
{
    public class IletisimController : Controller 
    {
        Context c = new Context();

        // GET: Iletisim
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ekle(Iletisim i )
        {
            c.Iletisims.Add(i);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}