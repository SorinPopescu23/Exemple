using System;
using WebApplication1_2019.Models;

namespace WebApplication1_2019.Controllers
{
    public interface IReservationService
    {
        object GetReservationById(Guid id);
        void Rezervare(Guid id);
        void CreateMasini(Masini reservation);
        object GetAllMasinis();
    }
}