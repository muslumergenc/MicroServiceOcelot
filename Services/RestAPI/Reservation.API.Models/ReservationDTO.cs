namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public int BookingNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut{ get; set; }
        public DateTime BookingDate { get; set; }
        public decimal Amount { get; set; }
    }
}
