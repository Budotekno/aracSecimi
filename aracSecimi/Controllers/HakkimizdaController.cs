using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aracSecimi.Models.Siniflar;

namespace aracSecimi.Controllers
{
    public class HakkimizdaController : Controller
    {

        Context c = new Context();

        // GET: Hakkimizda
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}