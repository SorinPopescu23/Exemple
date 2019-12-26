using JsonFx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_2019.Models;

namespace WebApplication1_2019.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService reservationService;
        public ReservationController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }
        
        // GET: Reservation
        public ActionResult About()
        {
            return View(reservationService.GetAllMasinis()) ;
        }

        // GET: Reservation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reservation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reservation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Masini reservation)
        {
            try
            {
                reservationService.CreateMasini(reservation);

                return RedirectToAction(nameof(About));
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservation/Delete
        public ActionResult Rezervare(Guid id)
        {
            var reservation = reservationService.GetReservationById(id);
            return View(reservation);
        }

        // POST: Reservation/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Rezervare(Guid id, IFormCollection collection)
        {
            try
            {
                reservationService.Rezervare(id);

                return RedirectToAction(nameof(About));
            }
            catch
            {
                return View();
            }
        }
    }

    public interface IFormCollection
    {
    }
}