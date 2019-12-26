using JsonFx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_2019.Models;

namespace WebApplication1_2019.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View(/*new List<Models.Masini>()*/);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       /* private List<Masini> masini;
        public HomeController()
        {
            masini = new List<Masini>()
        {
            new Masini()
            { Id = 1,  Zona ="Circumvalatiunii nr.27",Model_masina="Mercedes-Benz C220"},
            new Masini()
            { Id = 2,  Zona ="Circumvalatiunii nr.27",Model_masina="Mercedes-Benz C220"},
            new Masini()
            { Id = 3, Zona ="Torontalului nr.2",Model_masina="Audi A4"},
            new Masini()
            { Id = 4, Zona ="Torontalului nr.2",Model_masina="Volvo S90"},
            new Masini()
            { Id = 5, Zona ="Gh. Lazar nr.36" ,Model_masina="BMW 320"},
            new Masini()
            { Id = 6, Zona ="Gh. Lazar nr.36" ,Model_masina="BMW 720"},
            new Masini()
            { Id = 7, Zona ="Sagului Shopping City",Model_masina="Opel"},
            new Masini()
            { Id = 8, Zona ="Lugojului",Model_masina="Volkswagen Passat b8"},

        };
        }
        public ActionResult About()
        {

            return View(masini);
        }*/


      }
}