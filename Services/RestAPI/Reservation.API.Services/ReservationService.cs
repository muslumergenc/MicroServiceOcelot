using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBookingNumber(int number)
        {
            return new ReservationDTO
            {
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(10000),
                BookingDate = DateTime.Now,
                CheckIn = DateTime.Now.Date.AddDays(30),
                CheckOut = DateTime.Now.Date.AddDays(33),
                BookingNumber = number
            };
        }
    }
}
