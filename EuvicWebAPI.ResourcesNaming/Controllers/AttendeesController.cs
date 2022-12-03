using Microsoft.AspNetCore.Mvc;

namespace Euvic.WebAPI.ResourcesNaming.Controllers
{
    [Route("api/attendees")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        // w każdym endpoincie popraw metode http oraz route jeżeli są źle
        // całkowiscie zignoruje tutaj parametery metody, skupcie się wyłączenie na metodzie http i route

        [HttpGet("getAttendeeById")]
        public IActionResult GetAttendeeById() => Ok();

        [HttpPut("CreateAttendee")]
        public IActionResult CreateAttendee() => Ok();

        [HttpPost("")]
        public IActionResult ChangeAttendeeAllowedHours() => Ok();

        [Route("GetAttendeeAllowedHours")]
        public IActionResult GetAttendeeAllowedHours() => Ok();

        [HttpGet("")]
        public IActionResult GetAttendees() => Ok();
    }
}
