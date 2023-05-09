using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationSystem.Models;

namespace ReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PNRStatusInfoController : ControllerBase
    {
        ReservationDetail objModel = new ReservationDetail();

        [HttpGet]
        public ReservationDetail GetMyPNRStatus(string pnr)
        {
            ReservationDetail resp = objModel.GetReservationStatus(pnr);
            // Do data manipulation if any

            return resp;
        }
    }
}
