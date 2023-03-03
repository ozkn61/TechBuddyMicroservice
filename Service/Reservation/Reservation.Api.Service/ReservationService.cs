using Reservation.Api.Infrastructure;
using Reservation.Api.Model;
using System;

namespace Reservation.Api.Service
{
    public class ReservationService : IReservationService
    {
        public ReservationDto GetReservationByBkgNo(int bkgNo)
        {
            var rnd = new Random();

            return new ReservationDto
            {
                Id = rnd.Next(100),
                BookingNumber = bkgNo,
                CheckinDate = DateTime.Now.AddDays(30),
                CheckoutDate = DateTime.Now.AddDays(37),
                BookingDate = DateTime.Now,
                Amount = rnd.Next(10000)
            };
        }
    }
}
