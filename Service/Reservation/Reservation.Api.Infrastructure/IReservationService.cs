using Reservation.Api.Model;

namespace Reservation.Api.Infrastructure
{
    public interface IReservationService
    {
        public ReservationDto GetReservationByBkgNo(int bkgNo);
    }
}
