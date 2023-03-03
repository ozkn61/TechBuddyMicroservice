using Microsoft.AspNetCore.Mvc;
using Reservation.Api.Infrastructure;
using System.Threading.Tasks;

namespace Reservation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("{bkgNo}")]
        public async Task<IActionResult> Get(int bkgNo)
        {
            var reservation =  _reservationService.GetReservationByBkgNo(bkgNo);
            return Ok(reservation);
        }
    }
}
